using System;
using System.Reflection;

namespace zd_2._3Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                string a_1 = textBox1.Text;
                string b_1 = textBox2.Text;
                int a = Convert.ToInt32(a_1);
                int b = Convert.ToInt32(b_1);

                if (a > b)
                {
                    textBox3.Text = "B должно быть больше A";
                    textBox4.Text = "B должно быть больше A";
                    textBox5.Text = "B должно быть больше A";
                    Console.Read();
                    return;
                }


                int i = a;
                for (; i <= b; i++)
                {
                    if (i % 3 == 0)
                    {
                        textBox3.Text += i;
                        textBox3.Text += " ";
                    }
                }

                i = a;
                while (i <= b)
                {
                    if (i % 3 == 0)
                    {
                        textBox4.Text += i;
                        textBox4.Text += " ";
                    }
                    i++;
                }

                i = a;
                do
                {
                    if (a == b)
                        break;
                    if (i % 3 == 0)
                    {
                        textBox5.Text += i;
                        textBox5.Text += " ";
                    }
                    i++;
                }
                while (i <= b);
            }
            catch
            {
                textBox3.Text = "¬ведите корекное число!";
                textBox4.Text = "¬ведите корекное число!";
                textBox5.Text = "¬ведите корекное число!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t1 = item as TextBox;
                    t1.Text = string.Empty;
                }
            }
        }
    }
}