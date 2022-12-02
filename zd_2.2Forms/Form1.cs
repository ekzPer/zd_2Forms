namespace zd_2._2Forms
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
                string n_1 = textBox1.Text;
                int n = Convert.ToInt32(n_1);
                if (n <= 100 && n >= 0)
                {
                    if (n >= 90)
                        textBox2.Text = "Отлично";
                    if (n >= 70 && n < 90)
                        textBox2.Text = "Хорошо";
                    if (n >= 50 && n < 70)
                        textBox2.Text = "Удовлетворительно";
                    if (n < 50)
                        textBox2.Text = "Неудовлетворительно";
                }
                else textBox2.Text = "Вы ошиблись!";
            }
            catch 
            {
                textBox2.Text = "Введите число!";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}