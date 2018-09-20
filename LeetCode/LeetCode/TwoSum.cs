using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Given an array of integers, return indices of the two numbers such that they add up to a specific target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * Example:
 * Given nums = [2, 7, 11, 15], target = 9,
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
*/
namespace LeetCode
{
    class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {

            Dictionary<int, int> diff = new Dictionary<int, int>();
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (diff.ContainsKey(nums[i]))
                {
                    res[0] = diff[nums[i]];
                    res[1] = i;
                    break;
                }
                else
                {
                    diff[target - nums[i]] = i;
                }

            }
            return res;
        }
    }
}
