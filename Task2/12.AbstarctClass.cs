using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AbstractApplication
{
    // Rule + method Implementation
    abstract class BankApp
    {
        public string CustomerName { get; set; }
        public string CustomerEmailID { get; set; }
        public abstract void Login();
        public abstract void Logout();


        
        public abstract void ShowCustomerDetails();
        //{
            //Console.WriteLine($"[Customer Name]: {CustomerName} , [Customer Email ID] : {CustomerEmailID}");
       // }





        //Concrete Method(Normal Method)
        //Derived Class (Child Class) - Both are same
        // Should use "override" keyword when we want to abstract the dervied class from abstract class
        class CreditCard : BankApp
        {
            public CreditCard()
            {
                CustomerName = "Emily";
                CustomerEmailID = "emily@gmail.com";
            }
            public override void Login()
            {
                Console.WriteLine($"{CustomerName} has logged in to the Bank App and Viewed Credit Card Option");
            }

            public override void Logout()
            {
                Console.WriteLine($"{CustomerName} has logged out from the Bank App");
            }


            //Direct Methods
            public void ShowCreditCardOptions()
            {
                Console.WriteLine("Welcome to Credit Card Options, Check your Credit Score and Apply");
            }

            public void AppliedCreditCard()
            {
                Console.WriteLine("You have applied for Credit Card, Your application is being processed. Thank you for applying Credit Card..");
            }

            public override void ShowCustomerDetails()
            {
                Console.WriteLine($"[Customer Name]: {CustomerName} , [Customer Email ID] : {CustomerEmailID}");
            }
        }



        class DebitCard : BankApp
        {
            public override void Login()
            {
                Console.WriteLine($"{CustomerName} has logged in to the Bank App and Viewd Debit Card Option");
            }

            public override void Logout()
            {
                Console.WriteLine($"{CustomerName} has logged out from the Bank App");
            }

            public void ShowDebitCardOptions()
            {
                Console.WriteLine("Welcome to Debit Card Options, Apply and Complete KYC Online to get Debit Card..");
            }
            public void ApplyDebitCard()
            {
                Console.WriteLine("You have applied for Debit Card, Your application is being processed. Thank you for applying Debit Card..");
            }

            public override void ShowCustomerDetails()
            {
                Console.WriteLine($"[Customer Name]: {CustomerName} , [Customer Email ID] : {CustomerEmailID}");
            }
        }
        //1. For Abstract class, we cannot create instance,
        //2. But Abstarct class , we can refer to the child or derived class
        class AbstractProgram
        {
            public static void Main()
            {
                BankApp app = new CreditCard();
                //{
                //    CustomerName = "Justin",
                //    CustomerEmailID = "justin1234@gmail.com"
                //};

                app.Login();
                app.ShowCustomerDetails();
                
                CreditCard appCreditCard = new CreditCard();
                appCreditCard.ShowCreditCardOptions();
                appCreditCard.AppliedCreditCard();
                app.Logout();


                //app.CustomerName = "Divya";
                //app.CustomerEmailID = "12345";
                //app.CustomerDetails("abc", "1234");



                //app.ShowCustomerDetails();

                BankApp debitcard = new DebitCard()

                {
                    CustomerName = "Jermaiah",
                    CustomerEmailID = "jermaiah@gmail.com"

                };

                debitcard.Login();
               
                debitcard.ShowCustomerDetails();
                DebitCard debit = new DebitCard();
                debit.ShowDebitCardOptions();
                debit.ApplyDebitCard();
               
                debitcard.Logout();




            }
        }
    }
}


