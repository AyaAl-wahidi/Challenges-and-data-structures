using LinkedList;
using System.Collections.Generic;

namespace LinkedList_Test
{
    public class MergeSortedLinkedListsTest
    {
        [Fact]
        public void CheckListOneIfEmpty()
        {
            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            LinkedListClass list2 = new LinkedListClass();

            list2.Head = new Node(5);
            list2.Head.Next = new Node(10);
            list2.Head.Next.Next = new Node(20);
            list2.Head.Next.Next.Next = new Node(20);

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeTwoLists(list1, list2);

            // Redirect console output
            var st = new StringWriter();
            Console.SetOut(st);
            mergedList.PrintList();
            string actual = st.ToString();

            string expected = "5 -> 10 -> 20 -> 20 -> null\r\n";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckBothListIfEmpty()
        {
            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            LinkedListClass list2 = new LinkedListClass();

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeTwoLists(list1, list2);

            var st = new StringWriter();
            var originalOutput = Console.Out;
            try
            {
                Console.SetOut(st);
                mergedList.PrintList();
            }
            finally
            {
                Console.SetOut(originalOutput);  // Reset the output to the original
            }

            // Redirect console output
            string actual = st.ToString();
            string expected = "null\r\n";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIListsAreMergerd()
        {
            //List 1: Head -> 5 -> 10 -> 15 -> Null
            //List 2: Head-> 2-> 3-> 20->Null

            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            LinkedListClass list2 = new LinkedListClass();

            list1.Head = new Node(5);
            list1.Head.Next = new Node(10);
            list1.Head.Next.Next = new Node(15);

            list2.Head = new Node(2);
            list2.Head.Next = new Node(3);
            list2.Head.Next.Next = new Node(20);

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeTwoLists(list1, list2);

            // Redirect console output
            var st = new StringWriter();
            var originalOutput = Console.Out;
            try
            {
                Console.SetOut(st);
                mergedList.PrintList();
            }
            finally
            {
                Console.SetOut(originalOutput);  // Reset the output to the original
            }

            string actual = st.ToString();
            string expected = "2 -> 3 -> 5 -> 10 -> 15 -> 20 -> null\r\n";

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}