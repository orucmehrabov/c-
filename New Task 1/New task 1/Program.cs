using System;

namespace New_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int number = input;
            int counter = 0;
            while (number != 0)
            {
                number /= 10;
                counter++;
            }
            Console.Write("Enter the second number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Result: ");
            var result = a * ( Math.Pow(10, counter++)) + input ;
            Console.Write(result );
        }
        
    }
}
