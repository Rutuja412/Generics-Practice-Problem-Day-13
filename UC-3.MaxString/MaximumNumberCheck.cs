using System;
using System.Collections.Generic;
using System.Text;

namespace UC_3.MaxString
{
     class MaximumNumberCheck
    {
        public static string MaximumStringNumber(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)

            {
                return firststring;
            }
            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0)
            {
                return secondstring;
            }
            if (thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) > 0)
            {
                return thirdstring;
            }
            throw new Exception("firstNumber,second Number & third Number are same");
        }
    }
}

