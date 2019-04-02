using System;
using Xunit;

namespace Calculator.Tests
{
    public class adding_numbers_from_user_input
    {
        [Fact] // Attribute used by Xunit to let it know this is a UNIT TEST
        public void adding_2_and_2_should_be_4()
        {
            // Arrange -- Context -- Given step
            var calculator = new CalculationEngine();
            var input = "2+2";
            var expectedResult = 4;

            // Act -- Do the thing -- When step
            var actualResult = calculator.DoMath(input);

            // Assert -- Checking the result - Then step
            Assert.Equal(expectedResult, actualResult);

        }
        [Fact] 
        public void adding_2_and_5_should_be_7()
        {
            var calculator = new CalculationEngine();
            var input = "2+5";
            var expectedResult = 7;

            var actualResult = calculator.DoMath(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
