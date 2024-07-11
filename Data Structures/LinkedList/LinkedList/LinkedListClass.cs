using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListClass
    {
        public Node Head { get; set; }

        public bool IfInclude(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void RemoveData(int num)
        {
            if (Head == null)
                return;

            if (Head.Data == num)
            {
                Head = Head.Next;
                Console.WriteLine($"The data ({num}) has been removed");
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != num)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
            Console.WriteLine($"The data ({num}) has been removed");
        }

        public void PrintList()
        {
            Node current = Head;
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }
}