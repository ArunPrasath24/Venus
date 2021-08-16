using System;

namespace testprogram3
{
    class Program
    {
        public static Boolean check(int a, int b)
        {
            int sum;
            sum = a + b;
            if((a==30) || (b==30) || (sum==30))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Values");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(check(a,b));
        }
    }
}
