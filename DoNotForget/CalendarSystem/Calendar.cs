using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem
{
    class Calendar
    {
        public int month { get; set; }
        public int year { get; set; }
        public int firstday;
        public int days;

        public Calendar(int year, int month)
        {
            this.year = year;
            this.month = month;
            firstday = GetWeeksOfDate(year, month, 1); //这个月的第一天星期几
            days = GetDaysOfMonth(year, month); //获取想要输出月份的天数
        }



        //计算星期几: 星期日至星期六的值为0-6
        public static int GetWeeksOfDate(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            DayOfWeek dow = dt.DayOfWeek;
            return Convert.ToInt32(dow);
        }

        //获取指定年月的天数
        public static int GetDaysOfMonth(int year, int month)
        {
            DateTime dt = new DateTime(year, month, 1);
            int days = dt.AddMonths(1).AddDays(-1).Day;
            return days;
        }
    }
}
