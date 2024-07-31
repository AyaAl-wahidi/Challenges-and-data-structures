using StackAndQueue.StackAndQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.StackAndQueue
{
    public class QueueClass
    {
        private Node Front;
        private Node Back;

        public QueueClass()
        {
            Front = Back = null;
        }

        // IsEmpty Method => Check If THe Stack Is Null
        public bool IsEmpty()
        {
            return Back == null;
        }

        // EnQueue Method => Add Node To The Front Of The Queue
        public void EnQueue(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                Front = Back = newNode;
            }
            else
            {
                Back.Next = newNode;
                Back = newNode;
            }
        }

        // DeQueue Method => Remove & Return The Front Node From The Queue
        public int DeQueue()
        {
            if (IsEmpty())
            {
                throw new Exception("The Queue Is Empty!");
            }

            int data = Front.Data;
            Front = Front.Next;
            if (Front == null)
            {
                Back = null;
            }
            return data;
        }

        // Peek Method => Return The Front Node From The Queue
        public int Peek()
        {
            return Front.Data;
        }

        // Print Method => To Print The Queue
        public void PrintQueue()
        {
            Node newNode = Front;
            while (newNode != null)
            {
                Console.Write(newNode.Data + " ");
                newNode = newNode.Next;
            }
            Console.WriteLine();
        }
    }
}