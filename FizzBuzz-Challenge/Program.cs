using System;

namespace Challenge
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int answer = int.Parse(Console.ReadLine());
            FizzBuzz(answer);
            
        }

        public static void FizzBuzz(int answer)
        {
            if (answer % 3 == 0 && answer % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (answer % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (answer % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine($"{answer}");
            }
        }
    }
}
