using System;

namespace Example1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            
            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"Subtracting {a} - {b} equals {SubtracNumbers(a,b)}");
        }

        public static int SubtracNumbers(int a, int b)
        {
            return a - b;
        }
        
    }
}