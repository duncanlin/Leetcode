using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Roman2Integer
    {
        //https://leetcode.com/problems/roman-to-integer/description/
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanDictionary = new Dictionary<char, int>();
            romanDictionary.Add(Char.Parse("I"), 1);
            romanDictionary.Add(Char.Parse("V"), 5);
            romanDictionary.Add(Char.Parse("X"), 10);
            romanDictionary.Add(Char.Parse("L"), 50);
            romanDictionary.Add(Char.Parse("C"), 100);
            romanDictionary.Add(Char.Parse("D"), 500);
            romanDictionary.Add(Char.Parse("M"), 1000);

            var temp = s.ToArray();
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    if (romanDictionary[temp[i]] >= romanDictionary[temp[i + 1]])
                    {
                        result += romanDictionary[temp[i]];
                    }
                    else
                    {
                        //兩個字元一起處理
                        result = result + romanDictionary[temp[i + 1]] - romanDictionary[temp[i]];
                        i += 1;
                    }
                }
                else
                {
                    //最後一個字元自己處理
                    result += romanDictionary[temp[i]];
                }

            }

            return result;
        }
    }

}
