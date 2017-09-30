using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_13_MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char magicalLetter = char.Parse(Console.ReadLine());

            string result = "";

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        //if (i != magicalLetter && j != magicalLetter && 
                        //    k != magicalLetter)
                        //{
                        //    Console.Write($"{i}{j}{k} ");
                        //}
                        result = $"{i}{j}{k} ";
                        if (!result.Contains(magicalLetter))
                        {
                            Console.Write(result);
                        }
                    }
                }
            }
        }
    }
}
