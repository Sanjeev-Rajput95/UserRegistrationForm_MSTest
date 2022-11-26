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

            Console.Write("Enter the email address : ");
            string emailAddress = Console.ReadLine();
            UserRegistrationForm.UserValideEmail(emailAddress);

            Console.Write("Enter the Mobile Number : ");
            string mobileNumber = Console.ReadLine();
            UserRegistrationForm.MobileNumber(mobileNumber);

            Console.Write("Enter the password  : ");
            string userPassWord = Console.ReadLine();
            UserRegistrationForm.PassWordRule1(userPassWord);

            Console.Write("Enter the password atleast 1 uppercase char : ");
            string uppercasePassWord = Console.ReadLine();
            UserRegistrationForm.UpperCasePassWordRule_2(uppercasePassWord);

            Console.Write("Enter the password atleast 1 Number : ");
            string atleast1PassWord = Console.ReadLine();
            UserRegistrationForm.Atleast1NumberPassWordRule_3(atleast1PassWord);

            Console.Write("Enter the password atleast 1 special char : ");
            string min1SpecialCharPassWord = Console.ReadLine();
            UserRegistrationForm.Atleast1SpecialCharPassWordRule_4(min1SpecialCharPassWord);

            Console.Write("Enter email Sample  : ");
            string emailSample = Console.ReadLine();
            UserRegistrationForm.EmailSample(emailSample);
        }
    }
}