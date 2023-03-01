namespace MathUtils.Operators
{
    internal class Multiplication : Operator
    {
        public Multiplication(string name, int precedence, string icon) : base(name, precedence, icon)
        {
        }

        public override double OperationHandler(double op1, double op2)
        {
            return op1 * op2;
        }
    }
}