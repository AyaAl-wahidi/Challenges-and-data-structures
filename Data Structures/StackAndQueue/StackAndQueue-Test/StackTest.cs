using StackAndQueue.StackAndQueue;

namespace StackAndQueue_Test
{
    public class StackTest
    {

        [Fact]
        public void StackCheckPush()
        {
            // Arrange
            StackClass stackClass = new StackClass();

            //Act
            stackClass.Push(1);

            // Assert
            Assert.Equal(1, stackClass.Peek());
        }

        [Fact]
        public void StackCheckPop()
        {
            // Arrange
            StackClass stackClass = new StackClass();

            //Act
            stackClass.Push(1);
            stackClass.Push(2);
            stackClass.Pop();

            // Assert
            Assert.Equal(1, stackClass.Peek());
        }

        [Fact]
        public void StackCheckIsEmpty()
        {
            // Arrange
            StackClass stackClass = new StackClass();

            //Act
            bool ifEmbty = stackClass.IsEmpty();

            // Assert
            Assert.True(ifEmbty);
        }
    }
}