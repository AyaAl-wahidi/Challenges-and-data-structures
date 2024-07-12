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

        public LinkedListClass()
        {
            Head = null;
        }

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

        public void RemoveData(int data)
        {
            if (Head == null)
                return;

            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
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