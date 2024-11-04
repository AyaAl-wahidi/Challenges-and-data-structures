using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Test
{
    public class BTtoBST_Test
    {
        // Helper method to get an inorder traversal of the tree for validation.
        private List<int> InOrderTraversal(TNode node)
        {
            var result = new List<int>();
            if (node == null)
            {
                return result;
            }
            result.AddRange(InOrderTraversal(node.Left));
            result.Add(node.Value);
            result.AddRange(InOrderTraversal(node.Right));
            return result;
        }

        [Fact]
        public void ConvertBinaryTreeToBST_GeneralCase_ShouldReturnBST()
        {
            // Arrange
            var root = new TNode(10);
            root.Left = new TNode(30);
            root.Right = new TNode(15);
            root.Left.Left = new TNode(20);
            root.Right.Right = new TNode(5);

            var btToBSTConverter = new BinaryTree();

            // Act
            var bstRoot = btToBSTConverter.BTToBST(root);

            // Assert
            var inOrderValues = InOrderTraversal(bstRoot);
            var expectedValues = new List<int> { 5, 10, 15, 20, 30 };
            Assert.Equal(expectedValues, inOrderValues);
        }

        [Fact]
        public void ConvertBinaryTreeToBST_LeftSkewedTree_ShouldReturnBST()
        {
            // Arrange
            var root = new TNode(10);
            root.Left = new TNode(20);
            root.Left.Left = new TNode(30);

            var btToBSTConverter = new BinaryTree();

            // Act
            var bstRoot = btToBSTConverter.BTToBST(root);

            // Assert
            var inOrderValues = InOrderTraversal(bstRoot);
            var expectedValues = new List<int> { 10, 20, 30 }; 
            Assert.Equal(expectedValues, inOrderValues);
        }

        [Fact]
        public void ConvertBinaryTreeToBST_RightSkewedTree_ShouldReturnBST()
        {
            // Arrange
            var root = new TNode(10);
            root.Right = new TNode(20);
            root.Right.Right = new TNode(30);

            var btToBSTConverter = new BinaryTree();

            // Act
            var bstRoot = btToBSTConverter.BTToBST(root);

            // Assert
            var inOrderValues = InOrderTraversal(bstRoot);
            var expectedValues = new List<int> { 10, 20, 30 };
            Assert.Equal(expectedValues, inOrderValues);
        }
    }
}