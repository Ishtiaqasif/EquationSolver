using System;
using System.Collections.Generic;
using System.Text;

namespace MathUtils
{
    public class Operation: IArithmeticOperation
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Subtract(double a, double b)
        {
            if(b == 0) throw new DivideByZeroException();
            return a - b;
        }

    }
}
