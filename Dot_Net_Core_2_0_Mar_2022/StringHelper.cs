using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Core_2_0_Mar_2022
{
    static class StringHelper
    {
        public static string FlipFirstLetterCase(this string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                char[] charArr = input.ToCharArray();

                charArr[0] = char.IsUpper(charArr[0]) ? char.ToLower(charArr[0])
                    : char.ToUpper(charArr[0]);

                return new string(charArr);
            }

            return input;
        }
    }
}
