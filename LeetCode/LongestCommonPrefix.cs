using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestCommonPrefix
    {
        //https://leetcode.com/problems/longest-common-prefix/description/

        public string LongestCommonPrefix2(string[] strs)
        {
            string prefix = strs[0];
            //if (prefix.Length==0)
            //{
            //    return "";
            //}
            //for (int i = 0; i < strs[0].Length; i++)
            //{
            //    prefix = strs[0].Substring(0,i+1);
            //    for (int j = 0; j < strs.Length; j++)
            //    {
            //        if (strs[j].Substring(0, j+1) != prefix)
            //        {
            //            return prefix;
            //        }
            //    }
            //}

            for (int i = 0; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length ==0)
                    {
                        return "";
                    }
                }
            }

            return prefix;

        }
    }
}
