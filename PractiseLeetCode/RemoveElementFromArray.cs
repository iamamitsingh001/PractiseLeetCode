namespace PractiseLeetCode
{
    public class RemoveElementFromArray
    {
        /// <summary>
        /// Remove element from array and return the count
        /// </summary>
        /// <param name="nums">int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };</param>
        /// <param name="val">int val = 2;</param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[current] = nums[i];
                    current++;
                }
            }
            return current;
        }
    }
}
