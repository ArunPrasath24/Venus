using System;

namespace testprogram15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, j;
            Console.WriteLine("Enter table number starting from 1 : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplication table from 1 to {0}",n);
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= 10 ; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}",j,i,i*j);
                }
                Console.WriteLine("   ");
            }
        }
    }
}
