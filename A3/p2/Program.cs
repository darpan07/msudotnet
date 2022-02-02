using System;

namespace Program
{
    class StringManipulation
    {

        public static void Main(String[] args)
        {

            //length of string
            Console.WriteLine("1. Enter any String : - ");
            string str = Console.ReadLine() ?? throw new Exception();

            int len = str.Length;
            Console.WriteLine($"The length of string {str} is {len} .");

            //find type of sentence
            Console.WriteLine("2. Enter Sentence :- ");
            string sentence = Console.ReadLine() ?? throw new Exception();
            StringManipulation.checkSentence(sentence);

            //first and last name
            Console.WriteLine("3. Enter Your Full Name : ");
            string name = Console.ReadLine() ?? throw new Exception();

            int space = name.IndexOf(" ");

            string fname = name.Substring(0, space);
            string lname = name.Substring(space);

            Console.WriteLine($"{lname} , {fname}");
        }

        public static void checkSentence(string s)
        {

            if (s.EndsWith("."))
                Console.WriteLine("Above Sentence Is Declarative ");

            else if (s.EndsWith("?"))
                Console.WriteLine("Above Sentence Is Interogatory ");

            else if (s.EndsWith("!"))
                Console.WriteLine("Above Sentence Is Exclaimatory ");

            else
                Console.WriteLine("Above Sentence Is Something else ");

        }

    }

}
