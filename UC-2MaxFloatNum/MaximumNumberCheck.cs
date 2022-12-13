using System;
using System.Collections.Generic;
using System.Text;

namespace UC_2MaxFloatNum
{
    public class MaximumNumberCheck
    {
        public static double MaximumFloatNumber(double firstvalue, double secondvalue, double thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            throw new Exception("firstNumber,second Number & third Number are same");
        }
    }
}

