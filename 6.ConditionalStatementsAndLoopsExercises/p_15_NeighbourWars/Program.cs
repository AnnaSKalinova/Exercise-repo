using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_15_NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoSDamage = int.Parse(Console.ReadLine());
            int goshoSDamage = int.Parse(Console.ReadLine());

            int peshoSHealth = 100;
            int goshoSHealth = 100;

            int countRound = 0;

            for (int i = 1; i < 999999999; i++)
            {
                countRound ++;
                if (i % 2 != 0)
                {
                goshoSHealth -= peshoSDamage;
                    if (goshoSHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced " +
                    $"Gosho to {goshoSHealth} health.");
                }
                else if (i % 2 == 0)
                {
                    peshoSHealth -= goshoSDamage;
                    if (peshoSHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced " +
                    $"Pesho to {peshoSHealth} health.");
                }
                if (i % 3 == 0)
                {
                    peshoSHealth += 10;
                    goshoSHealth += 10;
                }
            }
            if (goshoSHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {countRound}th round.");
            }
            else if (peshoSHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {countRound}th round.");
            }
        }
    }
}
