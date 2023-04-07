using AlgorithExcerises;

namespace AlgorithmTest
{
    public class ExercisesTests
    {
        [Fact]
        public void SumOfNFor_Should_Return_15_When_Given_5()
        {
            // Arrange
            int n = 5;

            // Act
            int result = Excercises.SumOfNFor(n);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void SumOfNForeach_Should_Return_15_When_Given_5()
        {
            // Arrange
            int n = 5;

            // Act
            int result = Excercises.SumOfNForeach(n);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void SumOfNWhile_Should_Return_15_When_Given_5()
        {
            // Arrange
            int n = 5;

            // Act
            int result = Excercises.SumOfNWhile(n);

            // Assert
            Assert.Equal(15, result);
        }
    }
}