using System;

namespace testprogram6
{
    class Program
    {
        public static Boolean array(int[] ar,int size)
        {
            int i;
            for(i=0;i<size;i++)
            {
                if(ar[i]==1 && ar[i+1]==2 && ar[i+2]==3)
                {
                    return true;
                }
              
            }
            return false;
        }
        
        static void Main(string[] args)
        {
            int i;
            int s;
            Console.WriteLine("Enter the array size");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter {0} integers for array",s);
            for (i=0; i<s; i++)
            {
                Console.WriteLine("Enter {0} integer",i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the values in array is ");
            Console.WriteLine(string.Join("  ",arr));
            Console.Read();
            Console.WriteLine("the sequence of 1 2 3 is available== {0}",array( arr,s));

            
        }
    }
}
