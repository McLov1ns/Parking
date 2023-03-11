using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Park
    {
        public List<Car> ParkedCars { get; set; }

        public void PrintParkedCars()
        {
            ParkedCars.ForEach(p =>
            {
                Console.WriteLine($"{p.Mark} {p.Model} {p.Color} arrived at {p.ArrivingTime.ToShortDateString()}");
            });
        }

        public void ParkCar(Car car)
        {
            ParkedCars.Add(car);
        }
    }
}
