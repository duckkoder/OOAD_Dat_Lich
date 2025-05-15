using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Dat_Lich
{
    public class CSDL
    {
        private User _user;
        private static CSDL _Instance;
        public User user
        {
            get { return _user; }
            private set { }
        }
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDL();
                return _Instance;
            }
            private set { }
        }
        private CSDL()
        {
            _user = new User();
        }
        public void addAppointment(Appointment appointment)
        {
            bool check = false;
            for (int i = 0; i < _user.appointments.Count; i++)
            {
                if (appointment== _user.appointments[i])
                {
                    MessageBox.Show(appointment.Day.ToString());
                    _user.appointments[i].StartTime = appointment.StartTime;
                    _user.appointments[i].EndTime = appointment.EndTime;
                    _user.appointments[i].Reminder = appointment.Reminder;
                    check = true;
                    break;
                }
            }
            if (!check) _user.appointments.Add(appointment);
        }
    }
}
