using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern.Factory.Manager
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public int GetHourlyPay()
        {
            return 7;
        }
        public int GetBonus()
        {
            return 5;
        }

        public int GetHRA()
        {
            return 100;
        }
    }
}
