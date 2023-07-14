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
                        validator.FirstNameCheck();
                        break;
                    case 2:
                        validator.LastNameCheck();
                        break;
                    case 3:
                        validator.EmailCheck();
                        break;
                    case 4:
                        validator.MobileNumberCheck();
                        break;
                    case 5:
                        validator.PasswordCheck();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}