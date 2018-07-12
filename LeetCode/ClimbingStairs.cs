using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Stair
    {

        //https://leetcode.com/problems/climbing-stairs/description/

        /*You are climbing a stair case. It takes n steps to reach to the top.

        Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

        Note: Given n will be a positive integer.*/

        public int ClimbStairs(int n)
        {
            #region Method1
            //n=100000 , stack out of memory exception
            /*
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
            */
            #endregion

            #region Method2
            //int[] memo = new int[n + 1];
            //return DynamicPrograming( n, memo);
            #endregion

            #region Method3

            int[] temp = new int[n + 1];
            temp[0] = 1;
            temp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                temp[i] = temp[i - 1] + temp[i - 2];
            }
            return temp[n];
            #endregion

        }

        private int DynamicPrograming(int n, int[] memo)
        {
            if (n==0 || n== 1)
            {
                return 1;
            }
            if(memo[n]==0)
            {
                memo[n] = DynamicPrograming(n - 1, memo) + DynamicPrograming(n - 2, memo);
            }
            return memo[n];
        }


    }
}
