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
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHourPerMonth;
        private int totalEmpWage;
        public Compute(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth, int totalEmpWage)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHourPerMonth = maxHourPerMonth;
            this.totalEmpWage = totalEmpWage;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHourPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IsPartTime:
                        empHrs = 4;
                        break;
                    case IsFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);

            }
            totalEmpWage = totalEmpHrs + this.empRatePerHour;
        }
        public string toString()
        {
            return "Total Emp wage for company : " + this.company + " is : " + this.totalEmpWage;
        }   
    }
}
