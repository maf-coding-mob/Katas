using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == String.Empty)
            {
                return 0;
            }
            string[] digits = GetDigits(numbers);
            var result = SumDigits(digits);
            return result;
        }

        private string[] GetDigits(string numbers)
        {
            if (Regex.IsMatch(numbers, "^//.{1}\n.*?"))
            {
                var delimiter = Regex.Match(numbers, "^//(?<DELIMITER>.{1})\n.*?").Groups["DELIMITER"].Value;
                numbers = numbers.Split(new[] { "\n" }, StringSplitOptions.None)[1];
                return numbers.Split(new[] { delimiter }, StringSplitOptions.None);
            }
            return numbers.Split(new[] { ",", "\n" }, StringSplitOptions.None);
        }
        private int SumDigits(string[] digits)
        {
            return digits.Sum(item => Int32.Parse(item));
        }

    }
}
