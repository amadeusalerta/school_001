﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_12_2023
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

        private void button1_Click(object sender, EventArgs e)
        {
            Car MyCar=new Car();
            string result = MyCar.honk();
            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyClass1 obj1 = new MyClass1();
            MyClass1 obj2= new MyClass1();

            obj1.MyProperty = 10;
            obj2.MyProperty_02 = 30;

            int value = obj1.MyProperty;
            int value_02 = obj2.MyProperty_02;
            textBox3.Text=value.ToString()+" "+value_02.ToString();

            MyClassRoom object_01= new MyClassRoom();
            object_01.degerat(12, 254);
            var MyClassRoom =object_01.GetGrades();
            textBox4.Text = MyClassRoom.Item1.ToString();
            textBox5.Text = MyClassRoom.Item2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyClassRoom MyGrade = new MyClassRoom();
            int grade = MyGrade.grade();
            textBox2.Text = grade.ToString();
        }
    }
}
