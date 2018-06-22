using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
    /// </summary>
    public class PalindromeNumber
    {
        //https://leetcode.com/problems/palindrome-number/description/
        //Coud you solve it without converting the integer to a string?
        public bool IsPalindrome(int x)
        {
            if (x > 10 )
            {
                ArrayList tempArr = new ArrayList();
                int swapNum = x;

                while (swapNum >= 10)
                {
                    tempArr.Add(swapNum % 10);
                    swapNum = swapNum / 10;
                }
                tempArr.Add(swapNum);

                int revNum = (int)tempArr[0];
                if (tempArr.Count > 1)
                {
                    for (int i = 1; i < tempArr.Count; i++)
                    {
                        revNum = revNum + (int)tempArr[i] * (int)Math.Pow(10, i);
                    }
                }

                if (x == revNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (x != 0  && x <=10 )
            {
                return false;
            }
            else
            {
                //x==0
                return true;
            }
        }

    }
}
