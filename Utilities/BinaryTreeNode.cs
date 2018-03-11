namespace Utilities
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
