using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ShapeMath
    {

        public static double GetArea(string shape, double length, double length2)
        {
            if (shape.Equals("Rectangule"))
            {
                return length * length2;
            }
            else
            {
                return length = 0;
            }

        }

    }
}