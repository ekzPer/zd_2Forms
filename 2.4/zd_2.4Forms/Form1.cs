using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace zd_2._4Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 4 - i; j >= 0; j--)
                {
                    textBox1.Text += j;
                    textBox1.Text += " ";
                }
                textBox1.Text += "\r\n";
            }
            Console.ReadLine();
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
            
         
            
