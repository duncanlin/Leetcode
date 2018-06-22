using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ImplementStringStrFunction
    {
        //https://leetcode.com/problems/implement-strstr/description/
        //Implement strStr().
        //Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack.Length - i > needle.Length)
                {
                    if (haystack.Substring(i,needle.Length) == needle  )
                    {
                        return i;
                    }
                }

            }
            return -1;
        }
    }
}
