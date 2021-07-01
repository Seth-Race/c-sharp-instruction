using System;

namespace StudentRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Registration app!");
            Console.Write("Enter First Name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter Year of Birth: ");
            var year = Console.ReadLine();
            Console.Write("");
            Console.WriteLine("Welcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration is completed.");
            Console.WriteLine("Your temporary password is: " + firstName + "*" + year);







            Console.WriteLine("Goodbye, thanks for choosing this app!");
            
        }
    }
}
