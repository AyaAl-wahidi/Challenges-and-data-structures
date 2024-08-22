using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Test
{
    public class LeafSumTree_Test
    {
        [Fact]
        public void LeafSumTreeTest()
        {
            // Arrange
            BinaryTree STree = new BinaryTree();
            STree.Root = new TNode(9);
            STree.Root.Left = new TNode(8);
            STree.Root.Right = new TNode(12);
            STree.Root.Left.Left = new TNode(3);
            STree.Root.Left.Right = new TNode(7);
            STree.Root.Right.Left = new TNode(17);
            STree.Root.Right.Right = new TNode(23);
            STree.Root.Left.Left.Right = new TNode(4);
            // Act
            int sum = STree.LeafSum(STree.Root);
            // Assert
            Assert.Equal(51, sum);
        }

        [Fact]
        public void LeafSumTreeTestWithNegativeValues()
        {
            // Arrange
            BinaryTree STree = new BinaryTree();
            STree.Root = new TNode(9);
            STree.Root.Left = new TNode(8);
            STree.Root.Right = new TNode(12);
            STree.Root.Left.Left = new TNode(3);
            STree.Root.Left.Right = new TNode(-7);
            STree.Root.Right.Left = new TNode(17);
            STree.Root.Right.Right = new TNode(-23);
            STree.Root.Left.Left.Right = new TNode(4);
            // Act
            int sum = STree.LeafSum(STree.Root);
            // Assert
            Assert.Equal(-9, sum);
        }
    }
}
