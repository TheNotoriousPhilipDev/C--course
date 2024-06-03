using System;

namespace ConsoleApp1
{
    public class Program
    {

        // ------------FUNCTIONS------------
        static void PrinArray(int[] intArray, string mess)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, i);
            }
        }

        //------------END OF FUNCTIONS------------
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine("Vamos a imprimir algún numero del array numbers: {0}, {1}", numbers[0], numbers[1]);

            string[] customers = { "bob", "sally", "sue", };
            var employees = new[] { "mike", "paul" };
            object[] randomArray = { "paul", 45, 1.234 };
            Console.WriteLine("randomArray 0: {0}", randomArray[0].GetType());
            Console.WriteLine("Array size : {0}", randomArray.Length);
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine(randomArray[i]);
            }
            Console.WriteLine("--------------------------");

            string[,] custNames = new string[2, 2] { { "Bob", "Carlos" }, { "Sally", "Smith" } };
            Console.WriteLine("MD Value: {0}",
                custNames.GetValue(1, 1));

            int[] randNums = { 1, 2, 3, 4, };
            PrinArray(randNums, "foreach");

            Console.WriteLine("--------------------------------------");

            Array.Sort(randNums);
            Array.Reverse(randNums);
            Array.IndexOf(randNums, 0);
            randNums.SetValue(0, 0);
            int[] srcArray = { 1, 2, };

        }



    }
}