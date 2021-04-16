using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class UC1EmpCheck
    {
        public void PresentorAbsent()

        {
            Random random = new Random();

            int EmpCheack = random.Next(0, 2);

            if (EmpCheack == 1)

            {

                Console.WriteLine("Employee Is Present");



            }

            else

            {

                Console.WriteLine("Employe Is Absent");

            }

        }

    }
}




