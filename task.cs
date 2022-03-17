using System;

namespace NewConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(70, 20,3));
        }
        
        
   
        static int CalculateArea(int radius)
        {
            if (radius > 0)
            {
                int sahe = 3 * radius * radius;

                return sahe;
            }
            else return -1;

        }
        static int CalculateArea(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                int sahe = a * b;

                return sahe;
            }
            else return -1;
        }

        static int CalculateArea(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                int sahe = 2 * (a * b + a * c + b * c);

                return sahe;
            }
            else return -1;
        }
    }
}

