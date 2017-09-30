﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_10_MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
            else if (multiplier > 10)
            {
                Console.WriteLine($"{number} X {multiplier} =" +
                        $" {number * multiplier}");
            }
        }
    }
}
