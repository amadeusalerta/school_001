using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_12_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class StudentDatas
        {
            public int StudentNumber;
            public string StudentName;
            public double MathDegree;
            public double OOPDegree;
        }

        public int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            List<StudentDatas> studentList = new List<StudentDatas>();

            StudentDatas studentData = new StudentDatas
            {
                StudentName = textBox1.Text,
                StudentNumber = int.Parse(textBox2.Text),
                MathDegree = double.Parse(textBox3.Text),
                OOPDegree = double.Parse(textBox4.Text)
            };

            studentList.Add(studentData);

            textBox6.Text = "";

            foreach (var student in studentList)
            {
                textBox6.Text += student.StudentName +" "+ student.StudentNumber+" " + student.MathDegree + " " + student.OOPDegree;
            }
        }
    }
}