using System;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    // Write a method that efficiently searches for a value in a binary tree
    public static bool Contains(Node root, int value)
    {
        if (root == null)
        {
            return false;
        }
        else if (root.Value == value)
        {
            return true;
        }
        else if (value < root.Value)
        {
            return Contains(root.Left, value);
        }
        else
        {
            return Contains(root.Right, value);
        }
    }

    //public static void Main(string[] args)
    //{
    //    Node n1 = new Node(1, null, null);
    //    Node n3 = new Node(3, null, null);
    //    Node n2 = new Node(2, n1, n3);

    //    Console.WriteLine(Contains(n2, 3));
    //}
}