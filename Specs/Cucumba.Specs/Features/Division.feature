Feature: Calculator divide

Scenario Outline: Division
    Given the first number is <First>
    And the second number is <Second>
    When the two numbers are divided
    Then the result should be <Result>
Examples:
    | First | Second | Result |
    |  6    |  3     |  2     | 
    |  8    |  4     |  2     | 
    |  1    |  1     |  1     | # element neutru
    | 15    | -3     | -5     |