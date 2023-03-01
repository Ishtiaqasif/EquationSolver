using System;
using System.Collections.Generic;
using System.Text;

namespace MathUtils.Operators
{
    public class SupportedOperators
    {
        public SortedDictionary<string, Operator> Operators { get; }
        public SupportedOperators() {

            Operators = new SortedDictionary<string, Operator>
            {
                { "+", new Addition("Addition", 2, "+") },
                { "-", new Subtraction("Subtraction", 2, "-") },
                { "*", new Multiplication("Multiplication", 1, "*") },
                { "/", new Division("Division", 1, "/") }
            };

        }
    }
}
