namespace zd_2._1Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string x_1 = textBox1.Text;
                string y_1 = textBox2.Text;
                int x = Convert.ToInt32(x_1);
                int y = Convert.ToInt32(y_1);
                if (-23 < x && x < y && 0 > y && -23 < y)
                    textBox3.Text = "Внутри";
                else if (-23 > x || x > y || 0 < y || -23 > y)
                    textBox3.Text = "Вне";
                else textBox3.Text = "На границе";
            }
            catch 
            {
                textBox3.Text = "x и y должны быть числом";
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