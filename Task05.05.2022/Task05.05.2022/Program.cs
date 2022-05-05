using System;

namespace Task05._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus("Mercedes", "Sprinter", "Blue", 190, 18);
            if (string.IsNullOrEmpty(bus.Brand) || string.IsNullOrWhiteSpace(bus.Brand) || string.IsNullOrEmpty(bus.Model) || string.IsNullOrWhiteSpace(bus.Model))
            {
                Console.WriteLine("Car wasn't created");
            }
            else
            {
                Bus bus1 = new Bus();
            }
            Console.WriteLine(bus.Info());
        }
    }
}