using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> totalGuests = new HashSet<string>();

            while (input != "PARTY")
            {
                totalGuests.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (totalGuests.Contains(input))
                    totalGuests.Remove(input);

                input = Console.ReadLine();
            }

            if (totalGuests.Count > 0)
            {
                Console.WriteLine(totalGuests.Count);

                foreach (string guest in totalGuests)
                {
                    if (char.IsDigit(guest[0]))
                        Console.WriteLine(guest);
                }

                foreach (string guest in totalGuests)
                {
                    if (!char.IsDigit(guest[0]))
                        Console.WriteLine(guest);
                }

            }
            else
                Console.WriteLine(0);
        }
    }
}
