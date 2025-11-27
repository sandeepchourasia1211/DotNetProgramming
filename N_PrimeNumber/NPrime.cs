using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.N_PrimeNumber
{
    internal class NPrime
    {
        public NPrime() { }

        public Boolean isPrime(int num)
        {
            if(num<=1)
                return false;

            for(int i = 2; i <= num / 2; i++)
            {
                if(num%i==0)    
                    return false;
            }
            return true;
        }

        public void nPrime(int num)
        {
            int i = 2, count = 0,n=1;
            while(true)
            {
                if (isPrime(i))
                {
                    Console.WriteLine($" The {n} Prime No is- {i}"); 
                    count++;
                    n++;

                }
                if(count==num)
                {                    
                    break;
                }
                i++;

            }
        }
    }
}
