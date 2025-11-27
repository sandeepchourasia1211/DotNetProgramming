using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.CheckAnyOddDigit
{
    internal class OddDigit
    {
        //Check if a Number Contains  any Odd Digit Or Not
        public OddDigit() { }

        public Boolean isOddDigit(int num)
        {
            while (num > 0)
            {
                int temp=num%10;
                if (temp % 2 != 0)
                    return true;

                num /= 10;
            }
            return false;
        }
    }
}
