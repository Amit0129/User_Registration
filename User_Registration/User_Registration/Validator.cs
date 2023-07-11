using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class Validator
    {
        public bool Validate(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }
        public void FirstNameCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                string fstNamePattern = "^[A-Z][A-Za-z]{2,}$";
                if (Validate(firstName, fstNamePattern))
                {
                    Console.WriteLine($"The First Name of The Person is {firstName}");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid FirstName Where first letter must be in capital and it contain minimun three charectar");
                }
            }
        }
        public void LastNameCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                string lstNamePattern = "^[A-Z][A-Za-z]{2,}$";
                if (Validate(lastName, lstNamePattern))
                {
                    Console.WriteLine($"The Last Name of The Person is {lastName}");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Last Name Where first letter must be in capital and it contain minimun three charectar");
                }
            }
        }
        public void EmailCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter your Mail Id");
                string emailId = Console.ReadLine();

                string emailIdPattern = @"^[a-zA-Z]{3,}([._+-][a-zA-Z]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
                if (Validate(emailId, emailIdPattern))
                {
                    Console.WriteLine($"The Email id is valid");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Email Id");
                }
            }
        }
    }
}