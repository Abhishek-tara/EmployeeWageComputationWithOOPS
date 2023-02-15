using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageWithOops
{
    public class CheckEmployee
    {
        public int IS_FULLTIME = 1;
        public  void EmployeeCheck()
        {
            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULLTIME)
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
