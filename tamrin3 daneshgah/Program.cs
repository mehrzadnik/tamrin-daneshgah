using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin3_daneshgah
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("enter your number:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a < 10 && a%2==0)
            {
                Console.Write("TRUE!");
            }
            else
            {
                Console.Write("Your number is greater than 10 or its an  odd number :(");
            }
            Console.ReadKey();
        }
    }
}
