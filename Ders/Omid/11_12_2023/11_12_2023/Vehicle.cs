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
            return "Karadenizlileri Sevmiyorum!";
        }


    }


    public class Car : Vehicle
    {
        public string name_01 = "Mustang";
    }

    public class MyClassRoom
    {
        private int MyGrade;

        public int grade()
        {
            return 20;
        }

    }

    public class MyClass1
    {
        private int myField;

        public int MyProperty
        { get { return myField; } set {  myField = value; } }   


    }

}
