using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin8daneshgah
{
    class Program
    {
        static void Main(string[] args)
        {
                
                int even = 0, odd = 0;
                Console.WriteLine("ENTER 10 NUMBER:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"NUMBER {i}: ");
                    if (int.TryParse(Console.ReadLine(), out int n))
                    {
                        if (n % 2 == 0) even++;
                        else odd++;
                    }
                    else
                    {
                        Console.WriteLine("WRONG VALID ENTER again.");
                        i--; // تکرار همین اندیس
                    }
                }
                Console.WriteLine($"even is: {even}");
                Console.WriteLine($"odd is: {odd}");

               
        Console.ReadKey();
        }
    }
}
