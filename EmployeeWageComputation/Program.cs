﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to EmployeeWageComputation ");
            EmpWageComputation emp = new EmpWageComputation();
            EmpWageComputation.ISEmployeePresent();
            EmpWageComputation.EmpWage();
            EmpWageComputation.PartTimeEmpWage();
            EmpWageComputation.CalculateWageSwitchCase();
            EmpWageComputation.CalculateWagesFor20DaysInMonth();


            Console.ReadKey (); 
        }
    }
}
