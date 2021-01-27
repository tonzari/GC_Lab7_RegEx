using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GC_Lab7_RegEx
{
    class Program
    {
        // GC Lab 7 Regular Expressions
        // Antonio Manzari

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name: ");

            if (IsValidName(Console.ReadLine()))
            {
                Console.WriteLine($"Nice name ya got there. It's valid.");
            }
            else
            {
                Console.WriteLine("Invalid name! Oh well. Let's move on.");
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Please enter a valid email: ");

            if (IsValidEmail(Console.ReadLine()))
            {
                Console.WriteLine($"Nice email ya got there. It's valid.");
            }
            else
            {
                Console.WriteLine("Invalid email! Bummer. Let's move on.");
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Please enter a valid phone number: ");

            if (IsValidPhoneNumber(Console.ReadLine()))
            {
                Console.WriteLine($"Nice number ya got there. It's valid.");
            }
            else
            {
                Console.WriteLine("Invalid phone number! Sad. Let's move on.");
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Please enter a valid date: ");

            if (IsValidDate(Console.ReadLine()))
            {
                Console.WriteLine($"Nice date ya got there. It's valid.");
            }
            else
            {
                Console.WriteLine("Invalid date! This isn't going well. Let's just quit.");
            }
        }

        #region METHODS
       
        public static bool IsValidName(string userName)
        {
            // This was very challenging to allow for multiple names, hyphens, apostrophes, etc.
            // I think namePattern4 is the closest to what the assignment literally asks for, which doesn't mention including a first AND last name.

            string namePattern = @"^[A-Z]+[a-zA-Z]+(?:(?:\. |[' -])[a-zA-Z]+)*$";               // This didn't like the first name L'oreal. Hmm. 
            string namePattern2 = @"^[A-Z]+[A-Za-z\'\s\.\,]+$";                                       // Doesn't like hyphenated last name.
            string namePattern3 = @"^[A-Z]+[A-Za-z][A-Za-z\'\-]+([\ A-Za-z][A-Za-z\'\-]+)*";    // Doesn't like the first name Su.
            string namePattern4 = @"^[A-Z]+[A-z]{1,29}$";                                       // For the assignment, this handles a single name, under 30 chars

            return Regex.IsMatch(userName, namePattern2);

        }

        public static bool IsValidPhoneNumber(string userPhoneNumber)
        {
            string phonePattern = @"^\d{3}-\d{3}-\d{4}$";

            return Regex.IsMatch(userPhoneNumber, phonePattern);
        }

        public static bool IsValidEmail(string userEmail)
        {
            string emailPattern = @"^[A-z0-9]{5,30}[@][A-z0-9]{5,10}[.][A-z]{2,3}$";

            return Regex.IsMatch(userEmail, emailPattern) ;
        }

        public static bool IsValidDate(string userDate)
        {
            string datePattern = @"^\d{1,2}/\d{1,2}/\d{4}$";

            return Regex.IsMatch(userDate, datePattern);
        }

        #endregion

        #region TESTS

        private static void RunTestIsValidDate()
        {
            List<string> dateTestList = new List<string>
            {
                "aa/aa/aaaa",
                "99/99/9999",
                "12/12/1212",
                "00/00/0000",
                "12.12.1231",
                "30/30/1922"
            };

            foreach (var date in dateTestList)
            {
                Console.WriteLine($"{date}: {IsValidDate(date)}");
            }
        }

        private static void RunTestIsValidName()
        {
            List<string> nameTestList = new List<string>
            {
                "Antonio Manzari",
                "Timmy McDougle",
                "Bryan O'doodle",
                "Su Hyn",
                "Mariana Isabela Garcia-Hernandez",
                "Dao D'sani",
                "Aubertis Contigus",
                "David Rothmobble Jr.",
                "Hank Hill",
                "L'oreal Divine",
                "bobby",
                "Hammond",
                "'asdj",
                "Anmm Ak8",
                "Mansndsnsdj Mansdj nsdjsjsjs",
                "23493",
                "anto@mker.com",
                "Big boy!!!",
                "A! A!",
                "Jammy",
                "jammy",
                "Hoksfosfoksfdoksfdoksodfkoskfoskdfoskdfosdofsdfdfsdfsdfsfsfsdfsdfsdf",
                "HAndk33",
                "Hank",
                "David"
            };

            foreach (var name in nameTestList)
            {
                Console.WriteLine($"{name}: {IsValidName(name)}");
            }
        }
        
        private static void RunTestIsValidPhoneNum()
        {
            List<string> phoneTestList = new List<string>
            {
                "234-44-2434",
                "1231231234",
                "555-555-1234",
                "3333-333-1231",
                "(249)230-1111"
            };

            foreach (var testNumber in phoneTestList)
            {
                Console.WriteLine(IsValidPhoneNumber(testNumber));
            }
        }

        private static void RunTestIsValidEmail()
        {
            List<string> emailTestList = new List<string>
            {
                "antonio@gmail.com",
                "!!sdfjsdfjsdf@gmail.com",
                "923492394@gmail.com",
                "a@gmail.com",
                "masdmamad@s.com",
                "pringles@pringles.pringles",
                "p@p.p",
                "jasdj#@pants.net"
            };

            foreach (var email in emailTestList)
            {
                Console.WriteLine($"{email}: {IsValidEmail(email)}");
            }
        }
       
        #endregion
    }
}
