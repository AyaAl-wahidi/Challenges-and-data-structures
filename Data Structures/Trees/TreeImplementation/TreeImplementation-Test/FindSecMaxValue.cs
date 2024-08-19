using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Test
{
    public class FindSecMaxValue
    {
        [Fact]
        public void TestFindSecondMax()
        {
            // Arrange
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new TNode(10);
            Btree2.Root.Left = new TNode(5);
            Btree2.Root.Right = new TNode(20);
            Btree2.Root.Left.Left = new TNode(3);
            Btree2.Root.Left.Right = new TNode(7);
            Btree2.Root.Right.Left = new TNode(15);
            Btree2.Root.Right.Right = new TNode(25);

            int expected = 20;

            // Act
            int secondMax = Btree2.FindSecondMax(Btree2.Root);

            // Assert
            Assert.Equal(expected, secondMax);
        }

        [Fact]
        public void TestSingleNode()
        {
            // Arrange
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new TNode(10);

            int expected = 10;

            // Act
            int secondMax = Btree2.FindSecondMax(Btree2.Root);

            // Assert
            Assert.Equal(expected, secondMax);
        }

        [Fact]
        public void TestNegativeValues()
        {
            // Arrange
            BinaryTree Btree1 = new BinaryTree();
            Btree1.Root = new TNode(10);
            Btree1.Root.Left = new TNode(5);
            Btree1.Root.Right = new TNode(20);
            Btree1.Root.Left.Left = new TNode(-3);
            Btree1.Root.Left.Right = new TNode(7);
            Btree1.Root.Right.Left = new TNode(15);
            Btree1.Root.Right.Right = new TNode(25);

            int expected = 20;

            // Act
            int secondMax = Btree1.FindSecondMax(Btree1.Root);

            // Assert
            Assert.Equal(expected, secondMax);
        }
    }
}