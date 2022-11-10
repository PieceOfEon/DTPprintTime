using System;

using System.Windows.Forms;

namespace DTPprintTime
{
    
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dayT = new DateTime();
            dayT = dateTimePicker1.Value;
            DateTime dayNow = DateTime.Now;
            
            if (dayT > dayNow)
            {
                TimeSpan tempDay = dayT - dayNow;
                if (radioButton1.Checked == true)
                {
                    label1.Text = "";
                    label1.Text = "Лет прошло " + Convert.ToString(tempDay.TotalDays / 365);
                }
                if (radioButton2.Checked == true)
                {
                    label1.Text = "";
                    label1.Text = "Месяцев прошло " + Convert.ToString(tempDay.TotalDays/30);
                }
                if (radioButton3.Checked == true)
                {
                    label1.Text = "";
                    label1.Text = "Дней прошло " + Convert.ToString(tempDay.TotalDays);
                }
                if (radioButton4.Checked == true)
                {
                    label1.Text = "";
                    label1.Text = "Минут прошло " + Convert.ToString(tempDay.TotalMinutes);
                }
                if (radioButton5.Checked == true)
                {
                    label1.Text = "";
                    label1.Text = "Секунд прошло " + Convert.ToString(tempDay.TotalSeconds);
                }
            }
            else
            {
                label1.Text = "";
                label1.Text = "Дата не может быть меньше текущей";
            }

        }
    }
}
