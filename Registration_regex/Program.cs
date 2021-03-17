using System;
using System.Collections.Generic;

namespace registration_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my registration form regex apllication by Akshay");
            RegexValidation regexValidation = new RegexValidation();
            Console.WriteLine("Enter Your First Name::-");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));
            Console.WriteLine("Enter Your Last Name::-");
            string LastName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateLastName(LastName));
            Console.WriteLine("Enter Your Email Address::-");
            string Email = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateEmail(Email));
            Console.WriteLine("Enter Your Mobile Number::-");
            string MobileNumber = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateMobile(MobileNumber));
            Console.WriteLine("Enter Your Password");
            string Password = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidatePassword(Password));
            List<string> sampleEmailList = new List<string>()
            {
                "akshay@ygmail.com",
                "asr@gmail.com",
                "asr.123@xyz.com",
                "akshayraut@gmail.com",
            };
            foreach (string item in sampleEmailList)
            {
                if (regexValidation.ValidateEmail(item))
                {
                    Console.WriteLine("Valid Email");
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }
        }
    }
}