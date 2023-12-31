using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractInterface;

namespace PractiseLeetCode.DesignPattern.AbstractFactory.Client
{
    public class EmployeeSystemManager
    {
        protected IComputerFactory ComputerFactory { get; set; }
        public EmployeeSystemManager(IComputerFactory computerFactory) { ComputerFactory = computerFactory; }

        public string GetSystemDetails()
        {
            return string.Format("{0} {1} {2}", ComputerFactory.Brand().GetBrand(), ComputerFactory.SystemType().GetSystemType(), ComputerFactory.Processor().GetProcessor());
        }

    }
}
