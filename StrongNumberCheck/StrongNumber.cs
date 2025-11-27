using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.StrongNumberCheck
{
    internal class StrongNumber
    {
        //Sum of Factorial of each digit should be equal to original number
        // num=145  , fac=[1=1, 4=24, 5=120] 1+24+120=145 ,  num=fac
        public StrongNumber() { }

        public Boolean isStrong(int num)
        {
            int sum = 0;
            int original = num;

            while (num > 0)
            {
                int temp = num % 10;
                int fact = factorial(temp); 
                sum += fact;
                num/=10;

            }
            return sum==original;


        }

        public int factorial(int num)
        {
            int fact=1;

            for(int i=num;i>0;i--)
            {
                fact *= i;
            }
           return fact;
        }

    }
}
