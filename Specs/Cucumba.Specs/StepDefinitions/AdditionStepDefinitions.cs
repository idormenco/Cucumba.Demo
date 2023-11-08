using Cucumba.Demo.Calculator;

namespace Cucumba.Specs.StepDefinitions
{
    [Binding]
    [Scope(Feature = "Calculator add")]
    public sealed class AdditionStepDefinitions
    {
        private IAmCalculator _calculator;
        private double _result;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator = Dear.Calculator.Add(number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.Add(number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Please();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}