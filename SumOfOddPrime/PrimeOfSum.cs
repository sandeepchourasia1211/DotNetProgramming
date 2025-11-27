using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.SumOfOddPrime
{
    internal class PrimeOfSum
    {

        // check if sum of odd odd digit of a number is prime or not
        public PrimeOfSum() { }

        public Boolean isPrime(int num)
        {
            if (num <=1) 
                return false;

            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public  void sumOfOdd(int num)
        {
            int sum = 0;

            while(num>0)
            {
                int temp=num%10;

                if(temp%2!=0)
                sum+=temp;

                num/=10;
            }
            Console.WriteLine($"Sum of odd digits = {sum}");

            if (isPrime(sum))
                Console.WriteLine("The Sum of odd digit Is Prime.");
            else
                Console.WriteLine("The Sum of odd digit Is NOT Prime.");
        }
    }
}
