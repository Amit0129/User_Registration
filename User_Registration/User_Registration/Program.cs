namespace User_Registration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Validator validator = new Validator();
            bool doOrNot = true;
            while (doOrNot)
            {
                Console.WriteLine("Chose an Option");
                Console.WriteLine("1. Registration of First name");
                Console.WriteLine("2. Registration of Last name");
                Console.WriteLine("3. Registration of Simple Email");
                Console.WriteLine("4. Registration of Mobile Number");
                Console.WriteLine("5. Registration of Password Minimum \n   Eight Charecter and Atlest one Upper case \n   And exactly one special charector");
                Console.WriteLine("0. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("****************************************");
                switch (choice)
                {
                    case 0:
                        doOrNot= false;
                        break;
                    case 1:
                        Console.WriteLine("Enter First Name\n");
                        string firstName = Console.ReadLine();
                        Console.WriteLine(validator.FirstNameCheck(firstName));
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name\n");
                        string lastName = Console.ReadLine();
                        Console.WriteLine(validator.LastNameCheck(lastName));
                        break;
                    case 3:
                        Console.WriteLine("Enter your Mail Id\n");
                        string emailId = Console.ReadLine();
                        Console.WriteLine(validator.EmailCheck(emailId));
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile Number\n");
                        string mobileNumber = Console.ReadLine();
                        Console.WriteLine(validator.MobileNumberCheck(mobileNumber));
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();
                        Console.WriteLine(validator.PasswordCheck(password));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}