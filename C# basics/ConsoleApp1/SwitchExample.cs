using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11); // minimun value and maximum value
            int numberGuessed = 0;
            Console.WriteLine("random num: ", secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 and 10: ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (numberGuessed != secretNumber);

            Console.WriteLine($"You guessed it, it was: {secretNumber}");


        }

    }
}