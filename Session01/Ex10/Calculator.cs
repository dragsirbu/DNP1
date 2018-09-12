using System;

namespace Ex10
{
    class Calculator
    {
        private char userOperator;
        double firstNumber;
        double secondNumber;

        public Calculator(double firstNumber, double secondNumber, char userOperator) {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.userOperator = userOperator;
        }

        public String getResult() {
            switch (userOperator)
            {
                case '+':
                    return (firstNumber + secondNumber)+"";
                    // break;
                case '-':
                    return (firstNumber - secondNumber)+"";
                    // break;
                case '*':
                    return (firstNumber * secondNumber)+"";
                    // break;
                case '/':
                    {
                        if (secondNumber == 0)
                            return "error";
                        else
                            return (firstNumber / secondNumber)+"";
                        // break;
                    }
                default:
                    return "Invalid operator";
                    // break;
            }
        }
    }
}

