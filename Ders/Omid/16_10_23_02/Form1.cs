namespace _16_10_23_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int degree1, degree2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            degree1=Convert.ToInt32(textBox1.Text);
            textBox1.Text = degree1.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            degree2=Convert.ToInt32((degree1*1.8)+32);
            textBox2.Text = degree2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            degree2 = Convert.ToInt32((degree1 -32) /1.8);
            textBox2.Text = degree2.ToString();
        }
    }
}