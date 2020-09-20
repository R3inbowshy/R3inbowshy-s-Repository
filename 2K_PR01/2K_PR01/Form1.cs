using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2K_PR01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            double L = Convert.ToDouble(textBox1.Text);
            double R = Convert.ToDouble(textBox2.Text);
            double r = Convert.ToDouble(textBox3.Text);

            double V = L * Math.PI * (R * R - r * r);
            textBox4.Text = V.ToString();
        }
    }
}
