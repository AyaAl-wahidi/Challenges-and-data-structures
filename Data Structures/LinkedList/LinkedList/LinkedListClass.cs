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

        public void AddLast(int data)
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

        public static LinkedListClass MergeTwoLists(LinkedListClass list1, LinkedListClass list2)
        {
            // Step 1: Check for empty lists
            if (list1.Head == null) return list2;
            if (list2.Head == null) return list1;
            // Step 2: Initialize a dummy node
            Node temp = new Node();
            Node tail = temp;
            Node current1 = list1.Head;
            Node current2 = list2.Head;
            //List 1 : 1  3  5
            //List 2 : 2  4  6
            // Step 3: Merge the lists
            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)// 1 <= 2 true // 3 <=  2 false // 3 <= 4 true // 5<=4  false // 5 <= 6 true 
                {
                    tail.Next = current1; //1 // 3 // 5
                    current1 = current1.Next;// 3 //  5 // null
                }
                else
                {
                    tail.Next = current2; // 2 // 4
                    current2 = current2.Next; // 4 // 6
                }
                tail = tail.Next;// 1  2   3   4  5
            }
            // Step 4: Attach remaining nodes
            tail.Next = (current1 != null) ? current1 : current2; // null else 6
                                                                  // Step 5: Return the merged list
            LinkedListClass mergedList = new LinkedListClass();
            mergedList.Head = temp.Next; // (data.next(daya.next(data,next)))
            return mergedList;
        }

        public LinkedListClass RotateLeft(LinkedListClass list, int k)
        {
            if (list.Head == null || k == 0) return list;

            Node current = list.Head; 

            while (k != 0)
            {
                list.AddLast(current.Data);
                list.RemoveData(current.Data);
                current = current.Next;
                k--;
            }
            return list;
        }
    }
}