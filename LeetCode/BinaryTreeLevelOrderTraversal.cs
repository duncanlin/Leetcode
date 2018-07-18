using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> tempList = new List<int>();
            BackTrack(result, root, 0);
            return result.ToArray();
        }

        private void BackTrack(List<List<int>> result, TreeNode node, int level)
        {
            if (node == null) return;
            if (result.Count <= level)
            {
                result.Add(new List<int>());
            }
            result[level].Add(node.val);
            if (node.left != null)
            {
                BackTrack(result, node.left, level + 1);
            }
            if (node.right != null)
            {
                BackTrack(result, node.right, level + 1);
            }

        }

        /**
         * Definition for a binary tree node.*/
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

    }
}
