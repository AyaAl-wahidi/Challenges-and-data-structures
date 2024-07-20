using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Test
{
    public class RemoveDuplicateTest
    {
        [Fact]
        public void RemoveDuplicatesOnlyCase()
        {
            //Arrange
            LinkedListClass list = new LinkedListClass();

            list.Head = new Node(5);
            list.Head.Next = new Node(10);
            list.Head.Next.Next = new Node(20);
            list.Head.Next.Next.Next = new Node(20);

            //Act
            list.RemoveDuplicate();
            string Expected = "5 -> 10 -> 20 -> null\r\n";

            //Act 
            list.RemoveDuplicate();
            var input = new StringWriter();
            Console.SetOut(input);
            list.PrintList();
            string Actual = input.ToString();

            //Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void CheckAllDuplicates()
        {
            //Arrange
            LinkedListClass list = new LinkedListClass();

            list.Head = new Node(5);
            list.Head.Next = new Node(5);
            list.Head.Next.Next = new Node(5);
            list.Head.Next.Next.Next = new Node(5);

            //Act
            list.RemoveDuplicate();
            string Expected = "5 -> null\r\n";

            //Act 
            list.RemoveDuplicate();
            var input = new StringWriter();
            Console.SetOut(input);
            list.PrintList();
            string Actual = input.ToString();

            //Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void CheckNoDuplicates()
        {
            //Arrange
            LinkedListClass list = new LinkedListClass();

            list.Head = new Node(5);
            list.Head.Next = new Node(50);
            list.Head.Next.Next = new Node(55);
            list.Head.Next.Next.Next = new Node(500);

            //Act
            list.RemoveDuplicate();
            string Expected = "5 -> 50 -> 55 -> 500 -> null\r\n";

            //Act 
            list.RemoveDuplicate();
            var input = new StringWriter();
            Console.SetOut(input);
            list.PrintList();
            string Actual = input.ToString();

            //Assert
            Assert.Equal(Expected, Actual);
        }

    }
}