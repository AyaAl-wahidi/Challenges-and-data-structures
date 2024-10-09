using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Test
{
    public class MinimumDepthTests
    {
        [Fact]
        public void EmptyTree()
        {
            // Arrange
            TNode root = null;
            BinaryTree Btree3 = new BinaryTree();

            // Act
            var result = Btree3.FindMinimumDepth(root);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void MultipleNodes()
        {
            // Arrange
            BinaryTree Btree3 = new BinaryTree();
            var root = new TNode(1);
            root.Left = new TNode(2);
            root.Right = new TNode(3);
            root.Left.Left = new TNode(4);
            root.Right.Right = new TNode(5); 

            // Act
            var result = Btree3.FindMinimumDepth(root);

            // Assert
            Assert.Equal(2, result);
        }
    }
}