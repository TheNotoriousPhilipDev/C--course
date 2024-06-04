using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        static void PaintCar(CarColor c)
        {
            Console.WriteLine("The car was painted {} with the code {1}", c, (int)c);
        }
        enum CarColor : byte
        {
            orange = 0,
            green,
            red,
            yellow,
        }
        static void Main(string[] args)
        {
            CarColor car1 = CarColor.orange;
            PaintCar(car1);

        }

    }
}