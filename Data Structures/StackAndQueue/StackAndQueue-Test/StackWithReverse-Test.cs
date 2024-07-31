using StackAndQueue.ReverseStackUsingQueue;
using StackAndQueue.StackAndQueue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue_Test
{
    public class StackWithReverse_Test
    {
        //1. Test reversing a stack with multiple elements. 2.Test reversing a stack with only one element. 3.Test reversing an empty stack.
        [Fact]
        public void ReverseWithMulipleElements()
        {
            // Arrange
            StackClass stackClass = new StackClass();
            stackClass.Push(10);
            stackClass.Push(10);
            stackClass.Push(20);
            stackClass.Push(20);
            stackClass.Push(30);
            stackClass.Push(30);
            stackClass.Push(40);

            //Act
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.ReverseStack(stackClass);
            int x = stackClass.Peek();

            // Assert
            Assert.Equal(10,x);
        }

        [Fact]
        public void ReverseWithOneElements()
        {
            // Arrange
            StackClass stackClass = new StackClass();
            stackClass.Push(100);

            //Act
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.ReverseStack(stackClass);
            int x = stackClass.Peek();

            // Assert
            Assert.Equal(100, x);
        }

        [Fact]
        public void ReverseEmptyStack()
        {
            // Arrange
            StackClass stackClass = new StackClass();

            //Act
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.ReverseStack(stackClass);

            // Assert
            Assert.True(stackClass.IsEmpty());
        }
    }
}