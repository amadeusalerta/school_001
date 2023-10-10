namespace SimpleCalculator_Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1, num2, result;
        string option;

        private void txtDisplayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplayer.Text = txtDisplayer.Text + btn0.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtDisplayer.Text);

            txtDisplayer.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtDisplayer.Text);

            txtDisplayer.Clear();
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtDisplayer.Text);

            txtDisplayer.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtDisplayer.Text);

            txtDisplayer.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDisplayer.Clear();
            result = (0);
            num1 = (0);
            num2= (0);
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2=int.Parse(txtDisplayer.Text);

            if (option.Equals("+"))
            {
                result = num1 + num2;
            }

            if (option.Equals("-"))
            {
                result = num1 - num2;
            }

            if (option.Equals("*"))
            {
                result = num1 * num2;
            }

            if (option.Equals("/"))
            {
                result = num1 / num2;
            }

            txtDisplayer.Text=result+"";
        }
    }
}