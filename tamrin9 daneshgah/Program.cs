using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin9_daneshgah
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = new List<int>();
            Console.WriteLine("enter 5 number");
            for (int a = 1; a <= 5; a++)
            {
                Console.Write($"enter number {a}: ");
                int b = int.Parse(Console.ReadLine());
                if (b == 2)
                {
                    n.Add(a);
                }
            }
            if (n.Count == 0)
            {
                Console.WriteLine("No number = 2");
            }
            else
            {
                Console.WriteLine(n.Count + " number = 2");
                for (int i = 0; i < n.Count; i++)
                {
                    Console.WriteLine($"number : " + n[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
