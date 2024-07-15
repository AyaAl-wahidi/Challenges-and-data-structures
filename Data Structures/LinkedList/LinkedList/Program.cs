using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //5 -> 20 -> 20 -> 10 -> 5 -> 10
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
            linkedList.RemoveDuplicate();

            // PrintList method
            linkedList.PrintList();
        }
    }
}