using System;
using EmployeeWagesProgram;

Compute dMart = new Compute("Dmart", 20, 2, 10, 200);
Compute reliance = new Compute("Reliance", 10, 4, 20, 150);
dMart.computeEmpWage();
Console.WriteLine(dMart.toString());
reliance.computeEmpWage();
Console.WriteLine(reliance.toString());