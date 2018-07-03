using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/find-all-duplicates-in-an-array/description/
    /*Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
      Find all the elements that appear twice in this array.
      Could you do it without extra space and in O(n) runtime?
    */

    public class FindAllDuplicatesInArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            #region NotO(N)
            //List<int> result1 = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums.Contains(nums[i]))
            //    {
            //        result1.Add(nums[i]);
            //    }
            //}
            //return result1;
            #endregion

            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i])-1] > 0)
                {
                    nums[Math.Abs(nums[i])-1] = nums[Math.Abs(nums[i])-1] * -1;
                }
                else
                {
                    result.Add(Math.Abs( nums[Math.Abs(nums[i])-1]));
                }
            }

            return result.ToArray();
        }
    }
}
