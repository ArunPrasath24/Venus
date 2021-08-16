using System;

namespace testprogram17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem,rev=0;
            Console.WriteLine("Enter the number to reverse");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev=rev*10+rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse of {0} is {1}",n,rev);
        }
    }
}
