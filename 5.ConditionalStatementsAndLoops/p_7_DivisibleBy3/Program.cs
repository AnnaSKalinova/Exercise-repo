using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_7_DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 3; i <= 100; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
