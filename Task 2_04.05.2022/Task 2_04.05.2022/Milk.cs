using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_04._05._2022
{
    class Milk : Product
    {
        public double Volume;
        public double FatRate;

        public Milk(string name, double price, double volume, double fatRate, byte purchase) : base(name, price, purchase)
        {
            Volume = volume;
            FatRate = fatRate;
            Console.Write ("Enter the percentage of fat in the milk: ");
            FatRate = Convert.ToDouble(Console.ReadLine());
            Console.Write ("Enter the amount you want to buy: ");
            Purchase = Convert.ToByte(Console.ReadLine());
        }

        public override void Sell()
        {
            TotalSaled += Purchase;
            Console.WriteLine("Number of products sold: " + TotalSaled);

            if (count > 0)
            {
                count -= Purchase;
                TotalIncome += Price * Purchase;
                Console.WriteLine($"The number of remaining products: {count}");
                Console.WriteLine($"Gross sales revenue: {TotalIncome}");
            }
            else
            {
                Console.WriteLine("The product is not in stock");
            }
        }
    }
}