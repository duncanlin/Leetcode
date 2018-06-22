using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseInteger
    {
       // https://leetcode.com/problems/reverse-integer/description/
        public int Reverse(int x)
        {
            char[] charArray = Math.Abs(x).ToString().ToCharArray();
            Array.Reverse(charArray);

            string revString = new string(charArray);

            if (x < 0)
            {
                revString = "-" + revString;
            }
            try
            {
                return int.Parse(revString);
            }
            catch (Exception)
            {
                return 0;
            }
               
        }
    }
}
