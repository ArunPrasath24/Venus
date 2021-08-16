using System;

namespace testprogram9
{
    class Program
    {
        public static int value(int M)
        {
            if(M>0)
            {
                return 1;
            }
            else if(M==0)
            {
                return 0;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter Value of M");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("The Value Of N is {0}",value(a));
        }
    }
}
