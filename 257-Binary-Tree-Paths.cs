 public class Solution
 {
     public IList<string> BinaryTreePaths(TreeNode root)
     {
         List<string> paths = new List<string>();
         Node(root, \\, paths);
         return paths;
     }
     void Node(TreeNode root,string s, List<string> paths)
     {
         if (root == null) return;
         s += root.val.ToString();
         if (root.left == null && root.right == null)
         {
             paths.Add(s);
         }
         else
         {
             Node(root.left, s + \->\, paths);
             Node(root.right, s + \->\, paths);
         }
     }
 }