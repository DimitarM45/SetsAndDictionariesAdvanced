using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (input[0] != "Revision")
            {
                string shopName = input[0];
                string productName = input[1];

                double productPrice = double.Parse(input[2]);

                if (!shops.ContainsKey(shopName))
                    shops.Add(shopName, new Dictionary<string, double>());

                shops[shopName].Add(productName, productPrice);

                input = Console.ReadLine().Split(", ");
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}
