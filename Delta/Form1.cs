using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = vScrollBar1.Value.ToString();

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = vScrollBar3.Value.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, delta;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);

            delta = b * b - 4 * a * c;
            textBox4.Text = delta.ToString();

            if (a == 0)
            {
                if (b == 0)
                {
                    textBox4.Text = "Funkcja liniowa ";
                    textBox5.Text = "Funkcja liniowa ";
                    textBox6.Text = c.ToString();
                    textBox7.Text = "Funkcja liniowa ";
                }
                else
                {
                    textBox4.Text = "Funkcja liniowa, poniewaz a=0";
                    textBox5.Text = "Funkcja liniowa, poniewaz a=0";
                    textBox6.Text = (-c * Math.Pow(b, -1)).ToString();
                    textBox7.Text = "Funkcja liniowa, poniewaz a=0";

                }
            }
            else
            {
                if (delta == 0)
                {
                    textBox5.Text = Math.Sqrt(delta).ToString();
                    textBox6.Text = ((-b - Math.Sqrt(delta)) / (2 * a)).ToString();
                    textBox7.Text = "Funkcja ma jedno miejsce zerowe";
                }
                else if (delta > 0)
                {
                    textBox5.Text = Math.Sqrt(delta).ToString();
                    textBox6.Text = ((-b - Math.Sqrt(delta)) / (2 * a)).ToString();
                    textBox7.Text = ((-b + Math.Sqrt(delta)) / (2 * a)).ToString();
                }
                else
                {
                    delta *= -1;
                    double x1 = Math.Abs(-b * Math.Pow(2 * a, -1));
                    textBox5.Text = Math.Sqrt(delta).ToString() + " i";
                    textBox6.Text = x1.ToString();
                    textBox7.Text = (x1 * -1).ToString();
                    textBox6.Text += " + " + x1.ToString() + " i";
                    textBox7.Text += " " + (x1 * -1).ToString() + " i";

                }
            }
        }
    }
}
