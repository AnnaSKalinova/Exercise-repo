using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_13_GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());

            int count = 0;
            int i = 0;
            int j = 0;

            for (i = m; i >= n; i--)
            {
                for (j = n; j <= m; j++)
                {
                    count++;
                    if (i + j == magicalNum)
                    {
                        break;
                    }
                }
                if (i + j == magicalNum)
                {
                    break;
                }
            }
            if (i + j == magicalNum)
            {
                Console.WriteLine($"Number found! {i} + {j} = {magicalNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicalNum}");
            }
        }
    }
}
