namespace PractiseLeetCode
{
    public class RemoveDuplicatesNumbers
    {
        /// <summary>
        /// Remove duplicate numbers
        /// </summary>
        /// <param name="nums">int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };</param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                bool val = false;
                if (i == nums.Length-1)
                {
                    val = true;
                }
                else if (nums[i] != nums[i + 1])
                {
                    val = true;
                }
                if (val)
                {
                    nums[current] = nums[i];
                    current++;
                }
            }
            return current;
        }
    }
}
