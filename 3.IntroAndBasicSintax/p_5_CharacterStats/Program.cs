using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_5_CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            Console.Write($"{new string('|', currentHealth)}");
            Console.Write($"{new string('.', maxHealth - currentHealth)}");
            Console.WriteLine("|");
            Console.Write("Energy: |");
            Console.Write($"{new string('|', currentEnergy)}");
            Console.Write($"{new string('.', maxEnergy - currentEnergy)}");
            Console.WriteLine("|");
        }
    }
}
