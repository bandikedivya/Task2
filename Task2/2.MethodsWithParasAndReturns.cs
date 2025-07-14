using System;
class MethodsWithParamsAndReturnTypes
{


    // Methods with return type and with one parameter 
    public static string getID(int id)
    {
        string empDetails = $"Employee Name is Martin and his employee id is: {id}";
        return empDetails;

    }
    public static string getbankDetails(int accountno)
    {
        string bankDetails = $"Bank Name is HDFC and account number is: {accountno}";
        return bankDetails;
    }

    public static double salary(double salary)
    {

        return salary;
    }

    //Methods with return type and with two parameters
    public static string getNameId(string name, int id)
    {
        return $"Emp Name is: {name} and Id is : {id}";
    }


    public static string empNameandAge(string name, int age)
    {
        return $"Name of Emp Name is: {name} and Age of Emp is: {age}";
    }


    //  Concatenate name and salary → returns string
    public static string EmpNameAndSalary(string name, double salary)
    {
        return $"Employee {name} earns {salary}";
    }



    //Array return type
    public static string[] EmployeeName()
    {
        string[] names = { "Belly", "Fisher" };
        return names;
    }


    // Sum two IDs → returns int
    public static int SumIds(int id1, int id2)
    {
        return id1 + id2;
    }


    //Checks Emp 1 salary with Emp 2 salary  → returns bool
    public static bool IsHighEarner(double emp1salary, double emp2salary)
    {
        return emp1salary > emp2salary;
    }

    public static double CalculateSalary(int hoursWorked, int hourlyRate, double bonus)
    {
        return (hoursWorked * hourlyRate) + bonus;
    }


    static void Main()
    {
        string result1 = getID(2576260);                                     // Method with return type and with one parameter 
        Console.WriteLine(result1);

        string result2 = getbankDetails(00110230230);                       // Method with return type and with one parameter 
        Console.WriteLine(result2);

        double salaryresult = salary(75000.5);                               // Method with return type and with one parameter 
        Console.WriteLine($"Salary of Emmployee: {salaryresult}");

        string result3 = getNameId("Sophia", 2576250);                     //Method with return type and with two parameters
        Console.WriteLine(result3);

        string result4 = empNameandAge("Luck", 24);                         //Method with return type and with two parameters
        Console.WriteLine(result4);

        string namesalary = EmpNameAndSalary("Finn", 25000);
        Console.WriteLine(namesalary);


        string[] empnames = EmployeeName();                                 //Called string array method 
        foreach (string empname in empnames)
        {
            Console.WriteLine(empname);
        }

        int sumresult = SumIds(1011, 1022);                                 //Sum of Id's
        Console.WriteLine($"Sum of Id's : {sumresult}");

        bool empsalaryresult = IsHighEarner(55000.75, 50000);            //Bool Method
        Console.WriteLine(empsalaryresult);


        double calculatesalary = CalculateSalary(9, 150, 1000);           //Total Salary
        Console.WriteLine($"Total Salary: {calculatesalary}"); 



    }
}

