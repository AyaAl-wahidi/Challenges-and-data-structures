using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(5);
            Node node2 = new Node(20);
            Node node3 = new Node(20);
            Node node4 = new Node(10);
            Node node5 = new Node(5);
            Node node6 = new Node(10);

            LinkedListClass linkedList = new LinkedListClass
            {
                Head = new Node(1)
            };

            linkedList.Head.Next = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;

            // IfInclude method
            //Console.WriteLine($"Is 3 in the LinkedList? {linkedList.IfInclude(3)}");
            //Console.WriteLine($"Is 5 in the LinkedList? {linkedList.IfInclude(5)}");

            //// RemoveData method  
            //linkedList.RemoveData(4);
            //Console.WriteLine($"Is 4 in the LinkedList? {linkedList.IfInclude(4)}");

            // Remove the duplicates
            // linkedList.RemoveDuplicate();

            // PrintList method
            // linkedList.PrintList();

            // Merged Two Linked Lists
            LinkedListClass list1 = new LinkedListClass();
            list1.AddLast(1);
            list1.AddLast(3);
            list1.AddLast(5);

            // Create second linked list
            LinkedListClass list2 = new LinkedListClass();
            list2.AddLast(2);
            list2.AddLast(4);
            list2.AddLast(6);

            // Merge the linked lists
            LinkedListClass mergedList = LinkedListClass.MergeTwoLists(list1, list2);

            // Print the merged list
            Console.WriteLine("Merged List:");
            mergedList.PrintList();


            Console.WriteLine("/////////////////// Rotate K To The End Of LinkedList ///////////////////");
            LinkedListClass list3 = new LinkedListClass();
            list3.AddLast(1);
            list3.AddLast(2);
            list3.AddLast(3);
            list3.AddLast(4);
            list3.AddLast(5);

            list3.RotateLeft(list3, 2);
            list3.PrintList();

        }
    }
}