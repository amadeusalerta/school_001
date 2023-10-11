namespace DecimalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2, num3, num4, num5, num6, num7;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = num1.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox3.Text);
            textBox3.Text = num2.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num3 = Convert.ToInt32(textBox2.Text);
            textBox2.Text = num3.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            num4 = Convert.ToInt32(textBox4.Text);
            textBox4.Text = num4.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            num5 = num1 + num3;
            num5 = Convert.ToInt32(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (num2 == num4)
            {
                num6 = num2;
                num7 = (num1 / num3) + (num2 / num4);
                num5 = num1 + num3;
            }
            else
            {
                MessageBox.Show("Paydalar Eþit deðil.");
            }
            textBox5.Text = num5.ToString();
            textBox6.Text = num6.ToString();
            textBox7.Text = num6.ToString();
        }
    }
}