using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.SpyNumberCheck
{
    internal class SpyNumber
    {
        // Spy No-- Sum of Each Digit Should be Equal to product of Each Digit

        public SpyNumber() { }

        public Boolean isSpy(int num)
        {
            int sum = 0; int prod = 1;

            while (num>0)
            {
                int temp = num % 10;

                sum += temp;
                prod *= temp;

                num /= 10;
            }
            return sum == prod;
        }
    }
}
