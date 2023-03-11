using System;
using System.Collections.Generic;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new Park
            {
                ParkedCars = new List<Car>
                {
                    new Car
                    {
                        ArrivingTime = new DateTime(2021, 01, 16),
                        Color = "Blue",
                        Model = "Model S",
                        Mark = "Tesla",
                        Number = "RF 123"

                    }
                }
            };

            Console.WriteLine("Parked Cars:");

            parking.PrintParkedCars();

            Console.WriteLine("\n \nEnter a car data:");

            Console.WriteLine("Mark");
            var mark = Console.ReadLine();

            Console.WriteLine("Model");
            var model = Console.ReadLine();

            Console.WriteLine("Color");
            var color = Console.ReadLine();

            Console.WriteLine("Number");
            var Number = Console.ReadLine();

            parking.ParkCar(new Car
            {
                ArrivingTime = DateTime.Now,
                Color = color,
                Model = model,
                Mark = mark
            });

            Console.WriteLine("\n \nParked Cars:");

            parking.PrintParkedCars();


            Console.ReadKey();
        }
    }
}