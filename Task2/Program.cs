//using System;

//namespace Task2
//{
//    class EmployeeCompany
//    {
//        public string EmpName { get; set; }
//        public int EmpId { get; set; }
//        public byte age { get; set; }
//        public double Salary { get; set; }
//    }
//    class TenDiffReturnTypes
//    {
//        // Method 1: returns a int value
//        public static int Method1()
//        {
//            int EmpId = 2576267;
//            return EmpId;
//        }

//        // Method 2: returns a string value
//        public static string Method2()
//        {
//            string EmpName = "Marcus";
//            return EmpName;
//        }

//        // Method 3: returns a bool value
//        public static bool Method3()
//        {
//            // true if EmpId is even
//            return Method1() % 2 == 0;
//        }

//        // Method 4: returns a double value
//        public static double Method4()
//        {
//            double salary = 50000.83d;
//            return salary;
//        }

//        // Method 5: returns a byte value
//        public static byte Method5()
//        {
//            byte age = 25;
//            return age;
//        }

//        // Method 6: returns a long value
//        public static long Method6()
//        {
//            long NoofEmp = 216548135454L;
//            return NoofEmp;
//        }

//        // Method 7: returns a ulong value
//        public static ulong Method7()
//        {
//            ulong BankBalance = 750000UL;
//            return BankBalance;
//        }

//        // Method :8 returns a decimal value
//        public static decimal Method8()
//        {
//            decimal purchaseprice = 20000.23m;
//            return purchaseprice;
//        }

//        // Method 9: returns a char value
//        public static char Method9()
//        {
//            // return first letter of EmpName
//            return Method2()[3];
//        }

//        // Method 10: returns a float value
//        public static float Method10()
//        {
//            // Convert a salary example to float
//            return (float)Method4();
//        }



//        static void Main()
//        {
//            int method1 = Method1();
//            Console.WriteLine($"Method 1 with Int Return Type : {method1}");

//            string empName = Method2();
//            Console.WriteLine($"Method 2 with String Return Type : {empName}");

//            bool boolresult = Method3();
//            Console.WriteLine($"Method 3 with Boolean Return Type : {boolresult}");

//            double salaryresult = Method4();
//            Console.WriteLine($"Method 4 with Double Return Type : {salaryresult}");

//            byte ageresult = Method5();
//            Console.WriteLine($"Method 5 with Double Return Type : {ageresult}");

//            long NoofEmpresult = Method6();
//            Console.WriteLine($"Method 6 with Double Return Type : {NoofEmpresult}");

//            ulong bankbalanceresult = Method7();
//            Console.WriteLine($"Method 7 with Double Return Type : {bankbalanceresult}");

//            decimal purchasepriceresult = Method8();
//            Console.WriteLine($"Method 8 with Decimal Return Type : {purchasepriceresult}");

//            char indexresult = Method9();
//            Console.WriteLine($"Method 9 with Character Return Type : {indexresult}");


//            float floatresult = Method10();
//            Console.WriteLine($"Method 10 with Character Return Type : {floatresult}");
//        }
//    }
//}
