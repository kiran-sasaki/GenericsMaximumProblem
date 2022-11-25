using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberGeneric
{
    public class CheckMaximumNumber
    {
        public static int MaximumIntigerNumber(int firstValue, int SecondValue, int ThirdValue)
        {
            //Finding Largest int using CompareTo function
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(ThirdValue) > 0)
            {
                return firstValue;
            }
            if (SecondValue.CompareTo(firstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(firstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
            {
                return ThirdValue;
            }
            return firstValue;
        }
    }
}
