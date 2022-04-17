using System;

namespace New_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write( "Enter the number: " );
            int num1 = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter divided number: ");
            int num2 = Convert.ToInt32 (Console.ReadLine());
            int remainder = num1 % num2;

            if (remainder == 0)
            {
                Console.Write("Number is divisible");
            }
            else if (remainder <= 3)
            {
                Console.Write("The nearest divisible number: " + (num1 - remainder));
            }
            else
            {
                Console.Write("The nearest divisible number: " + (num1 + num2 - remainder));
            }



        }
    }
}
