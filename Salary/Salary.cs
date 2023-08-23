using System;
namespace Salary
{
    class Salary
    {
        int employeeno;
        long basicsalary;
        string employeename,dateofbirth;
        double da,hra,pf,pt,gross,netsal;
        public void input()
        { 
            Console.Write("Enter the Employee No : ");
            employeeno=int.Parse(Console.ReadLine());
            Console.Write("Enter the Employee Name : ");
            employeename=Console.ReadLine();
            Console.Write("Enter the Date of Birth : ");
            dateofbirth=Console.ReadLine();
            Console.Write("Enter the Salary : ");
            basicsalary=long.Parse(Console.ReadLine());
        }
        public void caluclate()
        {   
            if (basicsalary<=20000)
            {
                da=basicsalary*0.40;
                hra=basicsalary*0.10;
                pf=basicsalary*0.12;
                pt=100;
            }
            else
            {
                da=basicsalary*0.50;
                hra=basicsalary*0.15;
                pf=basicsalary*0.12;
                pt=150;
            }
            gross=basicsalary+da+hra;
            netsal=gross-pf-pt;
        }
        public void display()
        {
            Console.WriteLine("*************************");
            Console.WriteLine($"Employee No : {employeeno}");
            Console.WriteLine($"Employee Name : {employeename}");
            Console.WriteLine($"DOB : {dateofbirth}");
            Console.WriteLine($"Salary : {basicsalary} Rs");
            Console.WriteLine($"DA : {da:F2} Rs");
            Console.WriteLine($"HRA : {hra:F2} Rs");
            Console.WriteLine($"PF : {pf:F2} Rs");
            Console.WriteLine($"PT : {pt:F2} Rs");
            Console.WriteLine($"Gross : {gross:F2} Rs");
            Console.WriteLine($"NetSal : {netsal:F2} Rs");
        }

        public static void Main(string[]args)
        {
            Salary s=new();
            s.input();
            s.caluclate();
            s.display();
        }
        
    }
}