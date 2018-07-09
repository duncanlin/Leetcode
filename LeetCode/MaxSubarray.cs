using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaxSubarray
    {
        //https://leetcode.com/problems/maximum-subarray/description/
        //Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

        //loop each element and  compute sum value in sub loop    
        //If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.


        public int GetMaxSubArrary(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int max = 0;
                for (int j = i; j <nums.Length ; j++)
                {
                    max = max + nums[j];
                    if (result<max)
                    {
                        result = max;
                    }
                }
            }
            return result;
        }

    }
}
