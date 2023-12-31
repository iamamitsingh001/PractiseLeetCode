namespace PractiseLeetCode.DesignPattern.Factory.Manager
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public int GetHourlyPay()
        {
            return 5;
        }
        public int GetBonus()
        {
            return 7;
        }
        public int GetMA()
        {
            return 80;
        }
    }
}
