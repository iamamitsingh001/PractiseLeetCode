using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractProduct;

namespace PractiseLeetCode.DesignPattern.AbstractFactory.ConcreteProduct
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return "APPLE";
        }
    }
}
