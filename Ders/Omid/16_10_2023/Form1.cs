namespace _16_10_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number1, number2, number3, result;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = number1.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(textBox2.Text);
            textBox2.Text = number2.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            number3 = Convert.ToInt32(textBox3.Text);
            textBox3.Text = number3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = (number1 + number2 + number3) / 3;
            result = Convert.ToInt32(result);
            textBox4.Text = result.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (number1 < number2 && number1 < number3)
            {
                result = number1;
                result = Convert.ToInt32(result);
                textBox4.Text = result.ToString();
            }

            else if (number2 < number3 && number2 < number1)
            {
                result = number2;
                result = Convert.ToInt32(result);
                textBox4.Text = result.ToString();
            }

            else
            {
                result = number3;
                result = Convert.ToInt32(result);
                textBox4.Text = result.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (number1 > number2 && number1 > number3)
            {
                result = number1;
                result = Convert.ToInt32(result);
                textBox4.Text = result.ToString();
            }

            else if (number2 > number3 && number2 > number1)
            {
                result = number2;
                result = Convert.ToInt32(result);
                textBox4.Text = result.ToString();
            }

            else
            {
                result = number3;
                result = Convert.ToInt32(result);
                textBox4.Text = result.ToString();
            }
        }
    }
}