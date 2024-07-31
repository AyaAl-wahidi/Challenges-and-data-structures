using StackAndQueue.StackAndQueue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.ReverseStackUsingQueue
{
    public class StackWithReverse
    {
        public void ReverseStack(StackClass stClass)
        {
            QueueClass queueClass = new QueueClass();
            while (!stClass.IsEmpty())
            {
                int s = stClass.Pop();
                queueClass.EnQueue(s);
            }

            while (!queueClass.IsEmpty())
            {
                int q = queueClass.DeQueue();
                stClass.Push(q);
            }

            stClass.PrintStack();
        }
    }
}