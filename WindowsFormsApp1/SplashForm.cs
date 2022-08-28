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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            Bar.Value = start;
            if (Bar.Value == 100)
            {
                Bar.Value = 0;
                timer1.Stop();
                LoginForm log = new LoginForm();
                this.Hide();
                log.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bar_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
