using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrindaneshgah10
{
    class Program
    {
        static void Main(string[] args)
        {


            // متد محاسبه محیط مثلث
            static double Perimeter(double a, double b, double c)
            {
                return a + b + c;
            }

            // متد محاسبه مساحت مثلث (فرمول هرون)
            static double Area(double a, double b, double c)
            {
                double s = (a + b + c) / 2; // نصف محیط
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }

            static void Main()
            {
                Console.Write("Enter side a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter side b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter side c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double perimeter = Perimeter(a, b, c);
                double area = Area(a, b, c);

                Console.WriteLine("Perimeter of triangle = " + perimeter);
                Console.WriteLine("Area of triangle = " + area);

            }
        }
        
    }
   
}
