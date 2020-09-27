using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="PasswordofPasswords")
            {
                Form4 newForm = new Form4();
                newForm.Show();
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
