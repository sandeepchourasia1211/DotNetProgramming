using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.NumberReverse
{
    internal class ReverseNumber
    {
        public ReverseNumber() { }

        public int reverse(int num)
        {
            int rev = 0;
            while(num>0)
            {
                int temp = num % 10;
                rev=rev*10+temp;

                num/=10;
            }
            return rev;
        }
    }
}
