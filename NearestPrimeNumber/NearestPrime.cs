using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.NearestPrimeNumber
{
    internal class NearestPrime
    {
        public NearestPrime() { }

        public Boolean isPrime(int num)
        {
            if(num<=1)
                return false;

            for(int i = 2; i <= num/2; i++)
            {
                if(num%i==0)
                    return false;
            }
            return true;
        }

        public int nearestPrime(int num)
        {
            if (isPrime(num))
                return num;
            int prev = num - 1, next = num + 1;
            while(true)
            {
                if (isPrime(prev))
                    return prev;

                if(isPrime(next))
                    return next;

                prev--;
                next++;
            }
        }
    }
}
