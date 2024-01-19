using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Inteface
{
    internal class Circle : Shape, IShape
    {
        public double Radius;


        //1 Abstarct
        //public override double CalculateArea()
        //{
        //    double pi = 3.14, area;
        //    area = pi * Radius * Radius;
        //    return area;
        //}


        //===================================

        //2 Interface
        public double CalculateArea()
        {
            double pi = 3.14, area;
            area = pi * Radius * Radius;
            return area;
        }
    }
}
