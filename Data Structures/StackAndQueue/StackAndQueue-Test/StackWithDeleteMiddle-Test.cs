using StackAndQueue.DeleteMiddleElement;
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
    public class StackWithDeleteMiddle_Test
    {
        [Fact]
        public void DeleteWithOddStack()
        {
            StackClass stackClass = new StackClass();
            stackClass.Push(10);
            stackClass.Push(20);
            stackClass.Push(30);
            stackClass.Push(40);
            stackClass.Push(50);

            //Act
            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();
            stackWithDeleteMiddle.DeleteMiddle(stackClass);

            // Assert
            Assert.Equal(50, stackClass.Pop());
            Assert.Equal(40, stackClass.Pop());
            Assert.Equal(20, stackClass.Pop());
            Assert.Equal(10, stackClass.Pop());
            Assert.True(stackClass.IsEmpty());
        }

        [Fact]
        public void DeleteWithEvenStack()
        {
            // Arrange
            StackClass stackClass = new StackClass();
            stackClass.Push(10);
            stackClass.Push(20);
            stackClass.Push(30);
            stackClass.Push(40);
            stackClass.Push(50);
            stackClass.Push(60);

            // Act
            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();
            stackWithDeleteMiddle.DeleteMiddle(stackClass);

            // Assert the resulting stack order
            Assert.Equal(60, stackClass.Pop());
            Assert.Equal(50, stackClass.Pop());
            Assert.Equal(40, stackClass.Pop());
            Assert.Equal(20, stackClass.Pop());
            Assert.Equal(10, stackClass.Pop());
            Assert.True(stackClass.IsEmpty());
        }
    }
}