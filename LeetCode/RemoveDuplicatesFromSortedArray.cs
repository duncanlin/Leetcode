using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
    //Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
    //Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

    public class RemoveDuplicatesFromSortedArray
    {
        /// <summary>
        /// Remove Duplicates from Sorted Array
        /// </summary>
        /// <param name="nums">input</param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int slowIndex = 0;
            
            for (int index = 1; index < nums.Length; index++)
            {
                if (nums[slowIndex] != nums[index])
                {
                    slowIndex++;
                    nums[slowIndex] = nums[index];
                }
            }
            return slowIndex + 1;
        }
    }
}
