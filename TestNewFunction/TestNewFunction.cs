using TestFunction;

namespace TestNewFunction
{
    public class TestNewFunction
    {
        [Theory]
        [InlineData(-10, -9)]
        [InlineData(-9, -8)]
        [InlineData(0, 1)]
        

        public void TestValidValues(int inputValue, int expectedValue)
        {
           
            Assert.Equal(expectedValue, NewFunction.EquationFunction(inputValue));//expected return value is 1, the answer variable is what is actually returned
        }

        [Theory]
        [InlineData(-15)]
        [InlineData(-11)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(int.MaxValue)]
        public void TestInvalidValues(int inputValue)
        {
            Assert.Throws<Exception>( () => NewFunction.EquationFunction(inputValue) );
        }

    }
}