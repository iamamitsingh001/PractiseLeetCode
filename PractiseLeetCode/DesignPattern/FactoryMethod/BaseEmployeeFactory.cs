using PractiseLeetCode.DesignPattern.Factory;
using PractiseLeetCode.DesignPattern.Factory.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee Employee { get; set; }
        public BaseEmployeeFactory(Employee employee)
        {
            Employee = employee;
        }
        public Employee CalculateSalary()
        {
            IEmployeeManager employeeManager = this.Create();
            Employee.Bonus = employeeManager.GetBonus();
            Employee.HourlyPay = employeeManager.GetHourlyPay();
            return Employee;
        }
        public abstract IEmployeeManager Create();
    }
}
