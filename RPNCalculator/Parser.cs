using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    class Parser
    {
        public IEnumerable<Expression> Parse(string input)
        {
            return input.Split(' ').Select(Expression.Parse);
        }
    }
}
