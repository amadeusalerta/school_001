using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _112023
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

        class Student
        {
            public int IdNumber { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public double OopGrade { get; set; }
            public double CalculusGrade { get; set; }
            public double DataStructureGrade { get; set; }
            public double StudentAvg { get; private set; }

            public void ComputeAverage()
            {
                StudentAvg = (OopGrade + CalculusGrade + DataStructureGrade) / 3;
            }
        }
            private RichTextBox richTextBox;


            private void InitializeComponents()
            {
                richTextBox = new RichTextBox();
                richTextBox.Dock = DockStyle.Fill;

                Controls.Add(richTextBox);

                // Create an array to store student objects
                Student[] students = new Student[3]; // Change the size based on your needs

                // Gather data for each student using a for loop
                for (int i = 0; i < students.Length; i++)
                {
                    Student student = new Student();

                    Console.WriteLine($"Enter data for Student {i + 1}:");

                    Console.Write("Id Number: ");
                    student.IdNumber = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Name: ");
                    student.Name = Console.ReadLine();

                    Console.Write("Surname: ");
                    student.Surname = Console.ReadLine();

                    Console.Write("OOP Grade: ");
                    student.OopGrade = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Calculus Grade: ");
                    student.CalculusGrade = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Data Structure Grade: ");
                    student.DataStructureGrade = Convert.ToDouble(Console.ReadLine());

                    // Compute and set the average grade
                    student.ComputeAverage();

                    // Store the student object in the array
                    students[i] = student;

                    Console.WriteLine();
                }

                // Display student information in the RichTextBox
                DisplayStudentInfo(students);
            }

            private void DisplayStudentInfo(Student[] students)
            {
                foreach (var student in students)
                {
                    richTextBox.AppendText($"Id: {student.IdNumber}, Name: {student.Name} {student.Surname}\n");
                    richTextBox.AppendText($"OOP Grade: {student.OopGrade}, Calculus Grade: {student.CalculusGrade}, Data Structure Grade: {student.DataStructureGrade}\n");
                    richTextBox.AppendText($"Average Grade: {student.StudentAvg:F2}\n\n");
                }
            }

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.Run(new Form1());
            }
    }

}

