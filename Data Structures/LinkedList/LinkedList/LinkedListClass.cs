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

        public void RemoveDuplicate()
        {
            Node current = Head;
            while (current != null)
            {
                Node index = current; 
                while (index.Next != null)
                {
                    if (index.Next.Data == current.Data)
                    {
                        index.Next = index.Next.Next;
                    }
                    else
                    {
                        index = index.Next;
                    }
                }
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public bool IfInclude(int value)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void RemoveData(int value)
        {
            if (Head == null) return;

            if (Head.Data == value)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == value)
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
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}