using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         //  convertFromFahrenheit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           convertFromFahrenheit();
        }
        private void convertFromFahrenheit()
        {
            float f=0;
            try
            {
                f=float.Parse (textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Enter number only");
            }
            float c=5f/9f*(f-32);
            float k=c-273;

            textBox2.Text=c.ToString();
            textBox3.Text=k.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           //convertFromCelsius();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }
        private void convertFromCelsius()
        {
            float c = 0;
            try
            {
                c = float.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Enter number only");
            }
            float f = c* (9 / 5) + 32;
            float k = c+273;

            textBox1.Text = f.ToString();
            textBox3.Text = k.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //convertFromKelvin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }
        private void convertFromKelvin()
        {
            float k = 0;
            try
            {
                k = float.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Enter number only");
            }
            float f = (k-273)*(9/5)+32;
            float c=k-27;

            textBox1.Text = f.ToString();
            textBox2.Text = k.ToString();
        }
    }
}
