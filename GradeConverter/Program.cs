using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grade converter app!");
            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter numerical grade: ");
                int numGrade = Convert.ToInt32(Console.ReadLine());
                var letterGrade = "F";
                if (numGrade >= 88)
                {
                    letterGrade = "A";
                }
                else if (numGrade >= 80)
                {
                    letterGrade = "B";
                }
                else if (numGrade >= 67)
                {
                    letterGrade = "C";
                }
                Console.WriteLine("Letter Grade: " + letterGrade);

                Console.Write("Continue? y/n: ");
                choice = Console.ReadLine();

            }



                Console.WriteLine("Thanks for using the app!");
            
        }
    }
}
