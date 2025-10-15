using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin1_daneshghah
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter number");
            double r = double.Parse(Console.ReadLine());
            double mohit = 2 * 3.14 * r;
            double masahat = 3.14 * r * r;

            Console.WriteLine("mohit=" +mohit);
            Console.WriteLine("masahat=" +masahat);
            Console.ReadLine();

        }
    }
}
