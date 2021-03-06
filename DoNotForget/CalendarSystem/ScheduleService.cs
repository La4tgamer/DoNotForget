﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace CalendarSystem {
    public  class ScheduleService {
        /*日程管理类
         * 储存所有的日程（当日未完成，已完成）
         * 添加新日程
         * 修改日程
         * 删除日程
         * 日程到点提醒
         * 保存数据
         * 读取存档
         * 
         */
        public List<Schedule> allSchedules;//使用List储存所有的schedule
        public List<Schedule> todaySchedules;//当天的日程，日历选中的当前天
        public List<Schedule> finishedSchedules;//当天已完成的日程
        public List<Schedule> remindSchedules;//用来提醒的日程
        public List<Schedule> nowSchedule;//今天的日程，

        int Count { set; get; }//记录有多少个日程

        public ScheduleService() {
            allSchedules = new List<Schedule>();
            todaySchedules = GetTodaySchedule();
            finishedSchedules = new List<Schedule>();
            remindSchedules = new List<Schedule>();
            nowSchedule = GetTodaySchedule();//打开程序的时候初始化一次，在添加删除之后再一次
        }
        public ScheduleService(string path) {
            allSchedules = new List<Schedule>();
            if (!LoadData(path)) {
                Console.WriteLine("加载数据失败");
            }
            todaySchedules = GetTodaySchedule();
            finishedSchedules = new List<Schedule>();
        }
        //更新当日日程
        public void UpdateTodaySchedule(DateTime dateTime) {
            todaySchedules = GetSomeDaySchedule(dateTime);
            nowSchedule = GetTodaySchedule();//更新今天的日程
            //UpdateFinishedSchedules();//将当日已完成的日程移动到完成的list中去
        }
        //将今天的日程已完成的移动到已完成list
        public bool UpdateFinishedSchedules() {
            //将today中移动到已完成
            for (int i = 0; i < todaySchedules.Count; i++) {
                if (todaySchedules[i].isFinished) {
                    finishedSchedules.Add(todaySchedules[i]);
                }
            }
            //删除today中的日程
            foreach (var schedule in finishedSchedules) {
                todaySchedules.Remove(schedule);
            }
            return true;
        }

        //添加日程
        public bool AddSchedule(Schedule schedule) {
            allSchedules.Add(schedule);
            return true;
        }
        //修改日程
        public bool ModifySchedule(int index, Schedule schedule) {
            if (index < 0)
            {
                return false;
            }
            allSchedules[index] = schedule;
            return true;
        }
        //删除日程
        public bool DeleteSchedule(int index) {
            allSchedules.RemoveAt(index);
            return true;
        }
        public bool DeleteSchedule(Schedule schedule) {
            allSchedules.Remove(schedule);
            return true;
        }
        //检查是否有需要提醒的日程
        public bool CheckRemind() {
            DateTime nowTime = DateTime.Now;//当前时间
            //在今天的日程中寻找需要提醒的事项
            foreach (Schedule schedule in nowSchedule) {
                if (!schedule.isOutDate) {//寻找未过时事件
                    //当前时间晚于提醒时间时提醒
                    if (schedule.Time < nowTime) {
                        schedule.Remind();
                        remindSchedules.Add(schedule);//加入需要提醒list
                    }
                }
                
            }
            return true;
        }
        //得到当天的日程list
        public List<Schedule> GetTodaySchedule() {
            DateTime nowTime = DateTime.Now;//当前时间
            List<Schedule> todaySchedule = new List<Schedule>();//当日的list
            //在当天的日程中寻找需要提醒的事项
            foreach (Schedule schedule in allSchedules) {
                if (schedule.Cycle.Equals("once")) {
                    //提醒一次的
                    //年月日都符合的挑选出来
                    if (DateTime.Compare(schedule.Time.Date, nowTime.Date) == 0) {
                        todaySchedule.Add(schedule);
                    }
                }
                else if (schedule.Cycle.Equals("daily")) {
                    //每天提醒的,不在未来的作为一个新的加入
                    if (DateTime.Compare(schedule.Time.Date, nowTime.Date) <= 0) {
                        Schedule newSchedule = new Schedule(
                        new DateTime(nowTime.Year, nowTime.Month,
                        nowTime.Day, schedule.Time.Hour, schedule.Time.Minute, schedule.Time.Second),
                        "once", schedule.Details, schedule.MusicIndex);
                        todaySchedule.Add(newSchedule);
                    }
                }
                else if (schedule.Cycle.Equals("weekly")) {
                    //每周提醒的,不在未来的判断星期是否一样
                    if (DateTime.Compare(schedule.Time.Date, nowTime.Date) <= 0) {
                        if (schedule.Time.DayOfWeek == nowTime.DayOfWeek) {
                            Schedule newSchedule = new Schedule(
                            new DateTime(nowTime.Year, nowTime.Month,
                            nowTime.Day, schedule.Time.Hour, schedule.Time.Minute, schedule.Time.Second),
                            "once", schedule.Details, schedule.MusicIndex);
                            todaySchedule.Add(newSchedule);
                        }
                    }
                }

            }

            return todaySchedule;
        }
        //得到某天的日程list
        public List<Schedule> GetSomeDaySchedule(DateTime dateTime) {
            DateTime nowTime = dateTime;//这一天的时间
            List<Schedule> todaySchedule = new List<Schedule>();//当日的list
            //在当天的日程中寻找需要提醒的事项
            foreach (Schedule schedule in allSchedules) {
                if (schedule.Cycle.Equals("once")) {
                    //提醒一次的
                    //年月日都符合的挑选出来
                    if (DateTime.Compare(schedule.Time.Date, nowTime.Date) == 0) {
                        todaySchedule.Add(schedule);
                    }
                }
                else if (schedule.Cycle.Equals("daily")) {
                    //每天提醒的,不在未来的作为一个新的加入
                    if (DateTime.Compare(schedule.Time.Date, nowTime.Date) <= 0) {
                        Schedule newSchedule = new Schedule(
                        new DateTime(nowTime.Year, nowTime.Month,
                        nowTime.Day, schedule.Time.Hour, schedule.Time.Minute, schedule.Time.Second),
                        "once", schedule.Details, schedule.MusicIndex);
                        todaySchedule.Add(newSchedule);
                    }
                }
                else if (schedule.Cycle.Equals("weekly")) {
                    //每周提醒的,不在未来的判断星期是否一样
                    if (DateTime.Compare(schedule.Time.Date, nowTime.Date) <= 0) {
                        if (schedule.Time.DayOfWeek == nowTime.DayOfWeek) {
                            Schedule newSchedule = new Schedule(
                            new DateTime(nowTime.Year, nowTime.Month,
                            nowTime.Day, schedule.Time.Hour, schedule.Time.Minute, schedule.Time.Second),
                            "once", schedule.Details, schedule.MusicIndex);
                            todaySchedule.Add(newSchedule);
                        }
                    }
                }

            }

            return todaySchedule;
        }

        //保存数据
        public bool SaveData(string path) {
            try {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write)) {
                    XmlSerializer xml = new XmlSerializer(allSchedules.GetType());
                    xml.Serialize(fs, allSchedules);
                }
            }
            catch {
                return false;
            }
            return true;
            
        }
        //读取保存的数据
        public bool LoadData(string path) {
            try {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read)) {
                    XmlSerializer xml = new XmlSerializer(allSchedules.GetType());
                    allSchedules = (List<Schedule>)xml.Deserialize(fs);
                }
            }
            catch {
                return false;
            }
            return true;
        }
    }
}
