using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Dat_Lich
{
    public class User
    {
        public List<Appointment> appointments { get; set; }

        public User()
        {
            appointments = new List<Appointment>();
        }

        public Boolean checkAppointment(Appointment appointment)
        {
            for(int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i] == appointment)
                {
                       
                }
            }
        }
    }
}
