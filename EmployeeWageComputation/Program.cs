using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //    UC1EmpCheck uC1 = new UC1EmpCheck();
            //    uC1.PresentorAbsent();
            //UC2DailyWage uC2 = new UC2DailyWage();
            //uC2.EmployeeWage();
            //UC3EmpPartTime uC3 = new UC3EmpPartTime();
            //uC3.ParttimeEmployeeWage();
            //UC4SwitchCase uC4 = new UC4SwitchCase();
            //UC4SwitchCase.SwitchCaseStatement();
            //UC5WagesForMonth uC5 = new UC5WagesForMonth();
            //UC5WagesForMonth.WageForMonth();
            //UC6WageMaxHours uC6 = new UC6WageMaxHours();
            //UC6WageMaxHours.WagesCondition();
            //UC7CodeRefractor uC7 = new UC7CodeRefractor();
            //UC7CodeRefractor.ComputeEmployeeWage();
            //UC8WageMultipleCompanies uC8 = new UC8WageMultipleCompanies();
            //UC8WageMultipleCompanies.ComputeEmpWage("Amazon",20,4,20);
            //UC8WageMultipleCompanies.ComputeEmpWage("Infosys", 30, 6, 20);
            //UC9StoreWageMultpleCompanies Dmart  = new UC9StoreWageMultpleCompanies("Dmart", 20, 4, 20);
            //UC9StoreWageMultpleCompanies Reliance = new UC9StoreWageMultpleCompanies("Reliance", 30, 5, 20);
            //Dmart.ComputeEmployeeWage(); //call method
            //Console.WriteLine(Dmart.toString());
            //Reliance.ComputeEmployeeWage();//call method
            //Console.WriteLine(Reliance.toString());
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();   //Create object of class
            empWageBuilder.addComapnyEmpWage("Dmart", 20, 2, 10);  //call method
            empWageBuilder.addComapnyEmpWage("Reliance", 10, 4, 20); //call method
            empWageBuilder.ComputeEmployeeWage(); //call method
            






            Console.Read();
        }


    }
}

           
