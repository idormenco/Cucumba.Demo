using Cucumba.Demo.Calculator;

namespace Cucumba.Specs.StepDefinitions;

[Binding]
[Scope(Feature = "Calculator divide")]
public class DivisionStepDefinition
{
    private readonly IAmCalculator _calculator = Dear.Calculator;
    private double _result;

    [Given(@"the first number is (.*)")]
    public void GivenTheFirstNumberIs(int firstNumber)
    {
        _calculator.Add(firstNumber);
    }

    [Given(@"the second number is (.*)")]
    public void GivenTheSecondNumberIs(int secondNumber)
    {
        _calculator.DivideBy(secondNumber);
    }

    [When(@"the two numbers are divided")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _result = _calculator.Please();
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(int expectedResult)
    {
        _result.Should().Be(expectedResult);
    }
}