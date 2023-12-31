using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode
{
    public class MajorityElements
    {
        /// <summary>
        /// MajorityElements
        /// </summary>
        /// <param name="nums">int[] nums = { 6, 5, 5 };</param>
        /// <returns></returns>
        public static int MajorityElement(int[] nums)
        {
            if (nums.Length > 1)
                return nums.GroupBy(a => a).Select(i => new { key = i.Key , count = i.Count() }).Where(c => c.count > nums.Length/2).Select(i => i.key).FirstOrDefault();
            if (nums.Length == 1)
                return nums.FirstOrDefault();
            else
                return nums.Length;
        }
    }
}
