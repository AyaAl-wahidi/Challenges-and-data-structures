using StackAndQueue.StackAndQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : StackClass
    {
        public void DeleteMiddle(StackClass stackClass)
        {
            if (stackClass.IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            int count = stackClass.Count();
            int midIndex = (count % 2 == 0) ? (count / 2) - 1 : count / 2;
            
            StackClass tempStack = new StackClass();

            // Move elements to tempStack until reaching the middle element
            for (int i = 0; i <= midIndex; i++)
            {
                tempStack.Push(stackClass.Pop());
            }

            stackClass.Pop();

            while (!tempStack.IsEmpty())
            {
                stackClass.Push(tempStack.Pop());
            }
        }
    }
}