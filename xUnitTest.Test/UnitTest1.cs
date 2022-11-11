namespace xUnitTest.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void passingTest()
        {
            Assert.Equal(4, add(2, 2));
        }
        [Fact]
        public void failingTest()
        {
            Assert.Equal(5, add(2, 2));
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void IsOddTests(int inp)
        {
            Assert.True(IsOdd(inp));
        }
        int add(int a, int b)
        {
            return a + b;
        }
        bool IsOdd(int a)
        {
            return (a % 2 == 1);
        }
    }
}