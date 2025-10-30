using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin7_daneshgah
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, sum = 1;
            Console.Write("enter your number:");
            a = Convert.ToInt32(Console.ReadLine());

            while(a!=0)
            {
                sum *= a;
                Console.Write("enter your number:");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("sum:{0}", sum);
            Console.ReadKey();
        }
    }
}
