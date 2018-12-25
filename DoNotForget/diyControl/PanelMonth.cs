using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyControl
{
    public partial class PanelMonth : UserControl
    {
        public event EventHandler PMEvent;
        public PanelMonth()
        {
            InitializeComponent();
            DisplayPD(datetime);
        }

        private DateTime datetime = System.DateTime.Now;

        public DateTime Datetime
        {
            get { return datetime; }
            set
            {
                datetime = value;
                dateTimePicker.Value = datetime;
            }
        }

        public void Add(PanelDay pd, int x, int y)
        {
            pd.Location = new System.Drawing.Point(x * 70, y * 92);
            panelWall.Controls.Add(pd);
        }

        public void Add(PanelDay pd)
        {
            panelWall.Controls.Add(pd);
        }

        public void DisplayPD(DateTime datetime)
        {
            panelWall.Controls.Clear();
            DateTimeDS dt = new DateTimeDS();
            int dim = dt.daysInMonth(dateTimePicker.Value.Year, dateTimePicker.Value.Month);
            PanelDay[] panelday = new PanelDay[dim];
            for (int d = 0; d < dim; d++)
            {
                panelday[d] = new PanelDay();
                panelday[d].Name = "pd" + (d + 1).ToString();
                panelday[d].Solar = MyString(d + 1);
                panelday[d].Lunar = dt.getLunarDay(dateTimePicker.Value.Year, dateTimePicker.Value.Month, d + 1);
                panelday[d].MouseEnter += new EventHandler(PanelMonth_MouseEnter);
                panelday[d].MouseLeave += new EventHandler(PanelMonth_MouseLeave);
                panelday[d].MouseClick += PanelMonth_MouseClick;
                panelday[d].Terms = dt.terms(new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, d + 1));
                if (DateTime.Now.Day == d + 1 && datetime.Year == DateTime.Now.Year&& datetime.Month == DateTime.Now.Month)
                    panelday[d].BackColor = Color.FromArgb(252, 157, 154);
                if (datetime.Day == d + 1)
                {
                    panelday[d].BackColor = Color.FromArgb(101, 147, 74);
                }

            }
            int index = 0;
            DateTime newtime = dateTimePicker.Value;
            DateTime firstdaytime = new DateTime(newtime.Year, newtime.Month, 1);
            int firstday = (int)firstdaytime.DayOfWeek;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    if (i == 0 && j < firstday) { }
                    else if (index < dim)
                    {
                        Add(panelday[index], j, i);
                        index++;
                    }

                }
            }
        }

        private void PanelMonth_MouseClick(object sender, EventArgs e)
        {
            
            PanelDay pd = (PanelDay)sender;
            pd.BackColor = Color.FromArgb(101, 147, 74);
            datetime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, Convert.ToInt32(pd.Solar));
            dateTimePicker.Value = datetime;
            DisplayPD(datetime);

            //PMEvent?.Invoke(this, e);
        }

        private void PanelMonth_MouseEnter(object sender, EventArgs e)
        {
            PanelDay pd = (PanelDay)sender;
            if (DateTime.Now.Day == pd.date() && datetime.Year == DateTime.Now.Year && datetime.Month == DateTime.Now.Month)
                pd.BackColor = Color.FromArgb(252, 157, 154);
            else if (dateTimePicker.Value.Year != datetime.Year || dateTimePicker.Value.Month != datetime.Month || dateTimePicker.Value.Day != Convert.ToInt32(pd.Solar))
            {
                pd.BackColor = Color.FromArgb(131, 175, 155);
            }
        }

        private void PanelMonth_MouseLeave(object sender, EventArgs e)
        {
            PanelDay pd = (PanelDay)sender;
            if (DateTime.Now.Day == pd.date() && datetime.Year == DateTime.Now.Year && datetime.Month == DateTime.Now.Month)
                pd.BackColor = Color.FromArgb(252,157,154);
            else if (dateTimePicker.Value.Year != datetime.Year || dateTimePicker.Value.Month != datetime.Month || dateTimePicker.Value.Day != Convert.ToInt32(pd.Solar))
            {
                pd.BackColor = this.BackColor;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            datetime = dateTimePicker.Value;
            DisplayPD(datetime);
            PMEvent?.Invoke(this, e);
        }

        private void Leftbtn_Click(object sender, EventArgs e)
        {
            int year = dateTimePicker.Value.Year;//当前年  
            int month = dateTimePicker.Value.Month;//当前月  

            int beforeYear = 0;
            int beforeMonth = 0;
            if (month <= 1)//如果当前月是一月，那么年份就要减一 
            {
                beforeYear = year - 1;
                beforeMonth = 12;//上个月  
            }
            else
            {
                beforeYear = year;
                beforeMonth = month - 1;//上个月  
            }
            datetime = new DateTime(beforeYear, beforeMonth, 1);
            dateTimePicker.Value = datetime;
            DisplayPD(datetime);
        }

        private void Rightbtn_Click(object sender, EventArgs e)
        {
            int year = dateTimePicker.Value.Year;//当前年  
            int month = dateTimePicker.Value.Month;//当前月  

            int afterYear = 0;
            int afterMonth = 0;
            if (month >= 12)//如果当前月是十二月，那么年份就要加一
            {
                afterYear = year + 1;
                afterMonth = 1;//下个月  
            }
            else
            {
                afterYear = year;
                afterMonth = month + 1;//下个月  
            }
            datetime = new DateTime(afterYear, afterMonth, 1);
            dateTimePicker.Value = datetime;
            DisplayPD(datetime);
        }

        private void Today_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            datetime = DateTime.Now;
            dateTimePicker.Value = datetime;
            DisplayPD(datetime);
        }

        private string MyString(int i)
        {
            if (i <= 9 && i > 0)
                return " " + i;
            else
                return i.ToString();
        }
    }
}
