﻿using System;
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
    }
}