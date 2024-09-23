using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pctMavi.Left + pctMavi.Width >= lblFinish.Left && pctPembe.Left < pctMavi.Left)
            {
                timer1.Stop();
                MessageBox.Show("Mavi güzel Kazandı ! ! !");
                pctMavi.Left = 0;
                pctPembe.Left = 0;
            }
            else if (pctPembe.Left + pctPembe.Width >= lblFinish.Left && pctMavi.Left < pctPembe.Left)
            {
                timer1.Stop();
                MessageBox.Show("Pembe fırtına kazandı ! ! !");
                pctMavi.Left = 0;
                pctPembe.Left = 0;
            }
            else if (pctMavi.Left + pctMavi.Width >= lblFinish.Left && pctPembe.Left + pctPembe.Width == pctMavi.Left + pctMavi.Width)
            {
                timer1.Stop();
                MessageBox.Show("Pembe mavi berabere");
                pctMavi.Left = 0;
                pctPembe.Left = 0;
            }
            pctMavi.Left += rnd.Next(5, 16);
            pctPembe.Left += rnd.Next(5, 16);
        }
    }
}
