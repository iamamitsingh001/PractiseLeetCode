using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractProduct;

namespace PractiseLeetCode.DesignPattern.AbstractFactory.ConcreteProduct
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return "Laptop";
        }
    }
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return "Desktop";
        }
    }
}
