using System;
using System.Linq;

namespace RPNCalculator
{
    public class RPNCalculator
    {
        public double Evaluate(string input)
        {
            var parser = new Parser();
            var inputs = parser.Parse(input).ToList();
            
            if (inputs.Count == 1)
            {
                return (inputs[0] as Number).Value;
            }

            var numberA = inputs[0] as Number;
            var numberB = inputs[1] as Number;
            var @operator = inputs[2] as Operator;
            var evaluator = new Evaluator();
            var result = evaluator.Compute(numberA, numberB, @operator);
            return result;

        }
    }
}
