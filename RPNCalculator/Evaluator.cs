using System;

namespace RPNCalculator
{
    class Evaluator
    {
        public double Compute(Number numberA, Number numberB, Operator @operator)
        {
            if (@operator.Value == "+")
            {
                return numberA.Value + numberB.Value;
            }
            if (@operator.Value == "-")
            {
                return numberA.Value - numberB.Value;
            }
            if (@operator.Value == "*")
            {
                return numberA.Value * numberB.Value;
            }
            if (@operator.Value == "/")
            {
                return numberA.Value / numberB.Value;
            }
            throw new Exception();
        }
    }
}
