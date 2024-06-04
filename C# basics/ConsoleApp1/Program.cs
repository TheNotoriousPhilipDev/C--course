using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1: {0}", rect1.Area());
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length: {0}", rect2.length);

            Animal animal = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };

        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public double Area()
            {
                return length / width;
            }
        }

    }
}