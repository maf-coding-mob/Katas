using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    class Number : Expression
    {
        public Number(double number)
        {
            Value = number;
        }

        public double Value { get; }
    }
}
