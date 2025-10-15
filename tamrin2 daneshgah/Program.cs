using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin2_daneshgah
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter temperature=");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine("temperature=" + f);
            Console.ReadLine();

        }
    }
}
