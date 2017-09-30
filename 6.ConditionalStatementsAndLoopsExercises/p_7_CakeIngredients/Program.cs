using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_7_CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int count = 0;

            while (!ingredient.Equals("Bake!"))
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                count++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
