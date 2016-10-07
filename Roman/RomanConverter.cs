using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    public class RomanConverter
    {
        private Dictionary<int, string> representationMapping = new Dictionary<int, string>
        {
            [1] = "I",
            [2] = "II",
            [3] = "III",
            [4] = "IV",
            [5] = "V",
            [6] = "VI",
            [7] = "VII",
            [8] = "VIII",
            [9] = "IX",
            [10] = "X"
        };

        public string Convert(int arabicNumber)
        {
            if (arabicNumber <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (arabicNumber <= 10)
            {
                return representationMapping[arabicNumber];
            }
            
            var representation = new StringBuilder();
            representation.Append(representationMapping[arabicNumber / 10]);
            representation.Append(representationMapping[arabicNumber % 10]);

            return representationMapping[arabicNumber];
        }
    }
}
