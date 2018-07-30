using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {
        //https://leetcode.com/problems/valid-parentheses/description/

        public bool IsValid(string s)
        {
            Dictionary<string, string> characters = new Dictionary<string, string>();
            characters.Add("(", ")");
            characters.Add("[", "]");
            characters.Add("{", "}");

            string anotherString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (characters.ContainsKey(s[i].ToString()))
                {
                    anotherString = characters[s[i].ToString()] + anotherString;
                }
                else
                {
                    if (s.IndexOf(anotherString) < 0)
                    {
                        return false;
                    }
                    anotherString = "";
                }
            }
            return true;
        }

        public int IsValid2(string S)
        {
            Stack<Char> ret = new Stack<Char>();
            foreach (var item in S)
            {
                if (item == Char.Parse("("))
                {
                    ret.Push(Char.Parse(")"));
                }
                else if (item == Char.Parse("["))
                {
                    ret.Push(Char.Parse("]"));
                }
                else if (item == Char.Parse("{"))
                {
                    ret.Push(Char.Parse("}"));
                }
                else if (ret.Count == 0 || ret.Pop() != item)
                {
                    return 0;
                }
            }
            return ret.Count == 0 ? 1 : 0;
        }
    }
}
