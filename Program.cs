using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;

            //local variables
            int empHrs = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);

            Console.WriteLine("random value " + employeeCheck);
            //Selection statements
            if (employeeCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else if (employeeCheck == PART_TIME)
            {
                empHrs = 4;

            }
            else
            {
                empHrs = 0;

            }
            //Computation
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage Per Day " + empWage);
            Console.Read();
        }

    }
}