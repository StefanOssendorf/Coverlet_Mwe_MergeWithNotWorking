using ClassLibrary1;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(21, new Class1().Method2());
        }
    }
}
