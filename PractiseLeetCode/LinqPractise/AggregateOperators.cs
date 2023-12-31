using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.LinqPractise
{
    public class AggregateOperators
    {
        protected readonly int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        protected readonly string[] Countries = { "India", "Canada", "USA", "Germany", "Ruissia" };

        #region Get Minimum 
        public int GetMinUsingLogic()
        {
            int? result = null;
            foreach (var number in Numbers)
            {
                if (!result.HasValue || result > number)
                {
                    result = number;
                }
            }
            return result.Value;
        }

        public int GetMinUsingLinq()
        {
            return Numbers.Min();
        }

        public int GetEvenMinFromLogic()
        {
            int? result = null;
            foreach (var number in Numbers)
            {
                if (number%2 == 0)
                {
                    if (!result.HasValue || result > number)
                    {
                        result = number;
                    }
                }
            }
            return result.Value;
        }

        public int GetEvenMinFromLinq()
        {
            return Numbers.Where(n => n % 2 == 0).Min();
        }

        #endregion

        #region Get Maximum
        public int GetMaxFromLogic()
        {
            int? result = null;
            foreach (var number in Numbers)
            {
                if (!result.HasValue || result < number)
                {
                    result = number;
                }
            }
            return result.Value;
        }

        public int GetMaxFromLinq()
        {
            return Numbers.Max();
        }

        public int GetEvenMaxFromLogic()
        {
            int? result = null;
            foreach(var number in Numbers)
            {
                if (number % 2 == 0)
                {
                    if (!result.HasValue || result < number)
                    {
                        result = number;
                    }
                }
            }
            return result.Value;
        }
        public int GetEvenMaxFromLinq()
        {
            return Numbers.Where(n => n % 2 == 0).Max();
        }

        #endregion

        #region Aggregate Example
        public string GetCommaSeparatedCountries()
        {
            return Countries.Aggregate((a, b) => a + ", " + b);
        }
        #endregion
    }
}
