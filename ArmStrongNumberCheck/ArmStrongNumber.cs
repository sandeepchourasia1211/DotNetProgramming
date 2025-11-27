using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.ArmStrongNumberCheck
{
    internal class ArmStrongNumber
    {
        //An Armstrong number is a number that is equal to the sum of its own digits, each raised to the power of the total number of digits.
        //153 is a 3-digit number, and  (1^{3}+5^{3}+3^{3}=1+125+27=153
        public ArmStrongNumber() { }

        public Boolean isArmStrong(int num)
        {
            String s = num +"";
            int len=s.Length, orininal=num ,sum=0;

            while(num>0)
            {
                int prod = 1;
                int temp = num % 10;

                for(int i=0;i<len;i++)
                {
                    prod *= temp;
                }
                sum += prod;

                num/=10;    
            }
           return orininal == sum;
        }

    }
}
