using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Test
{
    public class RightViewtest
    {
        [Fact]
        public void TestCorrectRight()
        {
            //Arrange
            BinaryTree Btree5 = new BinaryTree();
            Btree5.Root = new TNode(2);
            Btree5.Root.Left = new TNode(3);
            Btree5.Root.Right = new TNode(5);
            Btree5.Root.Left.Left = new TNode(4);
            Btree5.Root.Right.Right = new TNode(6);
            Btree5.Root.Left.Left.Right = new TNode(7);

            using (var stringWriter = new StringWriter())
            {
                //Act
                Console.SetOut(stringWriter);
                Btree5.PrintRightView(Btree5.Root);  // Output: 2 5 6 7
                // Assert
                var output = stringWriter.ToString().Replace("\r\n", "");
                Assert.Equal("2567", output);
            }
        }
        [Fact]
        public void TestRightSide()
        {
            //Arrange
            BinaryTree Btree5 = new BinaryTree();
            Btree5.Root = new TNode(2);
            Btree5.Root.Right = new TNode(5);
            Btree5.Root.Right.Right = new TNode(6);

            using (var stringWriter = new StringWriter())
            {
                //Act
                Console.SetOut(stringWriter);
                Btree5.PrintRightView(Btree5.Root);  // Output: 2 5 6 
                // Assert
                var output = stringWriter.ToString().Replace("\r\n", "");
                Assert.Equal("256", output);
            }
        }
    }
}