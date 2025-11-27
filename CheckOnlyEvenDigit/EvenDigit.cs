using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.CheckOnlyEvenDigit
{
    internal class EvenDigit
    {
        // Check if a number contains only even digit or not
        public EvenDigit() { }

        public Boolean isEven(int num)
        {
            while(num>0)
            {
                
                int temp = num % 10;
                if (temp % 2 != 0)
                    return false;

                num /= 10;
            }
            return true;
        }
            
    }
}
