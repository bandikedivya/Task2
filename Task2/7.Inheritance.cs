
using System;
namespace OnlineShopping
{
    class Ajio
    {
        public string Name { get; set; }

        public Ajio()
        {
            Name = "Jack";
            Console.WriteLine($"{Name} purchased from Ajio");
        }
        public Ajio(string name)
        {
            Console.WriteLine($"{name} purchased from BBSale in Ajio");
        }

        public void ShowMessage()
        {
            Console.WriteLine($"BBSALE is Live, {Name} ordered product in BBSALE in Ajio");
        }
    }
    class Myntra : Ajio
    {

        public Myntra()
        {

            Console.WriteLine($"{Name} purchased from Myntra");
        }
        public Myntra(string myname) : base(myname)
        {


            Console.WriteLine($"{myname} purchased from Flat80% SALE in Myntra");
        }
        public void ShowSaleMessage()
        {
            Console.WriteLine($"Flat80% is Live, {Name} ordered product in BBSALE in Ajio");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Myntra myntra = new Myntra("Sky");
            myntra.ShowSaleMessage();
            myntra.ShowMessage();





            //Ajio ajio = new Ajio();
            //Ajio ajio1 = new Ajio("Divya");
            //ajio.ShowMessage();



        }
    }

}




