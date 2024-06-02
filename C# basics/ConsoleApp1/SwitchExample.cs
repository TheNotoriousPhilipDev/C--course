using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero = 1000;
            Console.WriteLine($"Estamos sumando cosas {numero}");
            string stringOfTest = "magaly";
            Console.WriteLine($"testing length method {stringOfTest.Length}");
            Console.WriteLine($"testing contains method {stringOfTest.Contains("m")}");
            Console.WriteLine($"testing indexOf method {stringOfTest.IndexOf("y")}");
            Console.WriteLine($"testing remove method: {stringOfTest.Remove(1, 3)}");
            Console.WriteLine($"testing insert method: {stringOfTest.Insert(1, "a")}");
            Console.WriteLine($"testing insert method: {stringOfTest.Replace("a", "e")}");
            Console.WriteLine($"testing compare method: {String.Compare(stringOfTest, "magaly")}");



        }
    }
}