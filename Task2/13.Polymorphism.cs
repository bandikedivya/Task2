using System;
using System.Data;
using System.Xml.Linq;

class Manufacturer
{
    public string EmpName { get; set; }
    public int HoursWorked { get; set; }
    public double HourlyRate { get; set; }

    public Manufacturer()
    {
        EmpName = "Udyan";
    }

    public void EmpDetails()
    {
        Console.WriteLine($"Employee Name: {EmpName}");
       
    }

    public virtual string Salary()
    {
        return $"{EmpName}  :25000";
    }


    class PermanentEmp : Manufacturer
    {
        public PermanentEmp()
        {
            EmpName = "Melania";
        }
        public override string Salary()
        {

            return $"{EmpName}  :21000";
        }


    }
    class ContractEmployee : Manufacturer
    {
        public ContractEmployee()
        {
            EmpName = "Naina";
        }
        public override string Salary()
        {

            return $"{EmpName}  :18000";
        }

    }

    class Program
    {
        static void Main()
        {

            Manufacturer pcompany = new PermanentEmp();
           // Console.WriteLine(pcompany.Salary());


            pcompany.EmpDetails();
            Console.WriteLine($"Salary Of {pcompany.Salary()}");

            Manufacturer contract = new ContractEmployee();
            contract.EmpDetails();
            Console.WriteLine($"Salary Of {contract.Salary()}");
        }
    }
}
