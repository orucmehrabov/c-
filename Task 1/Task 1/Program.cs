using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Oruc", "Orxan", "Vusal", "Arzu", "Elçin" };

            foreach (string name in names);

            int counter = 0;
            foreach (char ch in names) ;

            counter++;

            if (counter == 5)

                Console.WriteLine(names + "->" + counter + "herf");



        }
    }
}
