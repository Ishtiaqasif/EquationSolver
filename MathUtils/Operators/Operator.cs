namespace MathUtils
{
    public abstract class Operator
    {
        private readonly string _name;
        private readonly int _precedence;
        private readonly string _icon;

        public Operator(string name, int precedance, string icon)
        {
            _name = name;
            _precedence = precedance;
            _icon = icon;
        }

        public abstract double OperationHandler(double op1, double op2);
    }
}