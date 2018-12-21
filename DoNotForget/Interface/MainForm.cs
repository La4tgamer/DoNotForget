﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarSystem;
using System.Globalization;

namespace Interface {
    public partial class MainForm : Form {
        public static ScheduleService scheduleService = new ScheduleService();   //日程管理
        public Music bgmusic = new Music();   //背景音乐
        Clock MyClock = new Clock();//绘画类
        DateTime paintTime = DateTime.Now;//绘画事件的时间
        MinimumForm mForm;//小窗口生成
        bool winFlag = false;//判断缩小到托盘时候的状态（true大窗口，false小窗口）
        //刷新显示的今日日程
        private void UpdateDisplayTodaySchedules(DateTime dateTime)
        {
            clbTodaySchedules.Items.Clear();      //首先清空所有日程
            scheduleService.UpdateTodaySchedule(dateTime);
            foreach (Schedule schedule in scheduleService.todaySchedules)
            {
                clbTodaySchedules.Items.Add(schedule.ToStringShort());
            }
        }
        public MainForm() {
            InitializeComponent();
            scheduleService.AddSchedule(new Schedule());
            scheduleService.AddSchedule(new Schedule());
            scheduleService.AddSchedule(new Schedule());
            scheduleService.AddSchedule(new Schedule());
            UpdateDisplayTodaySchedules(DateTime.Now);
            mForm = new MinimumForm(this);//创建小窗口但不显示
        }
        //添加日程的按钮响应时间
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddScheduleForm addScheduleForm = new AddScheduleForm();
            addScheduleForm.ShowDialog();
            UpdateDisplayTodaySchedules(panelMonth1.Datetime);
        }
        //查看所有日程的按钮响应事件
        private void btnQueryAllSchedules_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox()
            {
                Size = new Size(350, 250),
                Location = new Point(18, 0),
                HorizontalScrollbar = true,
        };
            Form form = new Form
            {
                Text = "查看所有日程",
                Size = new Size(400, 300),
                BackColor = Color.LightBlue,
                Location = new Point(600, 350),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
            };
            foreach (Schedule schedule in scheduleService.allSchedules)
            {
                listBox.Items.Add(schedule.ToStringAll());
            }
            form.Controls.Add(listBox);
            form.ShowDialog();
        }
        //删除日程的按钮响应事件
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteScheduleForm deleteScheduleForm = new DeleteScheduleForm();
            deleteScheduleForm.ShowDialog();
            UpdateDisplayTodaySchedules(panelMonth1.Datetime);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyScheduleForm modifyScheduleForm = new ModifyScheduleForm();
            modifyScheduleForm.ShowDialog();
            UpdateDisplayTodaySchedules(panelMonth1.Datetime);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPaint();
            panelMonth1.PMEvent += new EventHandler(panelMonth1_ValueChanged);//注册自定义控件


        }
        //自定义控件回调函数
        private void panelMonth1_ValueChanged(object sender, EventArgs e) {
            UpdateDisplayTodaySchedules(panelMonth1.Datetime);//更新日历
            if (panelMonth1.Datetime.Date == DateTime.Now.Date) {
                LtodaySchedules.Text = "今日日程";
            }
            else {
                LtodaySchedules.Text = panelMonth1.Datetime.ToString("yyyy年M月d日", DateTimeFormatInfo.InvariantInfo)
                + "的日程";
            }
        }



        //时钟显示
        private void LoadPaint()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            MyClock.m_timer = new Timer();
            MyClock.m_timer.Interval = 1000;
            MyClock.m_timer.Enabled = true;
            MyClock.m_timer.Tick += new EventHandler(timer1_Tick);

            MyClock.m_width = this.ClientSize.Width;
            MyClock.m_height = this.ClientSize.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            MyClock.OnPaint(e, paintTime);

        }

        private void clbTodaySchedules_SelectedIndexChanged(object sender, EventArgs e) {
            int index = clbTodaySchedules.SelectedIndex;
            
            if (index >= 0) {
                MyClock.flag = true;
                paintTime = scheduleService.todaySchedules[index].Time;
            }
            else {
                MyClock.flag = false;
            }
        }

        private void clbTodaySchedules_MouseLeave(object sender, EventArgs e) {
            clbTodaySchedules.SelectedIndex = -1;
        }

        //最小化按钮
        private void buttonMinimum_Click(object sender, EventArgs e)
        {
            mForm.Visible = true;
            this.Visible = false;
        }

        //15s检测一次是否需要提醒
        private void remindTimer_Tick(object sender, EventArgs e) {
            scheduleService.CheckRemind();
            if (scheduleService.remindSchedules.Count != 0) {
                string detail = scheduleService.remindSchedules[0].Details;
                scheduleService.remindSchedules.Clear();//全部删除

                //最小化时气球提示
                if (!this.Visible && !mForm.Visible) {
                    bgmusic.SetRemindMusic();
                    notifyIcon1.ShowBalloonTip(3000, "日程到点啦！", detail + "!!", ToolTipIcon.Info);
                }
                else {
                    //非最小化弹窗
                    bgmusic.SetMusic1();
                    MessageBox.Show(detail + "!!");
                    bgmusic.SetPause();
                }
            }
        }

        //最小化到系统托盘
        private void MainForm_SizeChanged(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.Visible = false;
                winFlag = true;
            }
        }
        //恢复大窗口
        private void notifyIcon1_DoubleClick(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized || !this.Visible || !mForm.Visible) {
                if (winFlag) {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                }
                else {
                    mForm.Show();
                }
                
            }

        }

        private void notifyIcon1_Click(object sender, EventArgs e) {
            if (this.Visible == true) {
                winFlag = true;
                this.Visible = false;//大窗口消失

            }
            else if (mForm.Visible == true) {
                winFlag = false;
                mForm.Visible = false;//小窗口消失
            }
        }
    }
}
