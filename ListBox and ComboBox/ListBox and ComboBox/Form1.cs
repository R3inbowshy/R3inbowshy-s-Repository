using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_and_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                //MessageBox.Show("Номер выбранной строки " + (listBox1.SelectedIndex + 1).ToString());
                //Переносим номер выбранной строки в label
                label1.Text = "Номер выбранной строки: " + (listBox1.SelectedIndex + 1).ToString();
                label2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); //Удаление строки по её номеру
            }
            else
            {
                MessageBox.Show("Объект для удаления не выбран!");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Введите название дисциплины");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                textBox2.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                MessageBox.Show("Не выбран объект для изменения");
            }
        }
    }
}
