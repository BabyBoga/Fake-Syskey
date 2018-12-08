using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fake_Syskey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Incorrect Credentials";
            System.Media.SystemSounds.Beep.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!radioButton5.Checked)
            {
                pictureBox1.Image = Properties.Resources.microsoftlogo2;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cat_gif;
        }
    }
}
