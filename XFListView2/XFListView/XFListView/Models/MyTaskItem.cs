using System;
using System.Collections.Generic;
using System.Text;

namespace XFListView.Models
{
    public class MyTaskItem :ICloneable
    {
        //工作名稱
        public string MyTaskName { get; set; }
        //狀態
        public string MyTaskStatus { get; set; }
        //指派日期
        public DateTime MyTaskDate { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
