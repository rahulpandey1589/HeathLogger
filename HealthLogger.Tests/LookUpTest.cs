using Xunit;

namespace HealthLogger.Tests
{
    public class LookUpTest
    {
        public LookUpTest()
        {

        }

        [Fact]
        public void GetAllTest()
        {
            int firstNumber = 10;
            int secondNumber = 10;

            Assert.True(firstNumber == secondNumber);
        }

    }
}
