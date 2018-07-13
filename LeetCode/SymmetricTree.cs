using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        private bool IsMirror(TreeNode root1, TreeNode root2)
        {
            if (root1==null && root2==null)
            {
                return true;
            }
            if (root1 == null || root2 == null)
            {
                return false;
            }
            return (root1.val == root2.val) && IsMirror(root1.right,root2.left) && IsMirror(root1.left,root2.right);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
