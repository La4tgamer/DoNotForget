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
                lbAllSchedules.Items.Add(schedule.ToStringAll());
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
            string cycle = "";
            string details = "";
            foreach (RadioButton val in gbModifyCycle.Controls) {
                //判断选中哪个单选框然后赋值cycle
                if (val.Checked) {
                    if (val.Text == "定时提醒一次") {
                        cycle = "once";
                    }
                    else if (val.Text == "每日提醒") {
                        cycle = "daily";
                    }
                    else if (val.Text == "每周提醒") {
                        cycle = "weekly";
                    }
                }
            }
            for (int i = 0; i < rtbModifyDetails.Lines.Count(); i++) {
                details += rtbModifyDetails.Lines[i];
            }
            Schedule schedule = new Schedule(dtpModifyRemindTime.Value, cycle, details, cbModifyRemindMusic.SelectedIndex);
            if (MainForm.scheduleService.ModifySchedule(lbAllSchedules.SelectedIndex, schedule))
            {
                MessageBox.Show("日程修改成功");
            }
            else
            {
                MessageBox.Show("未选择要修改的日程");
            }
            Dispose();
        }

        private void btnRemindCycle_Click(object sender, EventArgs e){}

        private void lbAllSchedules_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbAllSchedules.SelectedIndex;
            if(index >= 0)
            {
                //选中的提醒周期
                if (MainForm.scheduleService.allSchedules[index].Cycle == "once")
                {
                    rbOnce.Select();
                }
                else if (MainForm.scheduleService.allSchedules[index].Cycle == "daily")
                {
                    rbDaily.Select();
                }
                else if (MainForm.scheduleService.allSchedules[index].Cycle == "weekly")
                {
                    rbWeekly.Select();
                }
                //选中的内容
                rtbModifyDetails.Text = MainForm.scheduleService.allSchedules[index].Details;
                //选中的时间
                dtpModifyRemindTime.Value = MainForm.scheduleService.allSchedules[index].Time;
                //选中日程的提醒铃声
                cbModifyRemindMusic.SelectedIndex = MainForm.scheduleService.allSchedules[index].MusicIndex;
            }
            else  
            {
                return;
            }
        }
        private void ModifyScheduleForm_Load(object sender, EventArgs e){}
    }
}
