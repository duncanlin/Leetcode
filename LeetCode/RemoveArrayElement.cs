using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveArrayElement
    {
        /*
         Given an array nums and a value val, remove all instances of that value in-place and return the new length.

        Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

        The order of elements can be changed. It doesn't matter what you leave beyond the new length.
             */


        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] != val)
                {
                    i++;
                    nums[index] = nums[i];
                }
            }

            return i;
        }
    }
}
