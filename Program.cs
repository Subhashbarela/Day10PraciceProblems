using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            SaveTotalWageByCompany tcs = new SaveTotalWageByCompany("tcs",20,10,15);
            tcs.ComputeEmpWage();
            Console.WriteLine(tcs.ToString());
            SaveTotalWageByCompany Cognizent = new SaveTotalWageByCompany("cognizent",20,8,17);
            Cognizent.ComputeEmpWage();
            Console.WriteLine(Cognizent.ToString());


        }
    }
}
