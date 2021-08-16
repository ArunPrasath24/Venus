using System;

namespace testprogram13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the End (N) of Natural Number!");
            int N = int.Parse(Console.ReadLine());
            int i;
            int sum =0;
            Console.WriteLine("The N natural  number is");
            for(i = 1 ;i <= N ; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("The Sum of Natural Numbers is {0}",sum);
        }
    }
}
