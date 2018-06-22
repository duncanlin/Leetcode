using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/divide-two-integers/description/
    /// <summary>
    /// Given two integers dividend and divisor, divide two integers without using multiplication, division and mod operator.
    /// </summary>
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            var negative = 1;
            if ((dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0))
            {
                negative = -1;
            }
                divisor = Math.Abs(divisor);
                dividend = Math.Abs(dividend);

            int index = 0;
            while (dividend >= divisor )
            {
                if (dividend- divisor >= 0)
                {
                    dividend = dividend - divisor;
                    index++;
                }
            }

            return negative*index;
        }
    }
}
