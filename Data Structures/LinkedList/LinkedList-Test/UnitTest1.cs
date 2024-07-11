using LinkedList;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace LinkedList_Test
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveNodeTest()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(5);
            list.Head.Next = new Node(10);
            list.Head.Next.Next = new Node(20);
            list.Head.Next.Next.Next = new Node(30);

            // Act
            list.RemoveData(10);

            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                list.PrintList();

                // Assert
                var output = stringWriter.ToString();
                Assert.Equal("Head -> 5 -> 20 -> 30 -> Null\n", output);
            }

            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        }

        [Fact]
        public void PrintListTest()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(5);
            list.Head.Next = new Node(10);
            list.Head.Next.Next = new Node(20);
            list.Head.Next.Next.Next = new Node(30);

            // Act
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                list.PrintList();

                // Assert
                var output = stringWriter.ToString();
                Assert.Equal("Head -> 5 -> 10 -> 20 -> 30 -> Null\n", output);
            }

            // Reset the console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        }
    }
}