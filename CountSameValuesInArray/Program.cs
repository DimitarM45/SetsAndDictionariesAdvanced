using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();

            Dictionary<double, int> numberTimes = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numberTimes.ContainsKey(number))
                    numberTimes.Add(number, 0);

                numberTimes[number]++;
            }

            foreach (var number in numberTimes)
                Console.WriteLine($"{number.Key} - {number.Value} times");
        }
    }
}
