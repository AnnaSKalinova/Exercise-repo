using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_4_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = numOfPeople / capacity;
            int restOfPeople = numOfPeople % capacity;

            if (restOfPeople != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);          
        }
    }
}
