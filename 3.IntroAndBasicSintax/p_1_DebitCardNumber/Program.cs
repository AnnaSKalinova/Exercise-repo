using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_1_DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDigits = int.Parse(Console.ReadLine());
            var secondDigits = int.Parse(Console.ReadLine());
            var thirdDigits = int.Parse(Console.ReadLine());
            var fourthDigits = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstDigits:D4} {secondDigits:D4} " +
                $"{thirdDigits:D4} {fourthDigits:D4}");
        }
    }
}
