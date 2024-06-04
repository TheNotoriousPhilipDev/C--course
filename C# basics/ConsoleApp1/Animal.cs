using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public string name;
        public string sound;
        static int numOfAnimals;

        public Animal(string name, string sound, int numOfAnimals)
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;

        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

    }
}