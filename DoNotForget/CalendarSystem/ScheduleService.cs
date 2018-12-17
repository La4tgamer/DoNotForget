using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem {
    class ScheduleService {
        /*日程管理类
         * 储存所有的日程
         * 添加新日程
         * 修改日程
         * 删除日程
         * 日程到点提醒
         * 保存数据
         * 读取存档
         * 
         */
        List<Schedule> schedules;//使用List储存所有的schedule
        int Count { set; get; }//记录有多少个日程


        public bool AddSchedule() {
            return true;
        }

        public bool ModifySchedule() {
            return true;
        }

        public bool DeleteSchedule(int index) {
            return true;
        }
        public bool DeleteSchedule(Schedule schedule) {
            return true;
        }

        public bool Remind() {

            return true;
        }

        public bool SaveData(string path) {
            return true;
        }

        public bool LoadData(string path) {
            return true;
        }
    }
}
