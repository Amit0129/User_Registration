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
        public bool FirstNameCheck(string firstName)
        {
            try
            {
                string fstNamePattern = "^[A-Z][A-Za-z]{2,}$";
                if (Regex.IsMatch(firstName, fstNamePattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool LastNameCheck(string lastName)
        {
            try
            {
                string lstNamePattern = "^[A-Z][A-Za-z]{2,}$";
                if (Regex.IsMatch(lastName, lstNamePattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool EmailCheck(string emailId)
        {
            try
            {
                string emailIdPattern = @"^[a-zA-Z0-9]+([._+-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
                if (Regex.IsMatch(emailId, emailIdPattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false; 
        }
        public bool MobileNumberCheck(string mobileNumber)
        {
                try
                {
                    string mobNumberPattern = "^[0-9]{2}[ ][6-9][0-9]{9}$";
                    if (Regex.IsMatch(mobileNumber, mobNumberPattern))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return false;
        }
        public bool PasswordCheck(string password)
        {
            try
            {
                string passwordPattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^!@#.$%_]*[!@#.$%_][^!@#.$%_]*$)[A-Za-z0-9!@#$%_]{8,}$";
                if (Regex.IsMatch(password, passwordPattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
    }
}
