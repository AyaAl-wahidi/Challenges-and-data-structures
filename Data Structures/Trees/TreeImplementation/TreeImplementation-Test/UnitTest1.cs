using TreeImplementation;

namespace TreeImplementation_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestPreOrderTraversal()
        {
            // Arrange
            BinaryTree bt = new BinaryTree();
            bt.Root = new TNode(1);
            bt.Root.Left = new TNode(2);
            bt.Root.Right = new TNode(3);
            bt.Root.Left.Left = new TNode(4);
            bt.Root.Left.Right = new TNode(5);

            // Act
            string result = "";
            void CaptureOutput(TNode node)
            {
                if (node == null) return;
                result += node.Value + " ";
                CaptureOutput(node.Left);
                CaptureOutput(node.Right);
            }
            CaptureOutput(bt.Root);

            // Assert
            Assert.Equal("1 2 4 5 3 ", result);
        }

        [Fact]
        public void TestInOrderTraversal()
        {
            // Arrange
            BinaryTree bt = new BinaryTree();
            bt.Root = new TNode(1);
            bt.Root.Left = new TNode(2);
            bt.Root.Right = new TNode(3);
            bt.Root.Left.Left = new TNode(4);
            bt.Root.Left.Right = new TNode(5);

            // Act
            string result = "";
            void CaptureOutput(TNode node)
            {
                if (node == null) return;
                CaptureOutput(node.Left);
                result += node.Value + " ";
                CaptureOutput(node.Right);
            }
            CaptureOutput(bt.Root);

            // Assert
            Assert.Equal("4 2 5 1 3 ", result);
        }

        [Fact]
        public void TestPostOrderTraversal()
        {
            // Arrange
            BinaryTree bt = new BinaryTree();
            bt.Root = new TNode(1);
            bt.Root.Left = new TNode(2);
            bt.Root.Right = new TNode(3);
            bt.Root.Left.Left = new TNode(4);
            bt.Root.Left.Right = new TNode(5);

            // Act
            string result = "";
            void CaptureOutput(TNode node)
            {
                if (node == null) return;
                CaptureOutput(node.Left);
                CaptureOutput(node.Right);
                result += node.Value + " ";
            }
            CaptureOutput(bt.Root);

            // Assert
            Assert.Equal("4 5 2 3 1 ", result);
        }

        [Fact]
        public void TestAddNode()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();

            // Act
            bst.Add(50);
            bst.Add(30);
            bst.Add(70);

            // Assert
            Assert.NotNull(bst.Root);
            Assert.Equal(50, bst.Root.Value);
            Assert.Equal(30, bst.Root.Left.Value);
            Assert.Equal(70, bst.Root.Right.Value);
        }

        [Fact]
        public void TestContainsNode()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(50);
            bst.Add(30);
            bst.Add(70);

            // Act & Assert
            Assert.True(bst.Contains(50));
            Assert.True(bst.Contains(30));
            Assert.True(bst.Contains(70));
            Assert.False(bst.Contains(100));
        }

        [Fact]
        public void TestRemoveNode()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(50);
            bst.Add(30);
            bst.Add(70);
            bst.Add(60);

            // Act
            bst.Root = bst.DeleteRecursively(bst.Root, 70);

            // Assert
            Assert.Null(bst.Root.Right.Right); // The node with value 70 should be removed
            Assert.Equal(60, bst.Root.Right.Value); // The node with value 60 should take its place
        }
    }
}