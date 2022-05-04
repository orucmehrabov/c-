using System;

namespace Task_2_04._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk Azersud = new Milk ("Azersud ", 2.5, 1.0, 1.5, 10);
            Azersud.Sell();
            Milk Milla = new Milk ("Milla ", 2.2, 1.5, 0.5, 50);
            Milla.Sell();
        }
    }
}