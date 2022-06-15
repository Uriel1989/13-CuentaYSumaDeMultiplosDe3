using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_CuentaYSumaDeMultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a, b;
            a = 0;
            b = 0;
            for (i = 0; i <= 100; i++)
            {

                if (i % 3 == 0)
                {
                    Console.WriteLine("Los multiplos de 3 son " + i);
                    b = b + i;
                }

            }
            Console.WriteLine("La suma total da: " + b);

            Console.ReadKey();
        }
    }
}
