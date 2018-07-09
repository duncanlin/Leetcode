using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyPow
    {

        //https://leetcode.com/problems/powx-n/description/

        //mplement pow(x, n), which calculates x raised to the power n (xn).

        public double GetValue(double x, int n)
        {
            if (n < 0)
            {
                return 1 / Pow(x, n);
            }
            else
            {
                return Pow(x, n);
            }
        }

        private double Pow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            double result = Pow(x, n / 2);
            if (n % 2 == 0)
            {
                return result * result;
            }
            else
            {
                return x * result * result;
            }
        }
    }
}
