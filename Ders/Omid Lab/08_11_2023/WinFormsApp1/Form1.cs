using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string[] mothers = new string[1];
        private string[][] children = new string[1][];
        public Form1()
        {
            InitializeComponent();
        }

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mothers[0] = textBox1.Text;

            List<string> childData = new List<string>();

            AddChildDataToList(childData, textBox2.Text, textBox7.Text);
            AddChildDataToList(childData, textBox3.Text, textBox8.Text);
            AddChildDataToList(childData, textBox4.Text, textBox9.Text);
            AddChildDataToList(childData, textBox5.Text, textBox10.Text);
            AddChildDataToList(childData, textBox6.Text, textBox11.Text);

            children[0] = childData.ToArray();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox7.Text = "";
            textBox3.Text = "";
            textBox8.Text = "";
            textBox4.Text = "";
            textBox9.Text = "";
            textBox5.Text = "";
            textBox10.Text = "";
            textBox6.Text = "";
            textBox11.Text = "";
        }

        private void AddChildDataToList(List<string> childData, string childName, string childAge)
        {
            if (!string.IsNullOrWhiteSpace(childName))
            {
                childData.Add(childName);
                childData.Add(childAge);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchName = textBox12.Text;


            int index = Array.IndexOf(mothers, searchName);

            if (index != -1)
            {

                string[] childData = children[index];


                listBox1.Items.Clear();

                for (int i = 0; i < childData.Length; i += 2)
                {
                    string childName = childData[i];
                    string childAge = childData[i + 1];
                    listBox1.Items.Add($"Child: {childName}, Age: {childAge}");
                }
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("Mother's name not found.");
            }

            textBox12.Text = "";
        }


    }
}