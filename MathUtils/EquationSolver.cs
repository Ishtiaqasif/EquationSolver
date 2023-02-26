using System;
using System.Collections.Generic;

namespace MathUtils
{
    public class EquationSolver
    {
        private readonly IArithmeticOperation _arithmeticOperation;

        public EquationSolver()
        {
            _arithmeticOperation = new Operation();
        }

        public double Evaluate(string equation)
        {
            Stack<double> operands = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            int index = 0;
            while (index < equation.Length)
            {
                if (char.IsDigit(equation[index]))
                {
                    
                    double operand = 0;
                    while (index < equation.Length && char.IsDigit(equation[index]))
                    {
                        operand = operand * 10 + (equation[index] - '0');
                        index++;
                    }
                    operands.Push(operand);
                }
                else if (equation[index] == '+' || equation[index] == '-' || equation[index] == '*' || equation[index] == '/')
                {
                    while (operators.Count > 0 && ShouldEvaluate(operators.Peek(), equation[index]))
                    {
                        EvaluateTop(operands, operators);
                    }
                    operators.Push(equation[index]);
                    index++;
                }
                else
                {
                    index++;
                }
            }
            while (operators.Count > 0)
            {
                EvaluateTop(operands, operators);
            }
            return operands.Pop();
        }

        private bool ShouldEvaluate(char op1, char op2)
        {
            if (op1 == '*' || op1 == '/')
            {
                return true;
            }
            else if ((op1 == '+' || op1 == '-') && (op2 == '+' || op2 == '-'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EvaluateTop(Stack<double> operands, Stack<char> operators)
        {
            double operand2 = operands.Pop();
            double operand1 = operands.Pop();
            char op = operators.Pop();
            double result;
            switch (op)
            {
                case '+':
                    result = _arithmeticOperation.Add(operand1, operand2);
                    break;

                case '-':
                    result = _arithmeticOperation.Subtract(operand1, operand2);
                    break;

                case '*':
                    result = _arithmeticOperation.Multiply(operand1, operand2);
                    break;

                case '/':
                    result = _arithmeticOperation.Divide(operand1, operand2);
                    break;

                default:
                    throw new ArgumentException("Invalid operator: " + op);
            }
            operands.Push(result);
        }
    }
}