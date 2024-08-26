using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Test
{
    public class LargestLevelValue_Test
    {
        [Fact]
        public void LeafSumTreeTest()
        {
            //Arrange
            BinaryTree largeTree = new BinaryTree();
            largeTree.Root = new TNode(5);
            largeTree.Root.Left = new TNode(13);
            largeTree.Root.Right = new TNode(7);
            largeTree.Root.Left.Left = new TNode(3);
            largeTree.Root.Left.Right = new TNode(7);
            largeTree.Root.Right.Left = new TNode(12);
            largeTree.Root.Right.Right = new TNode(20);
            largeTree.Root.Left.Left.Left = new TNode(1);
            largeTree.Root.Left.Left.Right = new TNode(4);
            largeTree.Root.Right.Left.Right = new TNode(11);

            //Act
            List<int> largestValues = largeTree.LargestValueEachLevel();
            int Expected = 49;
            int actual = largestValues.Sum();

            //Assert
            Assert.Equal(Expected, actual);
        }
    }
}