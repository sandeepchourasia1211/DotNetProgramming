using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.HappyNumberCheck
{
    internal class HappyNumber
    {
        //A happy number is a positive integer that, when repeatedly replaced by the sum of the squares of its digits,
        //eventually reaches the number 1. If the process instead enters an endless cycle that does not include 1, the number is considered unhappy (or sad). 
        public HappyNumber() { }

        public Boolean isHappy(int num)
        {
            while (num !=1 && num!=4)
            {
                int sum = 0;
               while (num > 0)
               {
                    int temp = num % 10;                   
                    sum += temp*temp;
                    num /= 10;
               }
                num = sum;
            }
            return num==1;
        }
    }
}
