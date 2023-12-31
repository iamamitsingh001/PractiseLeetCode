using PractiseLeetCode.DesignPattern.Factory;
using PractiseLeetCode.DesignPattern.Factory.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager employeeManager = new ContractEmployeeManager();
            Employee.MA = employeeManager.GetMA();
            return employeeManager;
        }
    }
}
