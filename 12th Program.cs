using System;

namespace testprogram12
{
    class Program
    {
        public int total(int a , int b , int c)
        {
            int total;
            total = a + b + c;
            return total;
        }
        public int percent(int total )
        {
            int percentage;
            percentage = total / 3;
            return percentage;
        }
        public string division(double percentage)
        {
            string c1 = "1st division";
            string c2 = "2nd division";
            string c3 = "3rd division";
            string c4 ="Fail";
            if (percentage >= 45)
            {
                if (percentage >= 60)
                {
                    if (percentage >= 80)
                    {
                        return c1;
                    }
                    return c2;
                }
                return c3;
            }
            return c4;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Roll NO");
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            string N = Console.ReadLine();
            Console.WriteLine("Enter Sub1 Mark :");
            int S1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Sub2 Mark :");
            int S2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Sub3 Mark :");
            int S3 = int.Parse(Console.ReadLine());

            int total;
            int percent;
            String div;
            var obj = new Program();
            total = obj.total(S1, S2, S3);
            percent = obj.percent(total);
            div = obj.division(percent);

            Console.WriteLine(" Name |   RollNo |    Total |     Percentage |   Division | ");
            Console.WriteLine("------   --------    -------     ------------   ----------");
            Console.WriteLine("  {0} |     {1}  |     {2}  |        {3}     |      {4}   | ", N, R, total, percent, div);
        }
    }
}
