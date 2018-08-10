using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Codity
    {
        public int solution(int[] A)
        {
            //https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
            // PermCheck
            //Check whether array A is a permutation.

            int[] temp = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                //out of range
                if (A[i] < 1 || A[i] > A.Length)
                {
                    return 0;
                }
                // had meet before
                if (temp[A[i] - 1] == 1)
                {
                    return 0;
                }

                if (temp[A[i] - 1] != 1)
                {
                    temp[A[i] - 1] = 1;
                }
            }
            return 1;
        }


        public int solution2(int[] A)
        {
            //https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
            //PassingCars
            //Count the number of passing cars on the road.
            int count = 0;
            int total = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    count++;
                }
                else
                {
                    total = total + count;

                }
            }
            if (total >= 1000000000)
            {
                return -1;
            }
            return total;

        }


        public int solution3(int[] A)
        {
            //https://app.codility.com/programmers/lessons/6-sorting/distinct/
            //Distinct
            //Compute number of distinct values in an array.
            if (A.Length == 0)
            {
                return 0;
            }
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dic.ContainsKey(A[i]))
                {
                    dic.Add(A[i], 1);
                }
            }
            return dic.Count;

        }


        public int solution4(int[] A)
        {
            //MaxProductOfThree

            //Maximize A[P] * A[Q] * A[R] for any triplet (P, Q, R).

            //https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/

            Array.Sort(A);
            if (A.Length < 3)
            {
                return 0;
            }
            if (A[0] < 0 && A[1] < 0)
            {
                if (A[0] * A[1] * A[A.Length - 1] > A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3])
                {
                    return A[0] * A[1] * A[A.Length - 1];

                }
            }
            return A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];

        }


        public int solution5(string S)
        {
            //Nesting (String)
            //Determine whether a given string of parentheses (single type) is properly nested.
            //https://app.codility.com/programmers/lessons/7-stacks_and_queues/nesting/


            if (S.Trim() == "")
            {
                return 1;
            }
            int ret = 0;
            foreach (var item in S)
            {
                if (item.ToString() == "(")
                {
                    ret++;
                }
                else
                {
                    ret--;
                    if (ret < 0)
                    {
                        return 0;
                    }
                }
            }
            return ret == 0 ? 1 : 0;
        }


        public int solution6(int[] A)
        {
            //OddOccurrencesInArray
            https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/

            // Using the concept of "XOR" (^)
            // when there is a pair A and B 
            // A^B will be zero 
            // A^B^C (where C is not paired), 
            // then A^B^C = C


            var ret = A.Aggregate((x, y) => x ^ y);
            return ret;
        }

        public int solution7(int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }
            int[] temp = new int[A.Length+1];
            for (int i = 0; i < A.Length; i++)
            {
                temp[A[i]-1] = 1;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i]==0)
                {
                    return i+1;
                }
            }
            return 0;
        }
    }
}
