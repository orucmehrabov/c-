using System;

namespace Task_1_04._05._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter the part you are looking for: ");
            string search = Console.ReadLine();
            Console.Write("Result: ");
            sentence.CustomContain(search);
        }
    }
}