using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_2023
{
    public class Vehicle
    {
        public string brand_01 = "Ford";
        public string honk()
        {
            return " düt düt!";
        }


    }


    public class Car : Vehicle
    {
        public string name_01 = "Mustang";
    }

    public class MyClassRoom
    {
        private int MyGrade;
        private int grades;
        public void degerat(int score_01, int score_02)
        {
            MyGrade = score_01;
            grades = score_02;
        }
        public (int, int) GetGrades()
        {
            return (MyGrade, grades);
        }

        public int grade()
        {
            return 20;
        }

    }

    public class MyClass1
    {
        private int myField;
        private int MyField_02;

        public int MyProperty
        { get { return myField; } set {  myField = value; } }   
        public int MyProperty_02 {  get { return MyField_02; } set { MyField_02 = value; } }


    }


}
