using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Interger2Roman
    {
        //https://leetcode.com/problems/integer-to-roman/description/

        public string IntToRoman(int num)
        {
            int[] values = new int[] {1000,900,500,400,100,90,50,40,10,9,5,4,1 };
            string[] roman = new string[] {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I" };

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    result.Append(roman[i]);
                    num -= values[i];
                }
            }
            return result.ToString();
        }
    }
}
