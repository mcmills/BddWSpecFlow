Feature: Calculator
Rules for basic addition:
- Only non-negative numbers
- The operator has to be specified after both operands have been enter

@basic
Scenario: Add two numbers
	Given I have entered 5 into the calculator
	And I have entered 7 into the calculator
	When I choose add
	Then the result should be 12

Scenario: Multiply two numbers
	Given I have entered 2 into the calculator
	And I have entered 3 into the calculator
	When I choose multiply
	Then the result should be 6