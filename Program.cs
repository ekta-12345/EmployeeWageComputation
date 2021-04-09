using System;

namespace EmployeeWageComputation
{
    class Program
    {
        //constants
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
       
        static void Main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpwage = 0;
            int workingDays = 1;
            int hrs = 0;

            //inbuilt class
            Random random = new Random();
            while( hrs < MAX_WORKING_HRS && workingDays <= MAX_WORKING_DAYS )
            {
                workingDays++;
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
                hrs += empHrs;
                totalEmpwage += empWage;
                
            }
            Console.WriteLine("Employee wage for " + workingDays+ " days " +totalEmpwage);
            Console.WriteLine("Working hours " + hrs);
            Console.Read();
       
        }
    }
}