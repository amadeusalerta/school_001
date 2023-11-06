using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DatabaseFormApp
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local),Initial Catalog=Tables1;Integrated Security=True");


        private void ShowData()
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Insert into MainTable(ID,Name,Address) values('" +
                textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" +
                textBox3.Text.ToString() + "')", con);
            com.ExecuteNonQuery();
            con.Close();
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
    }
}