using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Dat_Lich.Model
{
    public class Reminder
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public string text { get; set; }
        public Reminder(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
            this.text = "Start in 1 minute";
        }
    }
}
