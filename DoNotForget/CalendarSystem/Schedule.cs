using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem {
    public class Schedule {
        /* 提醒时间
         * 提醒内容(提醒事项的主体)
         * 具体的提醒方式
         * 提醒周期
         * 完成情况
         * 是否过期（时间上）
         * 周期决定年月日，暂时忽略掉每周提醒的问题
         */
        public DateTime Time { set; get; }//提醒的时间
        private string cycle;//周期
        public string Cycle {
            set {
                switch (value) {
                    case "once":
                        cycle = "once";
                        break;
                    case "daily":
                        cycle = "daily";
                        break;
                    case "weekly":
                        cycle = "weekly";
                        break;
                    default:
                        cycle = "once";//默认once
                        break;
                }
            }
            get {
                return cycle;
            }
        }//提醒周期
        public string Details { set; get; }//提醒内容
        public bool isOutDate;//是否过时，过时未完成显示红色（提醒之后）
        public bool isFinished;//是否完成,构造函数中设置未完成。
        //构造函数
        public Schedule() {
            Time = DateTime.Now + TimeSpan.FromMinutes(5);//默认在五分钟之后提醒
            Cycle = "once";
            Details = "这个人有点懒";
            isOutDate = false;//默认未过时
            isFinished = false;//默认未完成
        }
        //带参数的构造函数
        public Schedule(DateTime time, string cycle, string details) {
            Time = time;
            Cycle = cycle;
            Details = details;
            isFinished = false;
        }

        //提醒
        public void Remind() {
            OutDate();//设置为已提醒
            Console.WriteLine("time out");
        }

        //完成
        public void Finish() {
            isFinished = true;
        }
        //过期
        public void OutDate() {
            isOutDate = true;
        }
        //重写tostring格式为 XXX 2018年12月5日13时15分
        public override string ToString() {
            return Details + "\t" + Time.ToString("yyyy年M月d日H时mm分", DateTimeFormatInfo.InvariantInfo);
        }
    }
}
