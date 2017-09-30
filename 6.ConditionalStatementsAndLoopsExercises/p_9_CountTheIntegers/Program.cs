using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_9_CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                int number = int.Parse(Console.ReadLine());
                
                while (true)
                {
                    count++;
                    number = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {
            }
            Console.WriteLine(count);
        }
    }
}
