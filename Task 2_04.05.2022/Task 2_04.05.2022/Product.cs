﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_04._05._2022
{
    abstract class Product
    {
        public string Name;
        public double Price;
        public static byte Purchase;
        public static double TotalIncome;
        public static int TotalSaled = 0;
        public static int countSaled = 0;
        public static int count = 100;
        public Product(string name, double price, byte purchase)
        {
            Name = name;
            Price = price;
            Purchase = purchase;
        }
        public abstract void Sell();
    }
}