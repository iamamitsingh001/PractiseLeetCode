using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractInterface;
using PractiseLeetCode.DesignPattern.Factory;

namespace PractiseLeetCode.DesignPattern.AbstractFactory.ConcreteFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            IComputerFactory computerFactory = null;
            if (employee.EmployeeType == 1)
            {
                if (employee.Bonus > 10)
                {
                    computerFactory = new MacLaptopFactory();
                }
                else
                {
                    computerFactory = new MacFactory();
                }
            }
            if (employee.EmployeeType == 2)
            {
                if (employee.Bonus > 10)
                {
                    computerFactory = new DellLaptopFactory();
                }
                else
                {
                    computerFactory = new DellFactory();
                }
            }
            return computerFactory;
        }
    }
}
