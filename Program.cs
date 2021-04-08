using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int present = 1;

            Random randomValue = new Random();
            int employeeCheck = randomValue.Next(0, 2);

            if (employeeCheck == present)
                  Console.WriteLine("Employee is Present");
            else
                  Console.WriteLine("Employee is absent");
                  Console.Read();
              
        }

    }
}
