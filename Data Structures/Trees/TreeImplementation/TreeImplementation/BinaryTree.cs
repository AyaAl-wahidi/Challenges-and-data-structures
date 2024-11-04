using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
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

        public int LargestLevelValue()
        {
            List<int> nodeCountsPerLevel = new List<int>();
            LargestLevelValue(Root, 0, nodeCountsPerLevel);

            int maxLevel = 0;
            int maxNodes = nodeCountsPerLevel[0];
            for (int i = 1; i < nodeCountsPerLevel.Count; i++)
            {
                if (nodeCountsPerLevel[i] > maxNodes)
                {
                    maxNodes = nodeCountsPerLevel[i];
                    maxLevel = i;
                }
            }
            return maxLevel;
        }

        private void LargestLevelValue(TNode node, int level, List<int> nodeCountsPerLevel)
        {
            if (node == null) return;

            if (level == nodeCountsPerLevel.Count)
            {
                nodeCountsPerLevel.Add(0);
            }

            nodeCountsPerLevel[level]++;

            LargestLevelValue(node.Left, level + 1, nodeCountsPerLevel);
            LargestLevelValue(node.Right, level + 1, nodeCountsPerLevel);
        }

        public int FindMinimumDepth(TNode node)
        {
            if (node == null) return 0;

            // If there is no left subtree, recur for right subtree
            if (node.Left == null) return FindMinimumDepth(node.Right) + 1;

            // If there is no right subtree, recur for left subtree
            if (node.Right == null) return FindMinimumDepth(node.Left) + 1;

            // If both left and right children exist, recur for both and take the minimum
            return Math.Min(FindMinimumDepth(node.Left), FindMinimumDepth(node.Right));
        }

        //Diameter of Binary Tree 
        int maxDiameter = 0;
        public int DiameterOfBinaryTree(TNode root)
        {
            LongestPath(root);
            return maxDiameter;
        }

        public int LongestPath(TNode node)
        {
            if (node == null)
                return 0;

            int leftDepth = LongestPath(node.Left);
            int rightDepth = LongestPath(node.Right);

            // Update the maximum diameter (the sum of left and right depths)
            maxDiameter = Math.Max(maxDiameter, leftDepth + rightDepth);

            // Return the height of the current node
            return Math.Max(leftDepth, rightDepth) + 1;
        }

        public TNode MergedTwoTrees(TNode node1, TNode node2)
        {
            if (node1 == null && node2 == null) return null;
            int value = (node1?.Value ?? 0) + (node2?.Value ?? 0);
            TNode resultTree = new TNode(value);

            resultTree.Left = MergedTwoTrees(node1?.Left, node2?.Left);
            resultTree.Right = MergedTwoTrees(node1?.Right, node2?.Right);

            return resultTree;
        }

        public void PrintT(TNode node)
        {
            Console.WriteLine("----------------------------->");
            print2DUtil(node, 0);
        }

        int COUNT = 7;
        private void print2DUtil(TNode root, int space)
        {
            if (root == null)
                return;
            space += COUNT;
            print2DUtil(root.Right, space);
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.Write(root.Value + "\n");
            print2DUtil(root.Left, space);
        }

        List<int> lists = new List<int>();
        public void BTToList(TNode node)
        {
            if (node == null) return;
            lists.Add(node.Value);
            BTToList(node.Left);
            BTToList(node.Right);
        }
        public TNode BTToBST(TNode node)
        {
            BTToList(node);
            lists.Sort();
            return Result(lists, 0, lists.Count - 1);
        }
        public TNode Result(List<int> sorted, int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            int mid = (start + end) / 2;
            TNode nodes = new TNode(sorted[mid]);
            nodes.Left = Result(sorted, start, mid - 1);
            nodes.Right = Result(sorted, mid + 1, end);
            return nodes;
        }
    }
}