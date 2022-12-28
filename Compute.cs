using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProgram
{
    public class Compute
    {
        public void PresentAbsent()
        {
            Random rand = new Random();
            int employeeCheck = rand.Next(0, 2);

            if (employeeCheck == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
