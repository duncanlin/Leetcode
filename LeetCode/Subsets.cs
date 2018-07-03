using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Subsets
    {
        //https://leetcode.com/problems/subsets/description/
        //Given a set of distinct integers, nums, return all possible subsets (the power set).


        public List<List<int>> GetSubsets(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);
            Backtrack(result, new List<int>(), nums, 0);
            return result;
        }


        private void Backtrack(List<List<int>> result, List<int> tempList, int[] nums, int startIndex)
        {
            // result.Add(tempList) had a logical bug that the same memory address
            List<int> newList = new List<int>();
            newList.AddRange(tempList);
            result.Add(newList);
            for (int i = startIndex; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(result, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
