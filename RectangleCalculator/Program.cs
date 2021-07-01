using System;

namespace RectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimiter Calculator");
            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                int area = length * width;
                int perimeter = (length * 2) + (width * 2);
                Console.WriteLine("Area:   " + area);
                Console.WriteLine("Perimeter:   " + perimeter);

                Console.Write("Continue? y/n: ");
                choice = Console.ReadLine();
            }



            Console.WriteLine("Thanks for using it!");
        }
    }
}
