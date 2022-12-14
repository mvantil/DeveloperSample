using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Theory]
        [InlineData(4, 24)]
        [InlineData(3, 6)]
        [InlineData(5, 120)]
        [InlineData(1, 1)]
        public void CanGetFactorial(int factorialOf, int factorial)
        {
            Assert.Equal(factorial, Algorithms.GetFactorial(factorialOf));
        }

        [Theory]
        [InlineData("a, b and c", "a", "b", "c")]
        [InlineData("a and c", "a", "c")]
        [InlineData("a", "a")]
        [InlineData("a, b, d, e, f, g and c", "a", "b", "d", "e", "f", "g", "c")]
        public void CanFormatSeparators(string sentence, params string[] words)
        {
            Assert.Equal(sentence, Algorithms.FormatSeparators(words));
        }
    }
}
