using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalendarSystem
{
    public class Weather
    {


        public static string GetWeather()
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString("http://www.weather.com.cn/weather1d/101200101.shtml");
            string weather = Check(html);
            return weather;
        }

        public static string Check(string s)
        {
            //< !--一起观天气-- >\r\n\t\t\t\t\t < !--$forecastList-- >\r\n < !--$forecast_15d_24h_internal-- >\r\n < input type =\"hidden\" id=\"hidden_title\" value=\"12月25日20时 周二  小雨  5/7°C\" />\r\n
            string weather;
            Regex regex = new Regex("<!--一起观天气-->.*\n.*\n.*\n.*value=\".*\" />");
            Match a = regex.Match(s);
            Regex regex2 = new Regex("value=\".*\"");
            Match b = regex2.Match(a.Value);
            weather = b.Value;
            weather = weather.Remove(0, weather.IndexOf('周') + 4);
            weather = weather.Remove(weather.IndexOf('"'), 1);
            weather = weather.Replace("  ", "\n");
            return weather;
        }

    }
    
}
