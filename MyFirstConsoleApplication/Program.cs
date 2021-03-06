﻿using System;

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

            // let myInterpolatedString = `this stuff ${firstLetter}` is the JS way
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


            //decimals can be represented by [f]loat(32bit) [d]ouble(64bit) or deci[m]al(128bit)
            var adding = 1 + 1.1m;
            double doubleNum = 2.2;
            var division = 3 / 2d;


            var implicitStringThing = "this is an implicitly typed variable.";

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            //instantiation 
            var bestYear = new DateTime(2020, 01, 01);

            object person = new { Name = "Chris" };

            //anonymous type, new object
            var newPerson = new { 
                Name = "Chris",
                LastName = "LoJacono"
            };
            Console.WriteLine(newPerson);

            //everything either is or can be an object
            object weirdStuff = 1234;
            weirdStuff = "More Craziness.";

            Console.WriteLine(weirdStuff);

            // ARRAYS
            var names = new string[5];

            var secondName = names[1];
            names[1] = "Jimmy";

            var colors = new string[] { "white", "blue", "yellow", "purple", "orange", "teal" };


            // CONTROL FLOW
            if (input == "Chris")
            {
                Console.WriteLine("Duhhh");
            }
            else if (input == "Bobby")
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Not Chris!!");
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"currently for looping on number {i}");
            }
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"currently for looping on color {colors[i]}");
            }


            var counter = 1;
            while (true)
            {
                
                Console.WriteLine($"While loop iteration {counter}.");

                if (counter <= 5)
                {
                    counter++;
                    continue;
                }
                    

                break;
            }


            //These are more preferred in C#

            foreach (var color in colors)
            {
                Console.WriteLine($"ForEach looping on color {color}");
            }


            var counter = 1;
            while (true)
            {
                
                Console.WriteLine($"While loop iteration {counter}.");

                if (counter <= 5)
                {
                    counter++;
                    continue;
                }
                    

                break;
            }


            //These are more preferred in C#

            foreach (var color in colors)
            {
                Console.WriteLine($"ForEach looping on color {color}");
            }





            //DEFAULT VALUES

            //value of 0
            int myNumber;

            //value of false
            bool myBool;

            //default value is null
            string myName;


            // null conditional access operator
            nyName?.ToString();

            // null coalescing operator
            myName = name ?? "Nathan";

            //marking value types as nullable
            bool? nullBool;

            //.NET way
            Nullable<bool> nullyBool;

        }
    }
}
