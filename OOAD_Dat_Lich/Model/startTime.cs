using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Dat_Lich.Model
{
    public class startTime
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public startTime(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }
    }
}
