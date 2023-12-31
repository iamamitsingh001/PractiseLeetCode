using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractProduct;

namespace PractiseLeetCode.DesignPattern.AbstractFactory.ConcreteProduct
{
    public class i7 : IProcessor
    {
        public string GetProcessor()
        {
            return "i7";
        }
    }
    public class i5 : IProcessor
    {
        public string GetProcessor()
        {
            return "i5";
        }
    }
}
