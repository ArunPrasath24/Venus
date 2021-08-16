using System;

namespace testprogram10
{
    class Program
    {
        public static int greater(int N1 , int N2 , int N3)
        {
            if(N1 >= N2 && N1 >= N3)
            {
                return N1;
            }
            else if(N2 >= N1 && N2 >= N3)
            {
                return N2;
            }
            return N3;
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Enter Number One");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number Two");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number Three");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("The Greatest Number is {0}",greater(a,b,c));
        }
    }
}
