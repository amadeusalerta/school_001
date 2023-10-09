namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int number1;
        int number2;
        int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // result = number2 - number1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // result=number1 / number2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //result= number2*number1;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //number1 = Convert.ToInt32(Console.ReadLine());
            int num1 =Convert.ToInt32(textBox1.Text);
            textBox1.Text = num1.ToString();
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num2 = Convert.ToInt32(textBox2.Text);
            textBox2.Text = num2.ToString();
            textBox1.Text
            int s = num1 + num2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = result.ToString();
        }
    }
}