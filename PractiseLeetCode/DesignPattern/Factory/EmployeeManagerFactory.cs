using PractiseLeetCode.DesignPattern.Factory.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetClassDetails(int Decider)
        {
            IEmployeeManager classManager = null;
            if (Decider > 0)
            {
                classManager = new PermanentEmployeeManager();
            }
            else
            {
                classManager= new ContractEmployeeManager();
            }
            return classManager;
        }
    }
}
