using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_12_23_02
{
    public class StudentData
    {
        public int IdNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public float oopGrade { get; set; }
        public float calculusGrade { get; set; }
        public float dataStructureGrade { get; set; }
        public float studentAvg { get; set; }
    }

    public class Main
    {
        static void MainFunction() 
        {
            StudentData student_001 = new StudentData();
            student_001.IdNumber = new int();
        }
    }

}
