using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_2_ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;

            switch (profession)
            {
                case "Athlete":
                    price = quantity * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = quantity * 1;
                    break;
                case "SoftUni Student":
                    price = quantity * 1.7;
                    break;
                default:
                    price = quantity * 1.2;
                    break;                
            }
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}
