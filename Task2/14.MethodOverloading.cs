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
            Restaurant customer1 = new Restaurant();
            Console.WriteLine(customer1.Customer1rderDetails("Luck", "Biriyani", 550));

            Restaurant customer2 = new Restaurant();
            Console.WriteLine(customer2.Customer2rderDetails("Martin", "Chicken Tandoori", 675));

            Restaurant customer1payment = new Restaurant();
            Console.WriteLine("*****************Customer1 Payment Mode*******************");
            // Console.ReadLine(customer1payment.Customer1Payment());
            Console.WriteLine("Select Payment Mode");
            
            Console.WriteLine(customer1payment.Customer1Payment("Luck"));
            string cash = Console.ReadLine();
            Console.WriteLine($"{cash} : You Have Selected Pay By Cash Option");
            Console.WriteLine("Collected Cash, Payment Made Successfully. Thank you..Visit Again");

            string upi = Console.ReadLine();
            Console.WriteLine($"{upi} : You Have Selected UPI ID Option");
            Console.WriteLine("UPI Payment Made Successfully. Thank you..Visit Again");

            string mblbank = Console.ReadLine();
            Console.WriteLine($"{mblbank} : You Have Selected Internet Banking Option");
            Console.WriteLine("Payment Made Successfully. Thank you..Visit Again");


            Console.WriteLine("*****************Customer2 Payment Mode*******************");
            Restaurant customer2payment = new Restaurant();
            Console.WriteLine(customer2payment.Customer2Payment("Martin","1234567890@ybl","Cash", "Imobile Bank App"));
            string cash1 = Console.ReadLine();
            Console.WriteLine($"{cash1} : You Have Selected Pay By Cash Option");
            Console.WriteLine("Collected Cash, Payment Made Successfully. Thank you..Visit Again");

            string upi1 = Console.ReadLine();
            Console.WriteLine($"{upi1} : You Have Selected UPI ID Option");
            Console.WriteLine("UPI Payment Made Successfully. Thank you..Visit Again");

            string mblbank1 = Console.ReadLine();
            Console.WriteLine($"{mblbank1} : You Have Selected Internet Banking Option");
            Console.WriteLine("Payment Made Successfully. Thank you..Visit Again");

        }

    }
}