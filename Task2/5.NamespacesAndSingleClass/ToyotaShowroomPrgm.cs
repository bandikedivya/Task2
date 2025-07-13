using ToyotaShowroom;
using Customer1;
using Customer2;
using System;

namespace ToyotaShowroomMainPrgm
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("****************Welcome to Toyota Showroom**************");

            Console.WriteLine("****************Customer1 Details**************");
            Customer1.CustomerDetails customer1 = new Customer1.CustomerDetails();
            Console.WriteLine($"Customer1 Name: {customer1.CustomerName}");
            Console.WriteLine($"Customer1 Age: {customer1.CustomerAge}");
            Console.WriteLine($"Customer1 Car Price: {customer1.CarPrice}");

            Console.WriteLine("****************Customer2 Details**************");
            Customer2.CustomerDetails customer2 = new Customer2.CustomerDetails();
            Console.WriteLine($"Customer2 Name: {customer2.CustomerName}");
            Console.WriteLine($"Customer2 Age: {customer2.CustomerAge}");
            Console.WriteLine($"Customer2 Car Price: {customer2.CarPrice}");

        }
    }
}