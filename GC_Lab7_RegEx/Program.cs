using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GC_Lab7_RegEx
{
    class Program
    {
        // GC Lab 7 Regular Expressions
        // Antonio Manzari

        // TODO
        // Write a method that will validate names. Names can only have alphabets, they should start with a capital letter, and they have a max length of 30. (but what about people with SUPER LONG names?)
        // Write a method that will validate emails. An email should be in the following format: {comb of alphanumeric chars, with a length between 5 and 30, and there are no special chars}@{comb of alpnum chars, with a length between 5 and 10, and there are no special chars}.{domain can be a comb of alphnum chars with a length of two or three}
        // Write a method that will validate phone numbers. A phone # should be in the format: {area code of 3 dig}-{3dig}-{4dig}
        // Write a method that will validate date based on the following formt: (dd/mm/yyyy)
        // EX
        // Write a method that validates HTML elements

        // O  NAME
        // O  EMAIL
        // X  PHONE #
        // O  DATE
        // O  EX: HTML ELEMENTS

        public static List<string> phoneTestNumbers= new List<string>
            {
                "234-44-2434",
                "1231231234",
                "555-555-1234",
                "3333-333-1231",
                "(249)230-1111"
            };

        static void Main(string[] args)
        {
            foreach (var testNumber in phoneTestNumbers)
            {
                Console.WriteLine(IsValidPhoneNumber(testNumber));
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^\d\d\d-\d\d\d-\d\d\d\d$";

            return Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
