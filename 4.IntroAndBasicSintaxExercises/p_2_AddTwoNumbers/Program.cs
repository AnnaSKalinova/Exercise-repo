using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_2_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
        
        }
    }
}
