using System;

namespace CakeMakeing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cookies wide is the cake?");
            int CWide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cookies in lenght is the cake?");
            int CLong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many layers does the cake have?");
            int CLayer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cookies in a pack of cookies?");
            int Cpack = Convert.ToInt32(Console.ReadLine());
            int CArea = CLong * CWide;
            int CALL = CLayer * CArea;
            int CPALL = Convert.ToInt32(Math.Round((double)CALL / Cpack));
                Console.WriteLine($"you need {CPALL} packs of cookies");
        }
    }
    
}
