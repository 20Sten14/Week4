using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string ops;

            Console.WriteLine("\t\t\tConsole Calculator Tutorial in C#\r");
            Console.WriteLine("\t\t\t----------------------------------r");

            Console.WriteLine("\t\t\tEnter first number\n");
            firstnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an Operator: +, -,*,/,%)\n");
            ops = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter second number\n");
            secondnum = Double.Parse("\t\t\t" + Console.ReadLine());

            if (ops == "+")
            {
                answer = firstnum + secondnum;
                Console.Write("\n" + answer);
            }
            if (ops == "-")
            {
                answer = firstnum - secondnum;
                Console.Write("\n" + answer);
            }
            if (ops == "*")
            {
                answer = firstnum * secondnum;
                Console.Write("\n" + answer);
            }
            if (ops == "/")
            {
                answer = firstnum / secondnum;
                Console.Write("\n" + answer);
            }
            if (ops == "%")
            {
                answer = firstnum % secondnum;
                Console.Write("\n" +answer);
            }

            Console.Write("\n" + "Press an key to exit... ");
            Console.ReadKey(); 

        }
    }
}
