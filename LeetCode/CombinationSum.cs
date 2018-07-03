using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CombinationSum
    {
        //https://leetcode.com/problems/combination-sum/description/
        /*Given a set of candidate numbers (candidates) (without duplicates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.
          The same repeated number may be chosen from candidates unlimited number of times.
          Note:
          All numbers (including target) will be positive integers.
         The solution set must not contain duplicate combinations.*/

        public IList<IList<int>> GetCombinationSum(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(candidates);
            BackTrack(result, new List<int>(), candidates, 0, target);
            return result.ToArray();
        }

        public void BackTrack(List<List<int>> result, List<int> tempList, int[] nums, int startIndex , int remain)
        {
            if (remain < 0)
            {
                return; 
            }
            else if (remain == 0)
            {
                List<int> newList = new List<int>();
                newList.AddRange(tempList);
                result.Add(newList);
            }
            else
            {
                for (int i = startIndex; i < nums.Length; i++)
                {
                    tempList.Add(nums[i]);
                    BackTrack(result, tempList, nums, i, remain - nums[i]);
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }
    }
}
