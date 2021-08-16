using System;

namespace testprogram8
{
    class Program
    {
        public static bool vote(int age)
        {
            if(age>=18)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter Your Age!");
            a = int.Parse(Console.ReadLine());
            if(vote(a))
            {
                Console.WriteLine("You Can Caste Your Vote !");
            }
            else
            {
                Console.WriteLine("You are Not eligible to Vote!");
            }
        }
    }
}
