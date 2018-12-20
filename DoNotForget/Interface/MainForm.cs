using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarSystem;

namespace Interface {
    public partial class MainForm : Form {
        public static ScheduleService scheduleService = new ScheduleService();   //日程管理
        //刷新显示的今日日程
        private  void UpdateDisplayTodaySchedules()
        {
            clbTodaySchedules.Items.Clear();      //首先清空所有日程
            scheduleService.UpdateTodaySchedule();
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
            UpdateDisplayTodaySchedules();
        }
        //添加日程的按钮响应时间
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddScheduleForm addScheduleForm = new AddScheduleForm();
            addScheduleForm.ShowDialog();
            UpdateDisplayTodaySchedules();
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
            UpdateDisplayTodaySchedules();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyScheduleForm modifyScheduleForm = new ModifyScheduleForm();
            modifyScheduleForm.ShowDialog();
            UpdateDisplayTodaySchedules();
        }
    }
}
