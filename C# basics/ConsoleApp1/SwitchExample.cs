using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Random Text");
            StringBuilder stringBuilder2 = new StringBuilder("More Stuff that is very important", 256);
            Console.WriteLine("Capacity: {0}", stringBuilder2.Capacity);
            Console.WriteLine("Capacity: {0}", stringBuilder2.Length);
            stringBuilder2.AppendLine("\nMore important text");
            CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");
            string bestCustomer = "bob smith";
            stringBuilder2.AppendFormat(enUS, "Best Customer: {0}", bestCustomer);
            Console.WriteLine(stringBuilder2.ToString());
            stringBuilder2.Clear();



        }

    }
}