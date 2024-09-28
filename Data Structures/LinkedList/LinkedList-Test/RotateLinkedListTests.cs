using LinkedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace LinkedList_Test
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void ZeroK()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(5);
            list.Head.Next = new Node(10);
            list.Head.Next.Next = new Node(15);
            list.Head.Next.Next.Next = new Node(20);

            // Act       
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                list.RotateLeft(list, 0);
                list.PrintList();

                // Assert
                var output = stringWriter.ToString().Replace("\r\n", "");
                Assert.Equal("5 -> 10 -> 15 -> 20 -> null", output);
            }
        }

        [Fact]
        public void KWithlargerValue()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(5);
            list.Head.Next = new Node(10); 
            list.Head.Next.Next = new Node(15);
            list.Head.Next.Next.Next = new Node(20);

            // Act       
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                list.RotateLeft(list, 7);
                list.PrintList();

                // Assert
                var output = stringWriter.ToString().Replace("\r\n", "");
                Assert.Equal("20 -> 5 -> 10 -> 15 -> null", output);
            }
        }
    }
}