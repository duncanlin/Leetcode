using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/permutations/description/
    //Given a collection of distinct integers, return all possible permutations.

    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);
            Backtrack(result, new List<int>(), nums);

            return result.ToArray();
        }

        private void Backtrack(List<List<int>> result, List<int> templist, int[] nums)
        {
            if (templist.Count == nums.Length)
            {
                List<int> newList = new List<int>();
                newList.AddRange(templist);
                result.Add(newList);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (templist.Contains(nums[i]))
                {
                    continue;
                }
                templist.Add(nums[i]);
                Backtrack(result, templist, nums);
                templist.RemoveAt(templist.Count - 1);
            }
        }
    }
}
