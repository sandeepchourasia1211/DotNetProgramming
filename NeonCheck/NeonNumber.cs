using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.NeonCheck
{
    internal class NeonNumber
    {
        // sum of each digit of the square of a number should be equal to original number
        // n= 9  --> square first  9*9=81,  sum   8+1=9
        public NeonNumber() { }

        public Boolean isNeon(int num)
        {
            int sum = 0, sqr = num*num;

            while(sqr>0)
            {
                int temp = sqr % 10;
                sum += temp;
                sqr /= 10;

            }

            return sum == num;
        }
    }
}
