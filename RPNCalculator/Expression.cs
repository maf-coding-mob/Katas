using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    class Expression
    {
        public static Expression Parse(string input)
        {
            double number;
            if (double.TryParse(input, out number))
            {
                return new Number(number);
            }
            return new Operator(input);
        }
    }
}
