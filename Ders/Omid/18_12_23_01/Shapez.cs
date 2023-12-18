using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_23_01
{
    public interface IShape
    {
        double GetArea();
    }

    public interface IColor
    {
        string GetColor();
    }

    public class Circle:IShape,IColor
    {
        private double radius;
        private string color;

        public Circle(double radius, string color)
        {
            this.color = color;
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public string GetColor()
        {
            return color;
        }

    }
}
