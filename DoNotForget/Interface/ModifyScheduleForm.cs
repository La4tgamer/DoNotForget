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

namespace Interface
{
    public partial class ModifyScheduleForm : Form
    {
        private delegate void settime();
        public ModifyScheduleForm()
        {
            InitializeComponent();
            //将所有日程显示在弹出界面的 ListBox 中
            foreach (Schedule schedule in MainForm.scheduleService.allSchedules)
            {
                lbAllSchedules.Items.Add(schedule.ToString());
            }
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
        private void btnModify_Click(object sender, EventArgs e)
        {
            int index = lbAllSchedules.SelectedIndex;
        }

        private void btnRemindCycle_Click(object sender, EventArgs e){}
    }
}
