using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _112023
{
    public class StudentInfo
    {
        public int idNumber;
        public string name;
        public string surname;
        public float oopGrade;
        public float calculusGrade;
        public float dataStructureGrade;
        public int studentAverage;
    }


    public class CalculationClass
    {


        public int[] studentIndex=new int[999];

        public void AverageCalculator()
        {
            StudentInfo stdAVG = new StudentInfo();
            StudentInfo calcGRD = new StudentInfo();
            StudentInfo dataSTR = new StudentInfo();

            int StudentAveraj;

        }



    }



}
