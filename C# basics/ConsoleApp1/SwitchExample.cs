using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(2020, 12, 30);
            Console.WriteLine(awesomeDate.ToString());
            awesomeDate = awesomeDate.AddDays(5);
            Console.WriteLine(awesomeDate);
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);

            TimeSpan interval = date2 - date1;
            Console.WriteLine("{0} - {1} = {2}", date2, date1, interval);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time: {0}", lunchTime.ToString());


        }

    }
}