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

namespace Interface
{
    public partial class AddScheduleForm : Form
    {
        private delegate void settime();
        public AddScheduleForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;  //设置弹出窗口居中
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }
        //动态显示系统时间
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SetTime();
        }
        private void SetTime()
        {
            if (LShowNowTime.InvokeRequired)
            {
                settime settime = new settime(SetTime);
                this.BeginInvoke(settime);
            }
            else
            {
                LShowNowTime.Text = DateTime.Now.ToString();
            }
        }
       //单击确认添加新日程按钮的响应事件
        private void btnYes_Click(object sender, EventArgs e)
        {
            string cycle = "";
            string details = "";
            foreach (RadioButton val in gbSetRemindCycle.Controls)
            { 
                if (val.Checked)
                {
                    cycle = val.Text;
                } 
            }
            for(int i = 0;i<rtbDetails.Lines.Count();i++)
            {
                details += rtbDetails.Lines[i];
            }
            Schedule schedule = new Schedule(dtpSetRemindTime.Value, cycle, details);
            MainForm.scheduleService.AddSchedule(schedule);
            Dispose();
            MessageBox.Show("日程添加成功");
        }
        //单击取消按钮按钮的响应事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
            MessageBox.Show("已取消添加"); 
        }


        private void rbOnce_CheckedChanged(object sender, EventArgs e){}
        private void LSetRemindTime_Click(object sender, EventArgs e){}
    }
}