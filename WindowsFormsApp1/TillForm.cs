using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class TillForm : Form
    {
        System.Timers.Timer timer;
        int hours, minutes, seconds;
        public TillForm()
        {
            InitializeComponent();
        }

        private void TillForm_Load(object sender,EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                seconds += 1;
                if (seconds == 60)
                {
                    seconds = 0;
                    minutes += 1;
                }
                if (minutes == 60)
                {
                    minutes = 0;
                    hours += 1;
                }
                TimerBox.Text = string.Format("{0}:{1}:{2}", hours.ToString().PadLeft(2, '0'), minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
            }
            ));
        }

        
        private void Open_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void TillForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

    }
}
