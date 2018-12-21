using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarSystem;

namespace Interface
{
    public partial class MinimumForm : Form
    {
        MainForm mainForm;

        public MinimumForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            UpdateDisplayTodaySchedules(DateTime.Now);
        }
        //实现便签拖拽
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        //刷新显示的今日日程
        private void UpdateDisplayTodaySchedules(DateTime dateTime)
        {
            listBox1.Items.Clear();      //首先清空所有日程
            MainForm.scheduleService.UpdateTodaySchedule(dateTime);
            foreach (Schedule schedule in MainForm.scheduleService.todaySchedules)
            {
                listBox1.Items.Add(schedule.ToStringShort());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //查看所有日程按钮
        private void buttonAll_Click(object sender, EventArgs e)
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
            foreach (Schedule schedule in MainForm.scheduleService.allSchedules)
            {
                listBox.Items.Add(schedule.ToStringAll());
            }
            form.Controls.Add(listBox);
            form.ShowDialog();
        }
        //添加日程按钮
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddScheduleForm addScheduleForm = new AddScheduleForm();
            addScheduleForm.ShowDialog();
            UpdateDisplayTodaySchedules(DateTime.Now);
        }
        //修改日程按钮
        private void buttonModify_Click(object sender, EventArgs e)
        {
            ModifyScheduleForm modifyScheduleForm = new ModifyScheduleForm();
            modifyScheduleForm.ShowDialog();
            UpdateDisplayTodaySchedules(DateTime.Now);
        }
        //删除日程按钮
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteScheduleForm deleteScheduleForm = new DeleteScheduleForm();
            deleteScheduleForm.ShowDialog();
            UpdateDisplayTodaySchedules(DateTime.Now);
        }
        //便签最大化为应用
        private void buttonMaximum_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Visible = false;
        }
        //实现便签拖拽
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //可见性变化是刷新
        private void MinimumForm_VisibleChanged(object sender, EventArgs e) {
            UpdateDisplayTodaySchedules(DateTime.Now);
        }
    }
}
