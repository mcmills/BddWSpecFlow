using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BddWSpecFlow.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator calculator = new Calculator();
        // Adding numbers
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int operand)
        {
            calculator.Enter(operand);
        }
        
        [When(@"I choose add")]
        public void WhenIChooseAdd()
        {
            calculator.Add();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, calculator.Result);
        }

        [When(@"I choose multiply")]
        public void WhenIChooseMultiply()
        {
            calculator.Multiply();
        }

    }
}
