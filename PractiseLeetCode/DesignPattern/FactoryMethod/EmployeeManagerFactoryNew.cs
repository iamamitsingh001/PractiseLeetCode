using PractiseLeetCode.DesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern.FactoryMethod
{
    public class EmployeeManagerFactoryNew
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory baseEmployeeFactory = null;
            if (employee.EmployeeType == 1)
            {
                baseEmployeeFactory = new PermanentEmployeeFactory(employee);
            }
            if (employee.EmployeeType == 2)
            {
                baseEmployeeFactory = new ContractEmployeeFactory(employee);
            }
            return baseEmployeeFactory;
        }
    }
}
