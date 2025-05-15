using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Dat_Lich
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            
            f2.d += new Form2.Mydel(addApp);
            f2.d2 += new Form2.Mydel2(loadDataGridView);
            f2.Show();

        }
        private void addApp(Appointment app)
        {
            CSDL.Instance.addAppointment(app);
        }


        private void loadDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Appointment app in CSDL.Instance.user.appointments)
            {
                string reminder;
                if (app.Reminder == null)
                {
                    reminder = "No reminder";
                }else
                {
                       reminder = app.Reminder.hour + ":" + app.Reminder.minute;
                }
                dataGridView1.Rows.Add(app.Name, app.Location,app.Day, app.StartTime.hour + ":" + app.StartTime.minute, app.EndTime.hour + ":" + app.EndTime.minute, reminder);
            }
        }   

    }
}
