using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Drawing;

namespace StudentApplication
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Show All

            // Create a SQL SELECT statement
            string selectQuery = "SELECT TOP(1000) [StudentNumber],[DepartmentName],[Address] FROM[Tables01].[dbo].[Table_2]";

            // Set up a connection, command, and data adapter
            using (SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=Tables01;Integrated Security=True;"))
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                try
                {
                    // Open the connection
                    connection.Open();

                    // Fill the DataTable with the results
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insert
            string insertQuery = "INSERT INTO Tables01 ([StudentNumber], DepartmentName, Address) VALUES (@Value1, @Value2, @Value3)";

            using (SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=Tables01;Integrated Security=True;"))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                // Add parameters to the command
                command.Parameters.AddWithValue("@Value1", textBox1.Text);
                command.Parameters.AddWithValue("@Value2", textBox2.Text);
                command.Parameters.AddWithValue("@Value3", textBox3.Text);

                // Open the connection
                connection.Open();

                // Execute the INSERT statement
                int rowsAffected = command.ExecuteNonQuery();

                // Check if the insertion was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to insert data.");
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Delete
            string insertQuery = $"delete from Tables01 where StudentNumber = {textBox4.Text}";

            using (SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=Tables01;Integrated Security=True;"))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                // Open the connection
                connection.Open();

                // Execute the INSERT statement
                int rowsAffected = command.ExecuteNonQuery();

                // Check if the insertion was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to delete data.");
                }
            }
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Search
            int searchId;

            // Check if the entered ID is a valid integer
            if (!int.TryParse(textBox5.Text, out searchId))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            // Create a SQL SELECT statement
            string selectQuery = "SELECT * FROM Employee WHERE StudentNumber = @SearchID";

            // Set up a connection, command, and data adapter
            using (SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=Tables01;Integrated Security=True;"))
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                // Add parameter to the command
                command.Parameters.AddWithValue("@SearchID", searchId);

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                try
                {
                    // Open the connection
                    connection.Open();

                    // Fill the DataTable with the results
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}