using System;
using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void CommonElementsTestCase1()
        {
            // Arrange
            int[] arr1 = { 1, 2, 3, 0 };
            int[] arr2 = { 2, 3, 4, 9 };
            int[] expected = { 2, 3 };

            // Act
            int[] result = Program.CommonElements(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CommonElementsTestCase2()
        {
            // Arrange
            int[] arr1 = { 79, 8, 15 };
            int[] arr2 = { 23, 79, 8 };
            int[] expected = { 79, 8 };

            // Act
            int[] result = Program.CommonElements(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
