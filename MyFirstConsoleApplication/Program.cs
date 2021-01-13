using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color?");
            var input = Console.ReadLine();

            // String things
            char firstLetter = 'C';
            string name = "Chris";

            // let myInterpolatedString = `this stuff ${firstLetter}`
            var myInterpolatedString = $"My name is {name} and the " +
                                       $"first letter is {firstLetter}";
            var stringLiteral = @"This is a paragraph.
                                  It is across multiple lines!!";

            Console.WriteLine(stringLiteral);
            //Number Types
            int number = Int32.MaxValue;
            long bigNumber = Int64.MaxValue;
            short littleNumber = Int16.MaxValue;

            Console.WriteLine(bigNumber);
            Console.WriteLine(littleNumber);

            var implicitStringThing = "this is an implicitly typed variable.";

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            //instantiation 
            var bestYear = new DateTime(2020, 01, 01);

            object person = new { Name = "Chris" };

            //anonymous typpe, new object
            var newPerson = new { 
                Name = "Chris",
                LastName = "LoJacono"
            };
            Console.WriteLine(newPerson);

            //everything either is or can be an object
            object weirdStuff = 1234;
            weirdStuff = "More Craziness.";

            Console.WriteLine(weirdStuff);


        }
    }
}
