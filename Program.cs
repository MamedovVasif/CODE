

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.SADE OLUB OLMADIGINI TAPIR
            //int eded = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i < eded; i++)
            //{
            //    if (eded % i == 0)
            //    {
            //        count++;
            //    }

            //}
            //if (count <= 2)
            //{
            //    Console.WriteLine("sadedir");
            //}
            //else
            //{
            //    Console.WriteLine("sade deyil");
            //}






            //2.Verilmiş ədədin neçə mərtəbəli olduğunu print edən 

            //console app yazın.
            //int eded = Convert.ToInt32(Console.ReadLine());
            //int count=0;
            //while (eded > 9)
            //{
            //    eded = eded / 10;
            //    count++;
            //}
            //Console.WriteLine(count+1);





            //Verilmiş ədədin palindrom olub olmadığını print edən  console app yazın.

            int r;
            int cem = 0;
            int k;
            Console.Write("eded daxil edin");
            int n= Convert.ToInt32(Console.ReadLine());
            k = n;
            while (n > 0)
            {
                r = n % 10;
                cem = (cem * 10) + r;
                n = n / 10;
            }
            if (k == cem)
            {
                Console.Write("polindromdu");
            }
            else
            {
                Console.Write("polindrom deyil");
            }





        }
    }
}