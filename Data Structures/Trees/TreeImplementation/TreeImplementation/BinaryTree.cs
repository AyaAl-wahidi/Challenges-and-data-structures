using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public TNode Root;
        List<int> list = new List<int>();
        public BinaryTree()
        {
            Root = null;
        }

        // Root - Left - Right
        public void PreOrderTraversal(TNode node)
        {
            if (node == null) return;
            Console.WriteLine(node.Value);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        // Left - Right - Root
        public void PostOrderTraversal(TNode node)
        {
            if (node == null) return;
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.WriteLine(node.Value);
        }

        // Left - Root - Right
        public void InOrderTraversal(TNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
            InOrderTraversal(node.Right);
        }

        public void Print()
        {
            PrintRecursively(Root, "");
        }

        private void PrintRecursively(TNode node, string output)
        {
            if (node == null)
                return;

            // Print the current node
            Console.WriteLine(output + node.Value);

            // Update the indentation
            output += "    ";

            PrintRecursively(node.Left, output);
            PrintRecursively(node.Right, output);
        }

        public List<int> InOrderTrav(TNode node)
        {
            if (node == null) return null;
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
            InOrderTraversal(node.Right);
            list.Add(node.Value);
            return list;
        }

        public void Mirror(TNode node)
        {
            if (node == null) return;
            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
            Mirror(node.Left);
            Mirror(node.Right);
        }

        public void PrintInOrder()
        {
            try
            {
                InOrderTrav(Root);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during In-Order traversal: {ex.Message}");
            }
        }

        int FirstMax = 0;
        int SecMax = 0;
        public int FindSecondMax(TNode node)
        {
            if (node == null) return SecMax;

            if (node.Value > FirstMax)
            {
                SecMax = FirstMax;
                FirstMax = node.Value;
                if (node.Left == null && node.Right == null) return FirstMax;
            }
            else if (node.Value > SecMax && node.Value < FirstMax)
            {
                SecMax = node.Value;
            }

            FindSecondMax(node.Left);
            FindSecondMax(node.Right);

            return SecMax;
        }

        public int LeafSum(TNode node)
        {
            if (node == null) return 0;
            if (node.Left == null && node.Right == null) return node.Value;
            int leftRec = LeafSum(node.Left);
            int rightRec = LeafSum(node.Right);

            return leftRec + rightRec;
        }



        // Level 0: 5
        // Level 1: 13
        // Level 2: 20
        // Level 3: 11
        //List<int> ints = new List<int>();
        //int max = 0;
        //public List<int> LargestValueEachLevel(TNode node)
        //{
        //    if (node == null) return null;

        //    if (node.Left != null && node.Right != null)
        //    {
        //        if (node.Left.Value > node.Right.Value)
        //        {
        //            max = node.Left.Value;
        //            ints.Add(max);
        //            LargestValueEachLevel(node.Left);
        //        }
        //        else
        //        {
        //            max = node.Right.Value;
        //            ints.Add(max);
        //            LargestValueEachLevel(node.Right);
        //        }
        //    }
        //    return ints;
        //}

        public List<int> LargestValueEachLevel()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Empty Tree!");
            }

            var list = new List<int>();
            FindLargestValues(Root, 0, list);
            return list;
        }

        private void FindLargestValues(TNode node, int level, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            //If we are visiting this level for the first time
            if (level == list.Count)
            {
                list.Add(node.Value);
            }
            else
            {
                list[level] = Math.Max(list[level], node.Value);
            }
            FindLargestValues(node.Left, level + 1, list);
            FindLargestValues(node.Right, level + 1, list);
        }

        public void PrintRightView(TNode node)
        {
            TNode current = node.Left;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Right;
            }
            while (current != null)
            {
                TNode temp = current;
                current = current.Right;
                if (current == null && temp.Left != null)
                {
                    current = temp.Left;
                    current = current.Right;
                }
                if (current != null)
                {
                    Console.WriteLine(current.Value);
                }
            }
        }
    }
}