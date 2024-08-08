namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4,2+2);

        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5,2+2);
        }
        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void  MyTheoryTest(int value)
        {
            Assert.True(value % 2 == 1);
        }
    }
}
