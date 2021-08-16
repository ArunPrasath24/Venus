using System;

namespace testproject2
{
    class Program
    {
        public static int diff(int a)
        {
            int c;
            if(a>51)
            {
                c = (a - 51) * 3;
            }
            else
            {
                c = a - 51;
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N!");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("The Differnce is {0}",diff(N));
        }
    }
}
