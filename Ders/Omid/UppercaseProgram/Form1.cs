namespace UppercaseProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text != "") 
            {
                string text=textBox2.Text; ;
                string firstletter1 = string.Join(" ", text.Split(' ').ToList().ConvertAll(word=>word.Substring(0,1).ToUpper()+word.Substring(1)));
                textBox2.Text = firstletter1;
            }
        }
    }
}