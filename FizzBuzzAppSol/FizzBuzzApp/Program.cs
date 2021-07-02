using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz.");
            for (var i = 1; i <= 30; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FIZZBUZZ");
                } else if (i % 3 == 0 && i % 5 != 0) {
                    Console.WriteLine("FIZZ");
                } else if (i % 3 != 0 && i % 5 == 0) {
                    Console.WriteLine("BUZZ");
                } else {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Thank you for using the app. Goodbye.");
        }
    }
}
