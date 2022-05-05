using System;
using System.Collections.Generic;
using System.Text;

namespace Task05._05._2022
{
    abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public string Color;
        public byte MaxSpeed;
        public Vehicle()
        {
            Console.WriteLine("Car created");
        }

        public Vehicle(string brand, string model)
        {
            if (string.IsNullOrEmpty(brand) || string.IsNullOrWhiteSpace(brand))
            {
                Console.WriteLine("Please, enter the Brand Name");
            }
            else
            {
                Brand = brand;
            }
            if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
            {
                Console.WriteLine("Please, enter the Model Name");
            }
            else
            {
                Model = model;
            }
        }
        public Vehicle(string brand, string model, string color, byte maxSpeed) : this(brand, model)
        {
            Color = color;
            MaxSpeed = maxSpeed;
        }
        public abstract string Info();
    }
}