namespace MathUtils.Operators
{
    internal class Subtraction : Operator
    {
        public Subtraction(string name, int precedence, string icon) : base(name, precedence, icon)
        {
        }

        public override double OperationHandler(double op1, double op2)
        {
            return op1 - op2;
        }
    }
}