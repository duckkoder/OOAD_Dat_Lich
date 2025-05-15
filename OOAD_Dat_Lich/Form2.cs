using OOAD_Dat_Lich.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Dat_Lich
{
    public partial class Form2 : Form
    {
        public delegate void Mydel(Appointment app);
        public delegate void Mydel2();

        public Mydel d { get; set; }
        public Mydel2 d2 { get; set; }
        public DateTime day { get; set; }
        public int hourStart { get; set; }
        public int minuteStart { get; set; }
        public Form2()
        {
            InitializeComponent();
            
        }
        private void LoadTimeStart()
        {
            numericUpDown1.Value = hourStart;
            numericUpDown2.Value = minuteStart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            day = dateTimePicker1.Value.Date;
            string name = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên cuộc hẹn không được để trống.");
                return;
            }

            string location = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Địa điểm cuộc hẹn không được để trống.");
                return;
            }
            startTime Stime = new startTime((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            endTime Etime = new endTime((int)numericUpDown3.Value, (int)numericUpDown4.Value);

            if (Etime.hour < Stime.hour || (Etime.hour == Stime.hour && Etime.minute <= Stime.minute))
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.");
                return;
            }

            Reminder reminder = null;
            if (yesRatioBtn.Checked)
            {
                reminder = new Reminder(Stime.hour, Stime.minute);
            }

            Appointment newApp = new Appointment(name, location, day, Stime, Etime, reminder);




            d?.Invoke(newApp);  // Gửi cuộc hẹn về form cha
            d2?.Invoke();        // Thông báo cập nhật UI (nếu có)
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
