using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public int Data { get; set; }
        public Node Next { get; set; }

        public Node() 
        {
        }
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
}