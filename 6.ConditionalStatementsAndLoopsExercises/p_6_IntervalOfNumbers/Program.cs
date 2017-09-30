using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_6_IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

            if (firstNum < lastNum)
            {
                for (int i = firstNum; i <= lastNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (firstNum > lastNum)
            {
                for (int i = lastNum; i <= firstNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
