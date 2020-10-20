using System;
namespace app2
{    class Program
    {   static void Main(string[] args)
        {
            Console.Write("Enter one number: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int k; k=0;
            for(int i = 1; i <= num/2; i++)
            {
                if(num % i == 0)
                {  k++;
                }
            }
            if(k == 1)
            {
                Console.WriteLine("Number is a Prime number");
            }
            else
            {
                Console.WriteLine("Not a Prime number. Too bad");
            }
            Console.ReadLine();
        }
    }
}
