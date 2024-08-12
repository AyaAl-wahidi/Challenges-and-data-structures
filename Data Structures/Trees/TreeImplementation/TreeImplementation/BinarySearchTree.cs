using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeImplementation
{
    public class BinarySearchTree 
    {
        public TNode Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        // Add & Add Recursively
        public void Add(int data)
        {
            Root = AddRecursively(Root, data);
        }

        private TNode AddRecursively(TNode node, int data)
        {
            if (node == null)
                return new TNode(data);

            if (data < node.Value)
                node.Left = AddRecursively(node.Left, data);
            else if (data > node.Value)
                node.Right = AddRecursively(node.Right, data);

            return node;
        }

        // If Contains & If Contains Recursively
        public bool Contains(int data)
        {
            return ContainsRecursively(Root, data);
        }

        public bool ContainsRecursively(TNode node, int data)
        {
            if (node == null) return false;

            if (data == node.Value)
                return true;
            else if (data < node.Value)
                return ContainsRecursively(node.Left, data);
            else
                return ContainsRecursively(node.Right, data);

        }

        public TNode DeleteRecursively(TNode root, int value)
        {

            if (root == null)
                return root;

            if (value < root.Value)
            {
                root.Left = DeleteRecursively(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = DeleteRecursively(root.Right, value);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                    return root.Left;

                root.Value = InOrderSuccessor(root.Right);
                root.Right = DeleteRecursively(root.Right, root.Value);
            }

            return root;

        }

        public int InOrderSuccessor(TNode root)
        {
            int minimum = root.Value;
            while (root.Left != null)
            {
                minimum = root.Left.Value;
                root = root.Left;
            }
            return minimum;
        }

        // InOrder Traversal (Left-Root-Right)
        public void InOrderTraversal(TNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
            InOrderTraversal(node.Right);
        }
    }
}