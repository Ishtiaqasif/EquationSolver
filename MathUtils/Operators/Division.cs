using System;

namespace MathUtils.Operators
{
    internal class Division : Operator
    {
        public Division(string name, int precedence, string icon) : base(name, precedence, icon)
        {
        }

        public override double OperationHandler(double op1, double op2)
        {
            if (op2 == 0)
            {
                throw new DivideByZeroException();
            }
            return op1 / op2;
        }
    }
}