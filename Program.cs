using System;

namespace EmployeeWageComputation
{
    class Program
    {
        //constants
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpwage = 0;
            //inbuilt class
            Random random = new Random();
            for (int day = 0; day < WORKING_DAYS; day++)
            {
                int employeeCheck = random.Next(0, 3);

                //Console.WriteLine("random value " + employeeCheck);

                //Selection statements

                switch (employeeCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                //Computation 
                empWage = EMP_RATE_PER_HR * empHrs;
                
                totalEmpwage += empWage;
                
            }
            Console.WriteLine("Employee wage for 20 days " + totalEmpwage);
            Console.Read();
       
        }
    }
}