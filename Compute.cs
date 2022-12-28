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
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDays = 20;
        public static void wagesForMonth()
        {
            int empHrs = 0,  totalEmpWage = 0;          
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case isPartTime:
                    empHrs = 4;
                break;
                case isFullTime:
                    empHrs = 8;
                break;
                default:
                     empHrs = 0;
                break;
            }
            totalEmpWage = (empHrs * empRatePerHour) * numOfWorkingDays;               
            Console.WriteLine("Total Emp Wage A Month : " + totalEmpWage);
        }

    }
}
