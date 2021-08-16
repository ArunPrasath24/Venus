using System;

namespace testprogram16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("enter the tringle size");
            n = int.Parse(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                for(j=1; j<=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
