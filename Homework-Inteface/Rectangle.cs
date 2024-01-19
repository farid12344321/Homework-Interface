using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Inteface
{
    internal class Rectangle : Shape, IShape
    {
        public double Height;
        public double Width;


        //1 Abstarct

        //public override double CalculateArea()
        //{
        //    double result = Height * Width;
        //    return result;
        //}

        //=====================================



        //2 Interface

        public double CalculateArea()
        {
            double result = Height * Width;
            return result;
        }
    }
}
