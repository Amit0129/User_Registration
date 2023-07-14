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
                Console.WriteLine("Enter First Name\n");
                string firstName = Console.ReadLine();
                string fstNamePattern = "^[A-Z][A-Za-z]{2,}$";
                if (Validate(firstName, fstNamePattern))
                {
                    Console.WriteLine($"The First Name of The Person is {firstName}\n");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid FirstName Where first letter must be in capital and it contain minimun three charectar\n");
                }
            }
        }
        public void LastNameCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter Last Name\n");
                string lastName = Console.ReadLine();
                string lstNamePattern = "^[A-Z][A-Za-z]{2,}$";
                if (Validate(lastName, lstNamePattern))
                {
                    Console.WriteLine($"The Last Name of The Person is {lastName}\n");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Last Name Where first letter must be in capital and it contain minimun three charectar\n");
                }
            }
        }
        public void EmailCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter your Mail Id\n");
                string emailId = Console.ReadLine();

                string emailIdPattern = @"^[a-zA-Z]{3,}([._+-][a-zA-Z]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
                if (Validate(emailId, emailIdPattern))
                {
                    Console.WriteLine($"The Email id is valid\n");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Email Id\n");
                }
            }
        }

        public void MobileNumberCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter Mobile Number\n");
                string mobileNumber = Console.ReadLine();
                string mobNumberPattern = "^[0-9]{2}[ ][6-9][0-9]{9}$";
                if (Validate(mobileNumber, mobNumberPattern))
                {
                    Console.WriteLine($"The Mobile Number is {mobileNumber}\n");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Mobile Number\n");
                }
            }
        }
        public void PasswordCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter Password\n");
                string password = Console.ReadLine();
                string passwordPattern = "^(?=.*[A-Z])[A-Za-z0-9!@#.$%_]{8,}$";
                if (Validate(password, passwordPattern))
                {
                    Console.WriteLine($"The passwoed is {password} \n");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Password that have minimum 8 Characters and Atlist one upper case Chareacter\n");
                }
            }
        }
    }
}