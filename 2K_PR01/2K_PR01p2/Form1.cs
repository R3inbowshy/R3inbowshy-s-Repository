using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2K_PR01p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double L = Convert.ToDouble(textBox1.Text);
            double t1 = Convert.ToDouble(textBox2.Text);
            double t2 = Convert.ToDouble(textBox3.Text);
            double U1 = L / t1;
            double U2 = L / t2;
            double Ut = U1 - U2;

            textBox4.Text = U1.ToString();
            textBox5.Text = U2.ToString();
            textBox6.Text = Ut.ToString();
        }
    }
}
