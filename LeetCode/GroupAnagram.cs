using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/group-anagrams/description/
    //Given an array of strings, group anagrams together.

    //best solution is that converting string to char array and sorting 
    // Array.Sort(char[])

    // brute-force attack is not good solution

    public class GroupAnagram
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            //each string split into char array
            // string contains with all char in loop

            List<List<string>> result = new List<List<string>>();
            List<string> tempStrs = new List<string>();
            List<string> hasSelected = new List<string>();
            tempStrs.AddRange(strs);
            for (int i = 0; i < strs.Length; i++)
            {
                List<string> group = new List<string>();
                char[] array = strs[i].ToArray();
                bool isAnagram = false;
                for (int j = 0; j < tempStrs.Count; j++)
                {
                    if (hasSelected.Contains(tempStrs[j]))
                    {
                        continue;
                    }

                    for (int k = 0; k < array.Length; k++)
                    {
                        if (tempStrs[j].Contains<char>(array[k]))
                        {
                            isAnagram = true;
                        }
                        else
                        {
                            isAnagram = false;
                            break;
                        }
                    }
                    if (isAnagram)
                    {
                        group.Add(tempStrs[j]);
                        hasSelected.Add(tempStrs[j]);
                    }
                }
                if (group.Count>0)
                {
                    result.Add(group);
                }
                group = new List<string>();
            }
            return result.ToArray();
        }
    }
}
