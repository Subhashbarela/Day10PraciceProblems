using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class EmpWageForMultiCompany
    {
        // int Emp_Rate_Per_Hour;
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
       // public int WORKING_DAYS;
       // public int MAX_HRS_IN_MONTH;
        public void ComputeEmp(String Company, int Emp_Rate_Per_Hour, int numOfWorkingDays, int MAX_HRS_IN_MONTH)
        {


            int EmpHrs = 0, TotalEmpWage = 0, TotalEmpHrs = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < numOfWorkingDays)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0,3);
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
            Console.WriteLine(" Total Emp  Wage for Company :"+ Company + " is " + TotalEmpWage);
        }
    }
}
