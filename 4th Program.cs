using System;

namespace testprogram4
{
    class Program
    {
        public static Boolean check(int x)
        {
            if(Math.Abs(100-x)<=10 || Math.Abs(200-x)<=10)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of X!");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(check(x));
        }
    }
}
