using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalendarSystem
{
    public class LunarCalendar
    {
        private static ChineseLunisolarCalendar ChineseCalendar = new ChineseLunisolarCalendar();

        private static string[] tianGan = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };
        private static string[] diZhi = { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };
        private static string[] shengXiao = { "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊", "猴", "鸡", "狗", "猪" };
        private static string[] months = { "正", "二", "三", "四", "五", "六", "七", "八", "九", "十", "冬", "腊" };
        private static string[] days1 = { "初", "十", "廿", "三" };
        private static string[] days2 = { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十" };
        
        //天干地支计算
        public static string GetLunarYear(int year)
        {
            if(year > 3)
            {
                int tianGanIndex = (year - 4) % 10;
                int diZhiIndex = (year - 4) % 12;
                return string.Concat(tianGan[tianGanIndex], diZhi[diZhiIndex]);
            }

            throw new ArgumentOutOfRangeException("无效的年份");
        }

        //农历月份计算
        public static string GetLunarMonth(int month)
        {
            if(month < 13 && month > 0)
            {
                return months[month - 1];
            }
            throw new ArgumentOutOfRangeException("无效的月份!");
        }

        //农历日计算
        public static string GetLunarDay(int day)
        {
            if(day > 0 && day <32)
            {
                if (day != 20 && day != 30)
                    return string.Concat(days1[(day - 1) / 10], days2[1]);
            }
            throw new ArgumentOutOfRangeException("无效的日!");
        }

        public static string GetChineseDateTime(DateTime datetime)
        {
            int year = ChineseCalendar.GetYear(datetime);
            int month = ChineseCalendar.GetMonth(datetime);
            int day = ChineseCalendar.GetDayOfMonth(datetime);
            //获取闰月， 0 则表示没有闰月
            int leapMonth = ChineseCalendar.GetLeapMonth(year);

            bool isleap = false;

            if (leapMonth > 0)
            {
                if (leapMonth == month)
                {
                    //闰月
                    isleap = true;
                    month--;
                }
                else if (month > leapMonth)
                {
                    month--;
                }
            }

            return string.Concat(GetLunarYear(year), "年", isleap ? "闰" : string.Empty, GetLunarMonth(month), "月", GetLunarDay(day));
        }
    }
}
