using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern.Factory.Manager
{
    public interface IEmployeeManager
    {
        int GetHourlyPay();
        int GetBonus();
    }
}
