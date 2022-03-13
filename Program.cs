using System;

namespace Практическая_13_вариант_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите первое число");
            int a =  Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            var mc = new Program();
            Console.WriteLine(mc.gcd03(a,b));
            
        }


        int gcd03(int a, int b)
        {

            int nod = 1;

            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            while (a > 1L && b > 1L)
            {
                for (int i = 2; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        nod *= i;
                        a /= i;
                        b /= i;
                        break;
                    }
                    if (a % i == 0)
                    {
                        a /= i;
                        break;
                    }
                    if (b % i == 0)
                    {
                        b /= i;
                        break;
                    }
                }
            }
            return nod;
        }
    }
}
