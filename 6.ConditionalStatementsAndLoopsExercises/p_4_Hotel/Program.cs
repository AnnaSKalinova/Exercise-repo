using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_4_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
           
            double studioPrice = 0;
            double doublePrice = 0;
            double suitPrice = 0;

            double totalStudioPrice = 0;
            double totalDoublePrice = 0;
            double totalSuitPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    if (nightsCount > 7)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    doublePrice = 65;
                    suitPrice = 75;
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    if (nightsCount > 14)
                    {
                        doublePrice -= doublePrice * 0.10;
                    }
                    suitPrice = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitPrice = 89;
                    if (nightsCount > 14)
                    {
                        suitPrice -= suitPrice * 0.15;
                    }
                    break;
            }
            if ((month.Equals("September") || month.Equals("October")) &&
                nightsCount > 7)
            {
                totalStudioPrice = studioPrice * (nightsCount - 1);
            }
            else
            {
                totalStudioPrice = studioPrice * nightsCount;
            }
            totalDoublePrice = doublePrice * nightsCount;
            totalSuitPrice = suitPrice * nightsCount;

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitPrice:F2} lv.");
        }
    }
}
