using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool eligibility = bool.Parse("true");
            int intfromstr = int.Parse("100");
            double doublefromstr = double.Parse("100.20");

            string strVal = doublefromstr.ToString();
            Console.WriteLine($"Data type : {strVal.GetType()}");
            double dblNum = 3423.20;
            Console.WriteLine($"Integer: {(int)dblNum}");



        }
    }
}