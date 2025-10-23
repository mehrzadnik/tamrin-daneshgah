using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin4_daneshgah
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("enter your number:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 7 == 0) 
            {
                Console.Write("yes!");
            }
             else
            {
                a = a * 3;
                Console.Write($"result is:{a}");
            }

            Console.ReadKey();
        }
    }
}
