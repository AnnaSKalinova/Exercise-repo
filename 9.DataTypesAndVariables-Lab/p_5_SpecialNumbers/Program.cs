using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_5_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numer = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 1; i <= numer; i++)
            {
                if (IsSpecial(i))
                {
                    result = "True";
                }
                else
                {
                    result = "False";
                }
                Console.WriteLine($"{i} -> {result}");
            }
        }
        static bool IsSpecial(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum == 5 || sum == 7 || sum == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
