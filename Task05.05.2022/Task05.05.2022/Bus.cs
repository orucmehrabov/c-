using System;
using System.Collections.Generic;
using System.Text;

namespace Task05._05._2022
{
    class Bus : Vehicle
    {
        public byte PassengerCount;

        public Bus()
        {
        }

        public Bus(string brand, string model, string color, byte maxSpeed, byte passengerCount) : base(brand, model, color, maxSpeed)
        {
            PassengerCount = passengerCount;
        }

        public override string Info()
        {
            if (string.IsNullOrEmpty(Brand) || string.IsNullOrWhiteSpace(Brand) || string.IsNullOrEmpty(Model) || string.IsNullOrWhiteSpace(Model))
            {
                return $"Vehicle not found";
            }
            else
            {
                return $"Brand: {Brand} Model: {Model} Color: {Color} Max Speed: {MaxSpeed} Passenger Count: {PassengerCount}";
            }
        }
    }
}
