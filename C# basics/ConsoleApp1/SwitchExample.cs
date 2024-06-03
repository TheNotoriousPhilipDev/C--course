using System;
using System.Globalization;

namespace ConsoleApp1
{
    public class Program
    {

        static double DoDivision(double primerNumero, double segundoNumero)
        {
            return primerNumero / segundoNumero;
        }
        static void Main(string[] args)
        {
            double num = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5/0 = {0}", DoDivision(num, num));
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine($"DivideByZero {ex.Message}");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                Console.WriteLine("Default message");
            }


        }

    }
}