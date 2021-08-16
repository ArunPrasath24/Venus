using System;

namespace testprogram1
{
    class Program
    {
        public static int sum(int a, int b)
        {
            int c;
            if (a == b)
            {
                c = (a + b) * 3;
            }
            else
            {
                c = a + b; 
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter two integers");
            int n1= int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is {0}",sum(n1,n2));

        }

    }
}
