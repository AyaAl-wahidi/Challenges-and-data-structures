using StackAndQueue.StackAndQueue;

namespace StackAndQueue_Test
{
    public class QueueTest
    {

        [Fact]
        public void QueueCheckEnqueue()
        {
            // Arrange
            QueueClass queueClass = new QueueClass();

            //Act
            queueClass.EnQueue(1);

            // Assert
            Assert.Equal(1, queueClass.Peek());
        }

        [Fact]
        public void QueueCheckDequeue()
        {
            // Arrange
            QueueClass queueClass = new QueueClass();

            //Act
            queueClass.EnQueue(1);
            queueClass.EnQueue(2);
            queueClass.DeQueue();

            // Assert
            Assert.Equal(2, queueClass.Peek());
        }

        [Fact]
        public void QueueCheckIfEmpty()
        {
            // Arrange
            QueueClass queueClass = new QueueClass();

            //Act
            bool ifEmpty = queueClass.IsEmpty();

            // Assert
            Assert.True(ifEmpty);
        }
    }
}