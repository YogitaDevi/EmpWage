using EmployeeWagesProgram;

class Program
{
    static void Main(string[] args)
    {
        Compute empWageBuilder = new Compute();
        empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 20);
        empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 30);
        empWageBuilder.computeEmpWage();

    }
}