using System;

namespace testprogram5
{
    class Program
    {
        public static int largest(int a , int b)
        {
            if (a > b)
            {
                if ((a) >= 20 && (a) <= 30)
                {
                    return a;
                }
            }
            else
            {
                if ((b) >= 20 && (b) <= 30)
                {
                    return b;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter two integers!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(largest(a,b));
        }
    }
}
