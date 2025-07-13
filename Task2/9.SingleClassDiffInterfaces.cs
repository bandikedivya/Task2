using System;

namespace InterfaceProgram
{

    public interface IGmail
    {
        void Signin();
        void SignOut();

        void verifyMobileNum();
        void AddAlternavtivenum();


    }
    public interface IChrome
    {
        void getDetails(string email, string password);

    }


    public interface IFacebook
    {
        void LoginDetails(string email, string password);
    }
    class Bgmi : IGmail, IChrome, IFacebook
    {
        public void AddAlternavtivenum()
        {
            Console.WriteLine("Added Alternative Mobile Number Successfully");
        }

        public void getDetails(string email, string password)
        {
            Console.WriteLine($"Email is: {email}, And Password is: {password}");
        }

        public void LoginDetails(string email, string password)
        {
            Console.WriteLine($"Email is: {email}, And Password is: {password}");
        }



        public void Signin()
        {
            Console.WriteLine("You Have Signed In Successfully");
        }

        public void SignOut()
        {
            Console.WriteLine("You Have Signed Out Successfully");
        }

        public void verifyMobileNum()
        {
            Console.WriteLine("Your Mobile Number +91......6975 is Verified Successfully");
        }
    }
    class InterfaceProgram
    {
        static void Main()
        {
            IGmail Ibgmi = new Bgmi();
            Ibgmi.AddAlternavtivenum();
            Ibgmi.Signin();
            Ibgmi.SignOut();
            Ibgmi.verifyMobileNum();

            IChrome ichrome = new Bgmi();
            ichrome.getDetails("email@gmail.com","123456");

            IFacebook Ifacebook = new Bgmi();
            Ifacebook.LoginDetails("login@gmail.com","1234567890");





        }
    }
}