using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_12_TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int currentNumber = 0;
            int totalSum = 0;
            int count = 0;
            
            for (int i = n; i >= 1; i--)
                {
                for (int j = 1; j <= m; j++)
                {
                   currentNumber = i * j * 3;
                   totalSum += currentNumber;
                   count++;
                   if (totalSum >= maxSum)
                   {
                      break;
                   }
                }
                if (totalSum >= maxSum)
                {
                    break;
                }
            }
            Console.WriteLine($"{count} combinations");
            if (totalSum >= maxSum)
            {
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else if (totalSum < maxSum)
            {
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
