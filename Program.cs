using System;
using EmployeeWagesProgram;

namespace EmployeeWagesProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compute.computeEmpWage("DMart", 20, 20, 100);
            Compute.computeEmpWage("Reliance", 20, 20, 100);
        }
    }
}