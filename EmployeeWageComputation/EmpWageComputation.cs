using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {
        private const int IS_PRESENT = 1;
        public static void ISEmployeePresent()
        {
            Random random = new Random();

            int Check = random.Next(0, 2);
            if (Check == IS_PRESENT)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }

        public static void EmpWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 8;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:" + empWage);
            Console.ReadLine();
        }

        public static void PartTimeEmpWage()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOURS = 20;
            int empHrs = 8;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            empWage = empHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadLine();
        }


        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 120;
        public static void CalculateWageSwitchCase()
        {

            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }

        public const int IS_PART_TIME1 = 1;
        public const int IS_FULL_TIME1 = 2;
        public const int
            EMP_RATE_PER_HOURS = 20;
        public const int
            NUM_OF_WORKING_DAY = 2;
        public static void CalculateWagesFor20DaysInMonth()
        {
            int empHrs = 8;
            int empWage = 4;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAY; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME1:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME1:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOURS;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
                Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            }
        }

        public const int IS_PART_TIME2 = 1;
        public const int IS_FULL_TIME2 = 2;
        public const int EMP_RATE_PER_HRS = 20;
        public const int NUM_OF_WORK_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 120;
        public static void CalculateWageTill100HrsOr20IsReached()
        {

            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkDays = 0;
            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkDays < NUM_OF_WORK_DAYS)
            {
                totalWorkDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME2:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }


    }
}
