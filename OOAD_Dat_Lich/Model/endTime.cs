using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Dat_Lich.Model
{
    public class endTime
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public endTime(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }
    }
}
