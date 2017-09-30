using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_3_RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string packageType = Console.ReadLine();

            string hall = "";
            double priceTotal = 0;

            if (groupSize <= 50)
            {
                priceTotal = 2500;
                Console.WriteLine("We can offer you the Small Hall");
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                priceTotal = 5000;
                Console.WriteLine("We can offer you the Terrace");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                priceTotal = 7500;
                Console.WriteLine("We can offer you the Great Hall");
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            if (priceTotal != 0) 
            {
                if (packageType.Equals("Normal"))
                {
                    priceTotal += 500;
                    priceTotal -= priceTotal * 0.05;
                    Console.WriteLine($"The price per person is {priceTotal / groupSize:F2}$");
                }
                else if (packageType.Equals("Gold"))
                {
                    priceTotal += 750;
                    priceTotal -= priceTotal * 0.10;
                    Console.WriteLine($"The price per person is {priceTotal / groupSize:F2}$");
                }
                else if (packageType.Equals("Platinum"))
                {
                    priceTotal += 1000;
                    priceTotal -= priceTotal * 0.15;
                    Console.WriteLine($"The price per person is {priceTotal / groupSize:F2}$");
                }
            }
        }
    }
}
