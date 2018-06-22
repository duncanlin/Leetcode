using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeTwoSortedLists
    {
        //https://leetcode.com/problems/merge-two-sorted-lists/description/

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 != null)
            {
                return l2;
            }
            if (l1 != null && l2 == null)
            {
                return l1;
            }
            ListNode head = new ListNode(0);
            ListNode l3 = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    l3.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    l3.next = l2;
                    l2 = l2.next;
                }
                l3 = l3.next;
            }
            if (l1 != null &&  l1.next !=null)
            {
                l3.next = l1;
            }
            if (l2 != null && l2.next != null)
            {
                l3.next = l2;
            }
            return head.next;
        }

    }

    /*** Definition for singly-linked list.*/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
