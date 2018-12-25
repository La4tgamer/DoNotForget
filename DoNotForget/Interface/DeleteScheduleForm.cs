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
    public partial class DeleteScheduleForm : Form
    {
        public DeleteScheduleForm()
        {
            StartPosition = FormStartPosition.CenterParent;  //设置弹出窗口居中
            InitializeComponent();
            UpdateDisplayAllSchedules();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //for (int i = clbAllSchedules.Items.Count - 1; i >= 0; i--)    //从后往前遍历,删除所有打勾的日程
            //{  
            //    if (clbAllSchedules.GetItemChecked(i))
            //    {
            //        MainForm.scheduleService.DeleteSchedule(i);              //将打勾的日程从所有日程中删除
            //        clbAllSchedules.Items.Remove(clbAllSchedules.Items[i]);
            //    }
            //}
            List<Schedule> schedules = new List<Schedule>();//暂存引用变量
            for (int i = 0; i < clbAllSchedules.Items.Count; i++)    
            {
                if (clbAllSchedules.GetItemChecked(i)) {//将打勾的日程暂时存在list中
                    schedules.Add(MainForm.scheduleService.allSchedules[i]);
                }
            }
            foreach (var schedule in schedules) {//遍历删除
                MainForm.scheduleService.DeleteSchedule(schedule);
            }
            UpdateDisplayAllSchedules();
        }
        //取消全选的按钮响应事件
        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbAllSchedules.Items.Count; i++)
            {
                clbAllSchedules.SetItemChecked(i,false);  
            }
            
        }
        //全选的按钮响应事件
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbAllSchedules.Items.Count; i++)
            {
               clbAllSchedules.SetItemChecked(i, true);
            }
        }
        //更新
        private void UpdateDisplayAllSchedules() {
            clbAllSchedules.Items.Clear();
            foreach (Schedule schedule in MainForm.scheduleService.allSchedules) {
                clbAllSchedules.Items.Add(schedule.ToStringAll());
            }
        }

        private void clbAllSchedules_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (clbAllSchedules.SelectedIndex < 0)
                {
                    return;
                }
                if (clbAllSchedules.SelectedIndices.Count > 0)
                {
                    toolTip1.Active = true;
                    toolTip1.SetToolTip(clbAllSchedules, clbAllSchedules.Items[clbAllSchedules.SelectedIndex].ToString());
                }
                else
                {
                    toolTip1.Active = false;
                }  
        }
    }
}
