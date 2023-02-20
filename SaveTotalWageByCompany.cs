using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class SaveTotalWageByCompany
    {
       
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;

        private String Company;
        private int Emp_Rate_Per_Hour;
        private int numOfWorkingDays;
        private int MAX_HRS_IN_MONTH;
        private int TotalEmpWage;



        public  SaveTotalWageByCompany(String Company, int Emp_Rate_Per_Hour, int numOfWorkingDays, int MAX_HRS_IN_MONTH)
        {
           this. Company = Company;
           this. Emp_Rate_Per_Hour = Emp_Rate_Per_Hour;
            this.numOfWorkingDays = numOfWorkingDays;
           this. MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;



        }
        public void ComputeEmpWage() { 

            int EmpHrs = 0,  TotalEmpHrs = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < numOfWorkingDays)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
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
            Console.WriteLine(" Total Emp  Wage for Company :" + Company + " is " + TotalEmpWage);
        }
        public String toString()
        {
            return "Total Emp Wage for company :" + this.Company + " is :  " + this.TotalEmpWage;
        }
    }
}
