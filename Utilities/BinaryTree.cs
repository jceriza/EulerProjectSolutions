namespace Utilities
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; }
        public BinaryTree(BinaryTreeNode<T> root)
        {
            Root = root;
        }
    }
}
