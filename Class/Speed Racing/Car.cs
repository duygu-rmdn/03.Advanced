using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAnount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAnount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }
        public string  Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public void Drive(int amountOfKm)
        {
            bool canMove = FuelAmount - (FuelConsumptionPerKilometer * amountOfKm) >= 0;
            if (canMove)
            {
                FuelAmount -= FuelConsumptionPerKilometer * amountOfKm;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
