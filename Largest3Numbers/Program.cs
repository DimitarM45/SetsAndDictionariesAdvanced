using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            numbers = numbers
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
