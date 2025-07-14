using System;
using System.Data;
using System.Xml.Linq;
using System.Xml.Serialization;

class ComputerEmbroidery
{
    protected double price = 500;

    public virtual void ProductDetails()
    {
        Console.WriteLine("Welcome To ComputerEmroidery Boutique");
    }
    public virtual double TotalAmount()
    {
        return price;
    }

    class Sarees : ComputerEmbroidery
    {
        private double priceforsaree = 2500;
        public override void ProductDetails()
        {
            Console.WriteLine("Saree Design");
        }

        public override double TotalAmount()
        {
            Console.WriteLine("Your Saree & Blouse is Ready, Please Collect Your Saree and Blouse");
            return price + priceforsaree;
        }


    }
    class Kids : ComputerEmbroidery
    {
        private double priceforkids = 1500;
        public override void ProductDetails()
        {
            Console.WriteLine("Kids Design");
        }
        public override double TotalAmount()
        {
            Console.WriteLine("Your Kid Dress is Ready, Please Collect Your Kid's Dress");
            return price + priceforkids;
        }
        
    }

    class Program
    {
        static void Main()
        {
            ComputerEmbroidery saree = new Sarees();
            saree.ProductDetails();
            Console.WriteLine($"Total Amount: {saree.TotalAmount()}");


            ComputerEmbroidery kids = new Kids();
            kids.ProductDetails();
            Console.WriteLine($"Total Amount: {kids.TotalAmount()}");

            
            
        }
    }
}
