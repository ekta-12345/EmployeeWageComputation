using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class UC2DailyWage
    {
        public void EmployeeWage()

        {

            int PRESENT = 1;

            int EMP_RATE_PER_HOUR = 20;

            int emphrs = 0;

            int empWage = 0;

            Random random = new Random();

            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == PRESENT)

            {

                emphrs = 8;



            }

            else

            {

                emphrs = 0;

            }

            empWage = EMP_RATE_PER_HOUR * emphrs;

            Console.WriteLine("Employe Wage Per Day:- " + empWage);

        }

    }
}
