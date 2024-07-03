using Reverse_Words;

namespace Reverse_Words_Test
{
    public class UnitTest1
    {
        [Fact]
        public void ReverseWordsExample1()
        {
            // Arrange
            string input1 = "csharp is programming language";
            string Output1 = "language programming is csharp";

            // Act
            string result1 = Program.ReverseWords(input1);

            // Assert
            Assert.Equal(Output1, result1);
        }

        [Fact]
        public void ReverseWordsExample2()
        {
            // Arrange
            string input2 = "Reverse the words in this sentence";
            string Output2 = "sentence this in words the Reverse";

            // Act
            string result2 = Program.ReverseWords(input2);

            // Assert
            Assert.Equal(Output2, result2);
        }

        [Fact]
        public void ReverseWordsExample3()
        {
            // Arrange
            string input3 = "challenges and data structures";
            string Output3 = "structures data and challenges";

            // Act
            string result3 = Program.ReverseWords(input3);

            // Assert
            Assert.Equal(Output3, result3);
        }
    }
}