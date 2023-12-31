using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractProduct;

namespace PractiseLeetCode.DesignPattern.AbstractFactory.AbstractInterface
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}
