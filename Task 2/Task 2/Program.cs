using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 316;
            var sum = 0;

            while ( 0 < number) ;

            var reminder = number % 10;
            sum = sum + reminder;
            number = number / 10;

            Console.WriteLine(sum);
        }
    }
}
