using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LengthOfLastWord
    {
        /*
        Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

        If the last word does not exist, return 0.

        Note: A word is defined as a character sequence consists of non-space characters only.*/


        public int GetLength(string s)
        {
            var result = s.Trim().Split(new string[]{" "},StringSplitOptions.RemoveEmptyEntries);
            return result[result.Length - 1].Length;
        }
    }
}
