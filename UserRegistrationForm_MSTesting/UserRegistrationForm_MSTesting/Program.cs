namespace UserRegistrationForm_MSTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** WELCOME TO USER REGISTRATION FORM PROGRAM *********************");

            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            UserRegistrationForm.UserForm(fName);

            Console.Write("Enter last name : ");
            string lName = Console.ReadLine();
            UserRegistrationForm.UserFormLastName(lName);
        }
    }
}