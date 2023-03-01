namespace MathUtils.Operators
{
    public class Addition : Operator
    {
        public Addition(string name, int precedence, string icon) : base(name, precedence, icon)
        {
        }

        public override double OperationHandler(double op1, double op2)
        {
            return op1 + op2;
        }
    }
}