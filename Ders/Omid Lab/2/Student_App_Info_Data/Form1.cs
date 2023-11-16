using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_App_Info_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insert
            string insertQuery = "INSERT INTO Employee ([StudentNumber], Department, Adress) VALUES (@Value1, @Value2, @Value3)";

            using (SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=Employee;Integrated Security=True;"))
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Show All

            // Create a SQL SELECT statement
            string selectQuery = "SELECT TOP(1000) [StudentNumber],[Department],[Adress] FROM[Employee].[dbo].[Employee]";

            // Set up a connection, command, and data adapter
            using (SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=Employee;Integrated Security=True;"))
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete
            string insertQuery = $"delete from Employee where StudentNumber = {textBox5.Text}";

            using (SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=Employee;Integrated Security=True;"))
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
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Search
            int searchId;

            // Check if the entered ID is a valid integer
            if (!int.TryParse(textBox4.Text, out searchId))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            // Create a SQL SELECT statement
            string selectQuery = "SELECT * FROM Employee WHERE StudentNumber = @SearchID";

            // Set up a connection, command, and data adapter
            using (SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=Employee;Integrated Security=True;"))
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
