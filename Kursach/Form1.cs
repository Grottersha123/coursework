using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Roman_Parse(textBox1.Text) == 0)
            {
                MessageBox.Show("Введите Римское число");
                textBox1.Text = "";

            }
            else
            {
                textBox2.Text = Roman_Parse(textBox1.Text).ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Arabic_Parse(a);
            }
            catch
            {
                textBox1.Text = "";
                MessageBox.Show("Введите Арабское число");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            label1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            textBox3.Text += "I";
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            textBox3.Text += "V";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            textBox3.Text += "X";
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            textBox3.Text += "L";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox3.Text += "C";
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            textBox3.Text += "M";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = Roman_Parse(textBox3.Text);
            b = textBox3.Text;
            textBox3.Clear();
            count = 1;
            label1.Text = b + "+";
          //  sign = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            a = Roman_Parse(textBox3.Text);
            b = textBox3.Text;
            textBox3.Clear();
            count = 2;
            label1.Text = b + "-";
            //sign = true;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            b = textBox3.Text;
            a = Roman_Parse(textBox3.Text);
            textBox3.Clear();
            count = 3;
            label1.Text = b + "*";
            //sign = true;
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            a = Roman_Parse(textBox3.Text);
            b = textBox3.Text;
            textBox3.Clear();
            count = 4;
            label1.Text = b + "/";
         //   sign = true;
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            calculate();

            label1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Roman_Parse(textBox3.Text) == 0)
            {
                MessageBox.Show("Введите Римское число");
                textBox3.Text = "";

            }
            else
            {
                textBox3.Text = Roman_Parse(textBox3.Text).ToString();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox3.Text);
                textBox3.Text = Arabic_Parse(a);
            }
            catch
            {
                textBox3.Text = "";
                MessageBox.Show("Введите Арабское число");
            }

        }

    
    }
}
