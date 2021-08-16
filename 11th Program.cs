using System;

namespace testprogram11
{
    class Program
    {
        public static bool eligible(int M , int P , int C)
        {
            int Sum;
            if( M >= 65 && P >= 55 && C >= 50)
            {
                Sum = M + P + C;
                if (Sum >= 180)
                {
                    return true;
                }
                else if (M + P >= 140 || M + C >= 140 )
                {
                    return true;
                }
            }
            return false;
        } 
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
      L1:   Console.WriteLine("Enter Maths Mark");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics Mark");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemistry Mark");
            c = int.Parse(Console.ReadLine());
            if(eligible(a,b,c))
            {
                Console.WriteLine("You are Eligible For Admision");
            }
            else
            {
                Console.WriteLine("You are Not Eligible For Admision");
            }
            goto L1;
        }
    }
}
