namespace StudentApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number1, number2, number3;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            number1 = number1 * (4/10);
            number1 = Convert.ToInt32(textBox3.Text);
            textBox3.Text = number1.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            number2 = number2 * (6 / 10);
            number2 = Convert.ToInt32(textBox4.Text);
            textBox4.Text = number2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number3 = (number1 + number2) / 2;
            textBox5.Text = number3.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}