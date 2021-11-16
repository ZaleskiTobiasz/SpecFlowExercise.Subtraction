using TechTalk.SpecFlow;
using FluentAssertions;
using SpecFlowExercise.Subtraction;

namespace SpecFlowExercise.SubtractionTest.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the second number is subtracted from the first number")]
        public void WhenTheSecondNumberIsSubtractedFromTheFirstNumber()
        {
            _result = _calculator.Subtract();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}
