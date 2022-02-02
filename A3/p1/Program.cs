using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Numerator : ");
            int num = int.Parse(Console.ReadLine() ?? throw new Exception());

            Console.Write("Please Enter Denominator : ");
            int deno = int.Parse(Console.ReadLine() ?? throw new Exception());

            int q = num / deno;
            int r = num % deno;
            double f = (float)num / (float)deno;

            //For Rounding double digits
            f = Math.Round(f, 2);

            Console.WriteLine($"Intger division result : {q} with remainder {r}");
            Console.WriteLine($"Floating point division result : {f}");
            Console.WriteLine($"The result of mixed fraction : {q} {r}/{deno}");


        }
    }

}
