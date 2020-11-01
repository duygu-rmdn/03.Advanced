using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];


                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                int counter = 0;
                Tire[] tires = new Tire[4];
                for (int j = 5; j < input.Length; j+=2)
                {
                    double tire1Pressure = double.Parse(input[j]);
                    int tire1Age = int.Parse(input[j+1]);
                    Tire tire = new Tire(tire1Age, tire1Pressure);
                    tires[counter++] = tire;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                var fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(p=>p.Pressure < 1)).ToList();
                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                var flamable = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();
                foreach (var item in flamable)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
