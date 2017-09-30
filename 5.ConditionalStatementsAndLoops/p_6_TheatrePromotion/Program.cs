using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_6_TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            decimal ticketPrice = 0;

            if (age >= 0 && age <= 18)
            {
                if (typeOfDay.Equals("Weekday"))
                {
                    ticketPrice = 12;
                }
                else if (typeOfDay.Equals("Weekend"))
                {
                    ticketPrice = 15;
                }
                else if (typeOfDay.Equals("Holiday"))
                {
                    ticketPrice = 5;
                }
            } else if (age > 18 && age <= 64)
            {
                if (typeOfDay.Equals("Weekday"))
                {
                    ticketPrice = 18;
                }
                else if (typeOfDay.Equals("Weekend"))
                {
                    ticketPrice = 20;
                }
                else if (typeOfDay.Equals("Holiday"))
                {
                    ticketPrice = 12;
                }
            } else if (age > 64 && age <= 122)
            {
                if (typeOfDay.Equals("Weekday"))
                {
                    ticketPrice = 12;
                }
                else if (typeOfDay.Equals("Weekend"))
                {
                    ticketPrice = 15;
                }
                else if (typeOfDay.Equals("Holiday"))
                {
                    ticketPrice = 10;
                }
            }
            if (ticketPrice != 0)
            {
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
