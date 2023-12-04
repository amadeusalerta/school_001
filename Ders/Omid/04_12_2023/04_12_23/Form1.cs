using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_12_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double numero_01 = 0;

        class Rectangle
        {
           public double x, y;

            public double GetArea()
            {
                return x * y;
            }
        }

        public int i = 0;

        class StudentDatas
        {
            public int StudentNumber;
            public string StudentName;
            public double StudentGrade;
            public double oopGrade;

        }

        class TrianguluarShape
        {
            public double triangular_height;
            public double triangular_width;

            public double GetAreaTriangle()
            {
                return (triangular_height * triangular_width) / 2;
            }
        }

        class CircleShape
        {
            public double radius_01;
            public double pi_number;

            public double GetCircleArea()
            {
                return pi_number * radius_01 * radius_01;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.y = 4.5;
            myRectangle.x = 1.5;
            textBox1.Text = myRectangle.GetArea().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrianguluarShape myTriangular=new TrianguluarShape();
            myTriangular.triangular_width = 3;
            myTriangular.triangular_height = 5;
            textBox1.Text=myTriangular.GetAreaTriangle().ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CircleShape myCircle=new CircleShape();
            myCircle.radius_01 = 3;
            myCircle.pi_number = 3.14;
            textBox1.Text=myCircle.GetCircleArea().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentDatas[] student_veri=new StudentDatas[5];
            student_veri[i].StudentName = textBox1.Text;
            i++;
        }
    }
}
