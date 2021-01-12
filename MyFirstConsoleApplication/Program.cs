using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = 'C';
            string name = "Chris";

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
