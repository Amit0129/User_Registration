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
                Console.WriteLine("0. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        doOrNot= false;
                        break;
                    case 1:
                        validator.FirstNameCheck();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}