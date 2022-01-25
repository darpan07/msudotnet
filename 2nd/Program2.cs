using System;

namespace Code_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            if(a + b > 10) {
                Console.WriteLine("This answer is greater than 10. ");
            } else {
                Console.WriteLine("This answer is greater than 10. ");
            }

            Pro_2.complexIf(a,b,c);

            // loops

            int counter = 0;

            Pro_2.whileLoop(counter);
            Pro_2.doWhileLoop(counter);
            Pro_2.forLoop();
            Pro_2.nestLoops();
            Pro_2.challenge1();

        }
    }

    static class Pro_2 {

        public static void complexIf(int a, int b, int c) {

            Console.WriteLine("Output of complexIf...");

            if ((a + b + c > 10) && (a == b)) {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b)) {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }

        public static void whileLoop(int counter) {

            Console.WriteLine("Output of whileLoop...");

            while(counter < 5) {
                Console.WriteLine($"Hello World! USING While Loop The counter is {counter}");
                counter++;
            }
        }
        public static void doWhileLoop(int counter) {

            Console.WriteLine("Output of dowWhileLoop...");

            do {
                Console.WriteLine($"Hello World! USING Do While Loop The counter is {counter}");
                counter++;
            } while(counter < 5);
        }
        public static void forLoop() {

            Console.WriteLine("Output of forLoop...");

            for(int counter = 0; counter < 10; counter++) {
                Console.WriteLine($"Hello World! USING For Loop The counter is {counter}");
            }
        }
        public static void nestLoops() {

            Console.WriteLine("Output of nestLoops...");

            for (int row = 1; row < 11; row++) {
                for (char column = 'a'; column < 'k'; column++) {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }
        public static void challenge1() {

            Console.WriteLine("Output of challenge1...");

            int sum = 0;
            for (int number = 1; number <= 20; number++) {
                if (number % 3 == 0) {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
