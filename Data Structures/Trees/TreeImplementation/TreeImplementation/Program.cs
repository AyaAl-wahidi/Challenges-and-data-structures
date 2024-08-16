using System.Xml.Linq;

namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example for BinarySearchTree
            Console.WriteLine("Binary Search Tree Example:");
            BinarySearchTree bst = new BinarySearchTree();
            int[] valuesToAdd = { 50, 30, 70, 20, 40, 60, 80 };

            // Adding values to BST
            foreach (int value in valuesToAdd)
            {
                bst.Add(value);
                Console.WriteLine($"Added {value} to BST.");
            }

            // Checking if certain values are in the BST
            Console.WriteLine("\nChecking if values are in BST:");
            Console.WriteLine("BST contains 40: " + bst.Contains(40)); // true
            Console.WriteLine("BST contains 100: " + bst.Contains(100)); // false

            // Deleting a value from the BST
            Console.WriteLine("\nDeleting value 50 from BST.");
            bst.Root = bst.DeleteRecursively(bst.Root, 50);
            Console.WriteLine("InOrderTraversal after deletion:");
            bst.InOrderTraversal(bst.Root);

            // Example for BinaryTree
            Console.WriteLine("\nBinary Tree Example:");
            BinaryTree bt = new BinaryTree();
            bt.Root = new TNode(1);
            bt.Root.Left = new TNode(2);
            bt.Root.Right = new TNode(3);
            bt.Root.Left.Left = new TNode(4);
            bt.Root.Left.Right = new TNode(5);
            bt.Root.Right.Left = new TNode(6);
            bt.Root.Right.Right = new TNode(7);

            // PreOrder Traversal
            Console.WriteLine("\nPreOrder Traversal (Root-Left-Right):");
            bt.PreOrderTraversal(bt.Root);

            // InOrder Traversal
            Console.WriteLine("\nInOrder Traversal (Left-Root-Right):");
            bt.InOrderTraversal(bt.Root);

            // PostOrder Traversal
            Console.WriteLine("\nPostOrder Traversal (Left-Right-Root):");
            bt.PostOrderTraversal(bt.Root);

            // Print the entire tree with indentation
            Console.WriteLine("\nPrinting the Binary Tree:");
            bt.Print();
            Console.WriteLine();

            Console.WriteLine(" *********** In Oreder Traversal ***********");
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(4);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(12);
            Btree.Root.Left.Right = new TNode(9);
            List<int> printList = Btree.InOrderTrav(Btree.Root); 

            // Mirror the BinaryTree
            Btree.Mirror(Btree.Root);

            // Print the mirrored BinaryTree
            Console.WriteLine(" *********** Mirrored Binary Tree ***********");
            Btree.PrintInOrder();
        }
    }
}