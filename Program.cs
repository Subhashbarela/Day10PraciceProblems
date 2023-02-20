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
            EmpWageForMultiCompany Comp1 = new EmpWageForMultiCompany();
            Comp1.ComputeEmp("Cognizent",20,20,20);
            EmpWageForMultiCompany Comp2 = new EmpWageForMultiCompany();
            Comp2.ComputeEmp("AngularMind", 10, 15, 10);


        }
    }
}
