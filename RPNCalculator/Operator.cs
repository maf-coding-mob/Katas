using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    class Operator : Expression
    {
        public Operator(string input)
        {
            Value = input;
        }

        public string Value { get; }
    }
}
