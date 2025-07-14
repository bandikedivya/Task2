using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Xml.Linq;
namespace MethodOverLoading
{
    class Restaurant
    {
        public string Name { get; set; }
        public string OrderItem { get; set; }
        public double Price { get; set; }
        public int Tax { get; set; }
        public string UPIID { get; set; }
        public string Cash {  get; set; }
        public string BankApp { get; set; }

        public Restaurant()
        {
            
            Tax = 150;
            UPIID = "9876543210@ybl";
            Cash = "Collect Cash";
            BankApp = "Internet Banking";
        }
        public string Customer1rderDetails(string name, string orderitem, double price)
        {
            string customer1 = $"{name} ordered {orderitem}\n";
            double TotalAmount = price + Tax;
            return customer1 +" "+"Total Bill"+ ":"+ TotalAmount;
        }
        

        public string Customer2rderDetails(string name, string OrderItem, double price)
        {
            string customer2 = $"{name} ordered {OrderItem}\n";
            double TotalAmount = price + Tax;
            return customer2 + " "+"Total Bill" + ":" + TotalAmount;
        }

        public string Customer1Payment(string name)
        {
            return $"{name} : Bill \n" +
              $"Please Select Payment Mode:\n" +
                $"1.Pay By Cash:{Cash} \n" +
                $"2.UPI ID: {UPIID}\n" +
                $"3.Internet Banking: {BankApp}";
        }

        public string Customer2Payment(string name, string upiid, string cash, string bankapp)
        {
            return $"{name} : Bill \n"+ 
                $"Please Select Payment Mode:\n" +
                $"1.Pay By Cash:{cash} \n" +
                $"2.UPI ID: {upiid}\n" +
                $"3.Internet Banking: {bankapp}";
        }

        static void Main()
        {




            Console.WriteLine("******************Customer1 Order Details**********************");
            Restaurant customer1 = new Restaurant();
            Console.WriteLine(customer1.Customer1rderDetails("Luck", "Biriyani", 550));

            

            Restaurant customer1payment = new Restaurant();
            Console.WriteLine("*****************Customer1 Payment Mode*******************");
            // Console.ReadLine(customer1payment.Customer1Payment());
            Console.WriteLine("Select Payment Mode");
            
            Console.WriteLine(customer1payment.Customer1Payment("Luck"));
            
            //string cash = Convert.ToString(Console.ReadLine());
            //string upi = Convert.ToString(Console.ReadLine());
            //string mblbank = Convert.ToString(Console.ReadLine());
            string choice = Convert.ToString(Console.ReadLine());

            

            if (choice == "1")
            {

                Console.WriteLine($"{customer1.Cash} : You Have Selected Pay By Cash Option");
                Console.WriteLine("Collected Cash, Payment Made Successfully. Thank you..Visit Again");
            }
            else if (choice == "2")
            {
                Console.WriteLine($"{customer1.UPIID} : You Have Selected UPI ID Option");
                Console.WriteLine("UPI Payment Made Successfully. Thank you..Visit Again");
            }
            else if (choice == "3")
            {
                Console.WriteLine($"{customer1.BankApp} : You Have Selected Internet Banking Option");
                Console.WriteLine("Payment Made Successfully. Thank you..Visit Again");
            }

            else
            {
                Console.WriteLine("Invalid Option");
            }

            Console.WriteLine("******************Customer2 Order Details**********************");

            Restaurant customer2 = new Restaurant();
            Console.WriteLine(customer2.Customer2rderDetails("Martin", "Chicken Tandoori", 675));
            
            Console.WriteLine("*****************Customer2 Payment Mode*******************");
            Restaurant customer2payment = new Restaurant();
            Console.WriteLine(customer2payment.Customer2Payment("Martin","1234567890@ybl","Cash", "Imobile Bank App"));


            string choice1 = Convert.ToString(Console.ReadLine());



            if (choice1 == "1")
            {

                Console.WriteLine($"{customer2.Cash} : You Have Selected Pay By Cash Option");
                Console.WriteLine("Collected Cash, Payment Made Successfully. Thank you..Visit Again");
            }
            else if (choice1 == "2")
            {
                Console.WriteLine($"{customer2.UPIID} : You Have Selected UPI ID Option");
                Console.WriteLine("UPI Payment Made Successfully. Thank you..Visit Again");
            }
            else if (choice1 == "3")
            {
                Console.WriteLine($"{customer2.BankApp} : You Have Selected Internet Banking Option");
                Console.WriteLine("Payment Made Successfully. Thank you..Visit Again");
            }

            else
            {
                Console.WriteLine("Invalid Option");
            }
















            //int cash1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{cash1} : You Have Selected Pay By Cash Option");
            //Console.WriteLine("Collected Cash, Payment Made Successfully. Thank you..Visit Again");

            //int upi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{upi1} : You Have Selected UPI ID Option");
            //Console.WriteLine("UPI Payment Made Successfully. Thank you..Visit Again");

            //int mblbank1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{mblbank1} : You Have Selected Internet Banking Option");
            //Console.WriteLine("Payment Made Successfully. Thank you..Visit Again");

        }

    }
}