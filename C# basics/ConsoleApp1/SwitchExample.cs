using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? randomNum = null;
            if (randomNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            if (!randomNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }

        }

    }
}