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
    }
}
