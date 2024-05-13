using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> TotalCars { get; set; } = new List<Car>();

        public void PrintAvailableCars()
        {
            Console.WriteLine("List of available cars:");
            foreach (var car in TotalCars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
        }

        public static int _numberOfCars;

    }
}
