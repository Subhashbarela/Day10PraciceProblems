using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class EmpUsingSepareteClass
    {


        public const int Emp_Rate_Per_Hour = 20;
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 10;
        public void HrsPerMonth()
        {

            int EmpHrs = 0, TotalEmpWage = 0, TotalEmpHrs = 0, TotalEmpWages = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = (random.Next(3));
                switch (EmpCheck)
                {
                    case Is_Full_Time:
                        EmpHrs = 8;
                        break;

                    case Is_Part_Time:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                TotalEmpHrs += EmpHrs;
                Console.WriteLine(" Days :" + TotalWorkingDays + " Emp Hours :" + EmpHrs);
            }
            TotalEmpWage = Emp_Rate_Per_Hour * TotalEmpHrs;
            Console.WriteLine(" Employee Total Wage :" + TotalEmpWage);
        }
    }
}
