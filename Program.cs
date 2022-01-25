using System;

namespace Code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int b = 22;
            int c = 23;
            int d = 24;

            double e = 5;
            double f = 4;
            double g = 2;

            decimal h = 1.0M;
            decimal i = 3.0M;

            Pro_1.add(a,b);
            Pro_1.sub(a,b);
            Pro_1.mul(a,b);
            Pro_1.div(a,b);
            Pro_1.complex(a,b,c);
            Pro_1.complex2(a,b,c,d);
            Pro_1.findMinMax();
            Pro_1.dbAdd(e,f,g);
            Pro_1.findMinMaxDb();
            Pro_1.findMinMaxDec();
            Pro_1.decOp(h,i);

            double radius = 5;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area : {area}");
        }

        
    }

    static class Pro_1 {

        public static void add(int a, int b) {
            
            Console.WriteLine("Output of Addition");
            int c = a + b;
            Console.WriteLine(c);
        } 
        public static void sub(int a, int b) {

            Console.WriteLine("Output of Substraction");
            int d = a - b;
            Console.WriteLine(d);
        } 
        public static void mul(int a, int b) {

            Console.WriteLine("Output of Multiplication");
            int e = a * b;
            Console.WriteLine(e);
        } 
        public static void div(int a, int b) {

            Console.WriteLine("Output of Division");
            int f = a / b;
            Console.WriteLine(f);
        } 

        public static void complex(int a, int b, int c) {

            Console.WriteLine("Output of complex...");
            int g = a + b * c;
            Console.WriteLine(g);
        }

        public static void complex2(int a, int b, int c, int d) {

            Console.WriteLine("Output of complex2...");
            int e = (a + b) / c;
            int f = (a + b) % c;

            Console.WriteLine($"quotient : {e}");
            Console.WriteLine($"remainder : {f}");
        }

        public static void findMinMax() {

            Console.WriteLine("Output of findMinMax...");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
        }

        public static void dbAdd(double a, double b, double c) {

            Console.WriteLine("Output of dbAdd...");
            double d = (a + b) / c;
            Console.WriteLine(d); 
        }

        public static void findMinMaxDb() {

            Console.WriteLine("Output of findMinMaxDb...");
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
        }

        public static void findMinMaxDec() {

            Console.WriteLine("Output of findMinMaxDec...");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
        }

        public static void decOp(decimal a, decimal b) {

            Console.WriteLine("Output of decOp...");
            Console.WriteLine(a / b);
        }
    }
}
