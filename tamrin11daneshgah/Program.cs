using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin11daneshgah
{
    class Program
    {
        static void Main(string[] args)
        {
            // تابع بازگشتی برای ضرب دو عدد
            static int Multiply(int a, int b)
            {
                // اگر یکی از اعداد صفر باشد
                if (b == 0)
                    return 0;

                // اگر b منفی باشد
                if (b < 0)
                    return -Multiply(a, -b);

                // حالت بازگشتی (a + a + ... b بار)
                return a + Multiply(a, b - 1);
            }

            static void Main()
            {
                Console.Write("Enter number a: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number b: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = Multiply(a, b);

                Console.WriteLine("Multiplication Result = " + result);
            }
        }
    }
    
}
