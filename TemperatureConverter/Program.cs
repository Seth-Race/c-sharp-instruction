using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temp converter!");
            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter degrees in Fahrenheit: ");
                double fTemp = Convert.ToDouble(Console.ReadLine());
                double cTemp = (fTemp - 32) * 5 / 9;
                double roundC = Math.Round(cTemp, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("Degrees in Celsius:  " + roundC);







                Console.WriteLine("Continue? y/n: ");
                choice = Console.ReadLine();

            }







            Console.WriteLine("Thanks for using it!");
        }
    }
}
