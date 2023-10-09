namespace omid_9_10_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
            bomb.Text = "OK";
        }

        private void ShowList_Click(object sender, EventArgs e)
        {
            liste.Visible = true;
        }

        private void liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}