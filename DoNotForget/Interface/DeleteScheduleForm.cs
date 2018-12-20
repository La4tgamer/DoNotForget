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
            InitializeComponent();
            foreach (Schedule schedule in MainForm.scheduleService.allSchedules)
            {
                clbAllSchedules.Items.Add(schedule.ToString());
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            for (int i = clbAllSchedules.Items.Count - 1; i >= 0; i--)    //从后往前遍历,删除所有打勾的日程
            {  
                if (clbAllSchedules.GetItemChecked(i))
                {
                    MainForm.scheduleService.DeleteSchedule(i);              //将打勾的日程从所有日程中删除
                    clbAllSchedules.Items.Remove(clbAllSchedules.Items[i]);
                }
            }
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
    }
}
