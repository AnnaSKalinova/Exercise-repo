using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_8_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(number);
                sum += number;
                number += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
