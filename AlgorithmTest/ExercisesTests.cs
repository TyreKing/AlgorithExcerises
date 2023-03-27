using AlgorithExcerises;

namespace AlgorithmTest
{
    public class ExercisesTests
    {
        [Fact]
        public void Test_Add()
        {
            int result = Excercises.Add(2, 3);
            Assert.Equal(5, result);


            result = Excercises.Add(89, 1);
            Assert.Equal(90, result);


            result = Excercises.Add(1, 3);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_Check_Even()
        {
            string result = Excercises.Check(4);
            Assert.Equal("Even", result);
        }

        [Fact]
        public void Test_Check_Odd()
        {
            string result = Excercises.Check(3);
            Assert.Equal("Odd", result);
        }

        [Fact]
        public void Test_FindLargest()
        {
            int[] numbers = { 3, 5, 2, 8, 1 };
            int result = Excercises.FindLargest(numbers);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Test_Reverse()
        {
            string result = Excercises.Reverse("hello");
            Assert.Equal("olleh", result);
        }

        [Fact]
        public void Test_IsPalindrome_True()
        {
            bool result = Excercises.IsPalindrome("racecar");
            Assert.True(result);
        }

        [Fact]
        public void Test_IsPalindrome_False()
        {
            bool result = Excercises.IsPalindrome("hello");
            Assert.False(result);
        }
    }
}