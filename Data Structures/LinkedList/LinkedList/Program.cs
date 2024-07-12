using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            LinkedListClass linkedList = new LinkedListClass
            {
                Head = new Node(0)
            };

            linkedList.Head.Next = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            // IfInclude method
            Console.WriteLine($"Is 3 in the LinkedList? {linkedList.IfInclude(3)}");
            Console.WriteLine($"Is 5 in the LinkedList? {linkedList.IfInclude(5)}");

            // RemoveData method  
            linkedList.RemoveData(4);
            Console.WriteLine($"Is 4 in the LinkedList? {linkedList.IfInclude(4)}");

            // PrintList method
            linkedList.PrintList();
        }
    }
}
