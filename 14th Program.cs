using System;

namespace testprogram14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int N;
            Console.WriteLine("Enter the Number ");
            N = int.Parse(Console.ReadLine());
            for (i = 1; i <= N; i++)
            {
                Console.WriteLine("cube of {0} is {1}",i,(i*i*i));
            }
        }
    }
}
