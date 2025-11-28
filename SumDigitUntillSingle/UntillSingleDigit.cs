using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.SumDigitUntillSingle
{
    internal class UntillSingleDigit
    {
        // Sum of Each Digit of a number untill getting a single Digit.
        
        public UntillSingleDigit() { }

        public int sumOfDigit(int num)
        {
          

            while (num > 9)
            {
                int sum = 0;
                while (num > 0)
                {
                    int temp = num % 10;
                    sum += temp;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }
    }
}
