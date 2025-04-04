 public class Solution
 {
     public TreeNode LcaDeepestLeaves(TreeNode root)
     {
         return I_HATE_TREES(root).Item1;
     }
     public Tuple<TreeNode, int> I_HATE_TREES(TreeNode ROOT)
     {
         if (ROOT == null)
         {
             return new Tuple<TreeNode, int>(null, 0);
         }
         var left = I_HATE_TREES(ROOT.left);
         var right = I_HATE_TREES(ROOT.right);
         if (left.Item2 > right.Item2)
         {
             return new Tuple<TreeNode, int>(left.Item1, left.Item2 + 1);
         }
         else if (left.Item2 < right.Item2)
         {
             return new Tuple<TreeNode, int>(right.Item1, right.Item2 + 1);
         }
         else
         {
             return new Tuple<TreeNode, int>(ROOT, left.Item2 + 1);
         }
     }

 }