using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            progress.Value = startpoint;
            if(progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
