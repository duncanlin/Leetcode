using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RevLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode ret = head;
            ListNode temp = head;
            ListNode p = null;
            ListNode n = null;
            temp = ret.next;
            while (temp != null)
            {
                n = p;
                p = ret;
                ret = temp;
                temp = ret.next;
                ret.next = p;
                p.next = n;
            }
            return ret;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}

