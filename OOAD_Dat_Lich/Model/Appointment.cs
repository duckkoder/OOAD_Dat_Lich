using OOAD_Dat_Lich.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Dat_Lich
{
    public class Appointment
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Day { get; set; }
        public startTime StartTime { get; set; }
        public endTime EndTime { get; set; }
        public bool isReminder { get; set; }
        public Reminder Reminder { get; set; }
        public Appointment(string name, string location, DateTime Day, startTime Stime, endTime Etime, Reminder reminder)
        {
            this.Name = name;
            this.Location = location;
            this.Day = Day;
            this.StartTime = Stime;
            this.EndTime = Etime;
            this.Reminder = reminder;
        }

        public static bool operator ==(Appointment left, Appointment right) {

            return (left.Name == right.Name && left.Location == right.Location && left.Day == right.Day);
        
        }

        public static bool operator !=(Appointment left, Appointment right)
        {
            return (left.Name != right.Name || left.Location == right.Location || left.Day != right.Day);
        }
        
    }
}
