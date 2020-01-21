using System;
namespace hwapp
{
    class Program
    {
        //int results
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello "+ args[0]+"!" + " from outside the loop!");
            for (int i=0; i< args.Length; i++)
            {
              Console.WriteLine("Hello "+ args[i]+"!");
            }

            p.sum(4,6);
            p.divide(3.0, 3.0);
        }

        public void sum(int a, int b)
        {
          int result;
          result = a + b;
          string str = "Result:"+ result;
          Console.WriteLine(str);
        }

        public void divide(double a, double b)
        {
          double result;
          sum((int)a, (int)b);
          result = b / a;
          string str = "Result:"+ result;
          Console.WriteLine(str);
        }
    }
}
