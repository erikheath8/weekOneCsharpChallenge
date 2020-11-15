using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace weekOneChallenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // name variable declaration
            string firstName = "Erik";
            string lastName = "Heath";
            int age = 35;

            string[] movieArray = { "Red Dawn", "Star Wars", "Ready Player One", "Heat" };

            
            // adding date and time
            DateTime currentDate = Convert.ToDateTime(DateTime.Now);

            Console.WriteLine("Current Date and Time is: " + currentDate);

            List<DateTime> dates = new List<DateTime>();

            dates.Add(currentDate);

            Console.WriteLine("Number of dates in List: " + dates.Count);

            foreach (DateTime i in dates)
            {
                Console.WriteLine("Date and Time in List: " + i);
            }

            //Numeric Operator Age Operations
            // age + 7
            int plusAge = 35 + 7;
            Console.WriteLine("Age + 7 = " + plusAge);
            // age - 7
            int minusAge = 35 - 7;
            Console.WriteLine("Age - 7 = " + minusAge);
            // age * 7
            int multAge = 35 * 7;
            Console.WriteLine("Age * 7 = " + multAge);
            // age divided by 7
            int divAge = 35 / 7;
            Console.WriteLine("Age / 7 = " + divAge);
            // age modulus by 7
            int modAge = 35 % 7;
            Console.WriteLine("Age % 7 = " + modAge);


            // number hours of sleep
            int hoursSleep = 8;

            if (hoursSleep >= 10)
                Console.WriteLine("Wow that's a lot of sleep!");
            else if (hoursSleep >= 8 && hoursSleep < 10)
                Console.WriteLine("You should be pretty rested.");
            else if (hoursSleep > 4 && hoursSleep < 8)
                Console.WriteLine("Bummer!");
            else
                Console.WriteLine("Oh man, get some sleep!");


            // variable and switch statement for the user's day

            /* Console.WriteLine("What kind of day are you having: Great, Good, Okay, Bad, :( ");
            Console.WriteLine("Please enter your Selection:  ");
            string userDay = Console.ReadLine(); */

            string userDay = "Good";

            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Having a Great Day!");
                    break;
                case "Good":
                    Console.WriteLine("Having a Good Day!");
                    break;
                case "Okay":
                    Console.WriteLine("Just having an 'Okay' day. Hang in there!");
                    break;
                case "Bad":
                    Console.WriteLine("Sorry you are having a Bad day!");
                    break;
                case ":(":
                    Console.WriteLine("Sorry you are having a sad smiley face day!");
                    break;
                default:
                    Console.WriteLine("That is NOT a Selection Choice. Have a Great Day!");
                    break;
            }

        }
    }
}
