using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.LeetCodeProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TwoSumSolution twoSumSolution = new TwoSumSolution();
            int[] request = { 3,2,4 };
            var result = twoSumSolution.TwoSum(request, 6);
        }
    }
}
