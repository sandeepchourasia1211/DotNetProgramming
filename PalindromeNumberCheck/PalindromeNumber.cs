using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAskedQues.PalindromeNumberCheck
{
    internal class PalindromeNumber
    {
        //A number is a palindrome if its digits are the same when read from left to right as they are from right to left. 
        public PalindromeNumber() { }

        public Boolean isPalindrome(int num)
        {
            int rem=reverse(num);

            return num==rem;
        }

        public int reverse(int num)
        {
            int rev = 0;
            while(num > 0)
            {
                int temp = num % 10;
                rev = rev * 10 + temp;
                num /= 10;

            }
            return rev;
        }
    }
}
