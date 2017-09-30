using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_3_BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMin = minutes + 30;
         
            while (totalMin >= 60)
            {
                totalMin -= 60;
                hours++;
            }
            if (hours >= 23)
            {
                hours = 0;
            }
            if (totalMin < 10)
            {
                Console.WriteLine($"{hours}:0{totalMin}");
            }
            else
            {
                Console.WriteLine($"{hours}:{totalMin}");
            }
        }
    }
}
