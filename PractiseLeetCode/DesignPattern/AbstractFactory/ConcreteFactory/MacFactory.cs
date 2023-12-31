using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractInterface;
using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractProduct;
using PractiseLeetCode.DesignPattern.AbstractFactory.ConcreteProduct;

namespace PractiseLeetCode.DesignPattern.AbstractFactory.ConcreteFactory
{
    public class MacFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new i7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class MacLaptopFactory : MacFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
