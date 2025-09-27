namespace AlgoTemp
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static class Helper
    {
        public static void DFS(TreeNode root)
        {
            if (root == null) return;
            Console.WriteLine(root.val);
            DFS(root.left);
            DFS(root.right);
        }

        public static void BFS(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Any())
            {
                TreeNode node = queue.Dequeue();

                if (node == null) continue;
                Console.WriteLine(node.val);

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }
    }
}
