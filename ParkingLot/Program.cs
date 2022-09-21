using System;
using System.Linq;
using System.Collections.Generic;

namespace ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            HashSet<string> cars = new HashSet<string>();

            while (input[0] != "END")
            {
                string direction = input[0];
                string carNumber = input[1];

                if (direction == "IN")
                    cars.Add(carNumber);

                else
                    cars.Remove(carNumber);

                input = Console.ReadLine().Split(", ");
            }

            if (cars.Count == 0)
                Console.WriteLine("Parking Lot is Empty");

            else
            {
                foreach (string car in cars)
                    Console.WriteLine(car);
            }
        }
    }
}
