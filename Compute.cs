using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProgram
{
    public class Compute
    {
        public static void DailyEmployeeWage()
        {
            int fullTimeEmp = 1;
            int partTimeEmp = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 1)
            {
                empHrs = 8;                              //for full time employee
            }
            else if (empCheck == 2)
            {
                empHrs = 4;                              //for part time employee
            }
            else
            {
                empHrs = 0;                               //if employee is absent
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
        }

    }
}
