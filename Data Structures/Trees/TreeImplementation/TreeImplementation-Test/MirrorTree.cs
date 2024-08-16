using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Test
{
    public class MirrorTree
    {

        [Fact]
        public void MirrorTreeInOrderTraversal()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(4);
            tree.Root.Left = new TNode(2);
            tree.Root.Right = new TNode(6);
            tree.Root.Left.Left = new TNode(1);
            tree.Root.Left.Right = new TNode(3);
            tree.Root.Right.Left = new TNode(5);
            tree.Root.Right.Right = new TNode(7);

            var expectedInOrderBeforeMirror = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var expectedInOrderAfterMirror = new List<int> { 7, 6, 5, 4, 3, 2, 1 };

            // Act
            var inOrderBeforeMirror = tree.InOrderTrav(tree.Root); // This should match the original structure
            tree.Mirror(tree.Root);
            var inOrderAfterMirror = tree.InOrderTrav(tree.Root); // This should match the mirrored structure

            // Assert
            Assert.Equal(expectedInOrderBeforeMirror, inOrderBeforeMirror);
            Assert.Equal(expectedInOrderAfterMirror, inOrderAfterMirror);
        }

        [Fact]
        public void MirrorTreeSingleNodeTree()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(1);

            var expectedInOrderBeforeMirror = new List<int> { 1 };
            var expectedInOrderAfterMirror = new List<int> { 1 };

            // Act
            var inOrderBeforeMirror = tree.InOrderTrav(tree.Root); // Single node tree
            tree.Mirror(tree.Root);
            var inOrderAfterMirror = tree.InOrderTrav(tree.Root);

            // Assert
            Assert.Equal(expectedInOrderBeforeMirror, inOrderBeforeMirror);
            Assert.Equal(expectedInOrderAfterMirror, inOrderAfterMirror);
        }

        [Fact]
        public void MirrorTreeEmptyTree()
        {
            // Arrange
            var tree = new BinaryTree();

            var expectedInOrderBeforeMirror = new List<int>();
            var expectedInOrderAfterMirror = new List<int>();

            // Act
            var inOrderBeforeMirror = tree.InOrderTrav(tree.Root); // Empty tree
            tree.Mirror(tree.Root);
            var inOrderAfterMirror = tree.InOrderTrav(tree.Root);

            // Assert
            Assert.Equal(expectedInOrderBeforeMirror, inOrderBeforeMirror);
            Assert.Equal(expectedInOrderAfterMirror, inOrderAfterMirror);
        }
    }
}