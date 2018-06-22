using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestPalindromicSubstring
    {
        //https://leetcode.com/problems/longest-palindromic-substring/description/
        public string LongestPalindrome(string s)
        {
            List<string> listSubstring = new List<string>();
            string substring = "";
            //Start with first char 
            for (int i = 0; i < s.Length; i++)
            {
                substring = s.Substring(i);

                for (int j = substring.Length-1; j >= 1; j--)
                {
                    string reverseSubString = Reverse(substring);
                    if (reverseSubString == substring)
                    {
                        listSubstring.Add(substring);
                        break;
                    }
                    else
                    {
                        if (substring.Substring(0).Length > j)
                        {
                            //substring cut last char
                            substring = substring.Substring(0, j);
                        }
                    }
                }
            }

            //find max length substring
            int maxLength = 0;
            int indexMaxString = 0;
            for (int i = 0; i < listSubstring.Count(); i++)
            {
                if(maxLength <= listSubstring[i].Length)
                {
                    maxLength = listSubstring[i].Length;
                    indexMaxString = i;
                }
            }

            return listSubstring[indexMaxString];
        }

        /// <summary>
        /// Reverse String
        /// </summary>
        /// <param name="s">source string</param>
        /// <returns></returns>
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
