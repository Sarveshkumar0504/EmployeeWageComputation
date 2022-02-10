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
    }
}
