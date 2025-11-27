using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.Nth_Prime_Number
{
    internal class NthPrimeNumber
    {
        public NthPrimeNumber() { }

        public Boolean isPrime(int num)
        {
            if (num <= 1)
                return false;
            
            for(int i=2;i<=num/2;i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int getNthPrime(int num)
        {
            int count =0, i=2;

            while(true)
            {
                if(isPrime(i))
                    count++;
                if(count==num)
                    return i;

                i++;

            }
        }
    }
}
