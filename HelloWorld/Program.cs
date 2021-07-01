using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("abc abc abc");

            Console.WriteLine("Hello World!");


            String firstName = "Bob";
            string lastName = "Smith";


            int n1 = 5;
            int n2 = 7;

            int sum = n1 + n2;
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(sum);


            //p.47 var iden
            var name1 = "Sam Brown";
            /*
             * multiline comment
             */

            int n3 = 1;
            double n4 = 0.5;

            Console.WriteLine("What's ya name?");
            String name2 = Console.ReadLine();
            Console.WriteLine("Hello " + name2);

            String choice = "y";
            while (choice.Equals"y"){
                Console.WriteLine("Continue? Y/N");
                choice = Console.ReadLine();
            }

            if (sum>10)
            {
                Console.WriteLine(">10");
            } else
            {
                Console.WriteLine("<10");
            }

           

        }
    }
}