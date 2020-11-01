using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fouelAmount = double.Parse(input[1]);
                double fouelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fouelAmount, fouelConsumption);
                cars.Add(car);
            }
            string input1 = Console.ReadLine();

            while (input1 != "End")
            {
                string[] data = input1.Split();
                string model = data[1];
                int amountOfKm = int.Parse(data[2]);

                Car car = cars.FirstOrDefault(x => x.Model == model);
                car.Drive(amountOfKm);


                input1 = Console.ReadLine();
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }

        //private static Car GetCar(List<Car> cars, string model)
        //{
        //    foreach (var item in cars)
        //    {
        //        if (item.Model == model)
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}
    }
}
