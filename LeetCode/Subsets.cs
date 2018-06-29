using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Subsets
    {
        public IList<IList<int>> GetSubsets(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);
            Backtrack(result, new List<int>(), nums, 0);
            return (IList<IList<int>>)result;
        }

        private void Backtrack(List<List<int>> result, List<int> tempList, int[] nums, int startIndex)
        {
            result.Add(tempList);
            for (int i = startIndex; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(result, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
