using TopAskedQues.ArmStrongNumberCheck;
using TopAskedQues.CheckAnyOddDigit;
using TopAskedQues.CheckOnlyEvenDigit;
using TopAskedQues.HappyNumberCheck;
using TopAskedQues.N_PrimeNumber;
using TopAskedQues.NearestPrimeNumber;
using TopAskedQues.NeonCheck;
using TopAskedQues.Nth_Prime_Number;
using TopAskedQues.NumberReverse;
using TopAskedQues.PalindromeNumberCheck;
using TopAskedQues.SpyNumberCheck;
using TopAskedQues.StrongNumberCheck;
using TopAskedQues.SumDigitUntillSingle;
using TopAskedQues.SumOfOddPrime;

namespace TopAskedQues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat;
            do
            {
                Console.WriteLine("------------ MENU ------------");
                Console.WriteLine("Option 1 : Check the Given No is Spy Or Not");
                Console.WriteLine("Option 2 : Check the Given No is Neon Or Not");
                Console.WriteLine("Option 3 : Sum of Odd digit is Prime or Not");
                Console.WriteLine("Option 4 : Check the Given No is Strong Or Not");
                Console.WriteLine("Option 5 : Reverse The Given number");
                Console.WriteLine("Option 6 : Check the Given No is Palindrome Or Not");
                Console.WriteLine("Option 7 : Check the Given No contains Only Even digit Or Not");
                Console.WriteLine("Option 8 : Check the Given No contains Any Odd digit Or Not");
                Console.WriteLine("Option 9 : Check the Given No is ArmStrong Or Not");
                Console.WriteLine("Option 10 :Print N Prime Number");
                Console.WriteLine("Option 11 :Print Nth Prime Number");
                Console.WriteLine("Option 12 :Sum of each digit until getting Single digit");
                Console.WriteLine("Option 13 : Check the Given No is Happy Number Or Not");
                Console.WriteLine("Option 14 : Print Nearest Prime");
                Console.WriteLine("------------------------------");

                Console.Write("Please choose an option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (option == 1)
                {
                    printSpy();
                }
                else if (option == 2)
                {
                    printNeon();
                }
                else if (option == 3)
                {
                    printPrime();
                }
                else if (option == 4)
                {
                    printStrong();
                }
                else if (option == 5)
                {
                    printReverse();
                }
                else if (option == 6)
                {
                    printPalindrome();
                }
                else if (option == 7)
                {
                    printEvenOrNot();   
                }
                else if (option == 8)
                {
                   printOddorNot();
                }
                else if (option == 9)
                {
                    printArmStrong();
                }
                else if (option == 10)
                {
                    printN_Prime();
                }
                else if (option == 11)
                {
                    printNthPrime();
                  
                }
                else if (option == 12)
                {
                    printSumOfDigit();

                }
                else if (option == 13)
                {
                    printHappyNum();
                }
                else if (option == 14)
                {
                    printNearestPrime();
                }
                else
                {
                    Console.WriteLine("Invalid option! Try again.");
                }

                Console.WriteLine();
                Console.Write("Do you want to continue? (y/n): ");
                string ans = Console.ReadLine();

                repeat = ans.ToLower() == "y";

                Console.WriteLine();

            } while (repeat);

        }

        private static void printNearestPrime()
        {
            Console.Write("Enter The Number To get Nearest prime Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            NearestPrime nearest = new NearestPrime();
            int res=nearest.nearestPrime(num);
            Console.WriteLine($"The Nearest Prime of {num} is {res}");

        }

        private static void printHappyNum()
        {

            Console.Write("Enter The Number To check Happy Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            HappyNumber happy = new HappyNumber();
            bool res=happy.isHappy(num);

            if (res)
                Console.WriteLine($"The {num} is Happy Number");
            else
                Console.WriteLine($"The {num} is Not Happy Number");
        }

        private static void printSumOfDigit()
        {
            Console.Write("Enter The Number To Get Single Digit : ");
            int num = Convert.ToInt32(Console.ReadLine());

            UntillSingleDigit untillSingle=new UntillSingleDigit();
            int res = untillSingle.sumOfDigit(num);
            Console.WriteLine($"The Single digit of {num} is {res}");
        }

        private static void printNthPrime()
        {

            Console.Write("Enter The Nth Times to Print Prime Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            NthPrimeNumber nthPrime = new NthPrimeNumber();
            int res=nthPrime.getNthPrime(num);

            Console.WriteLine($"The {num} place prime number is {res}");
        }

        private static void printN_Prime()
        {
            Console.Write("Enter The Times to Print Prime Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            NPrime nP = new NPrime();
            nP.nPrime(num);
        }

        private static void printArmStrong()
        {
            Console.WriteLine("Enter The Number to Check Armstrong : ");
            int num = Convert.ToInt32(Console.ReadLine());

            ArmStrongNumber armStrongNumber=new ArmStrongNumber();
            bool res=armStrongNumber.isArmStrong(num);

            if (res)
                Console.WriteLine($"The {num} is ArmStrong Number");
            else
                Console.WriteLine($"The {num} is Not ArmStrong Number");
        }

        private static void printOddorNot()
        {
            Console.WriteLine("Enter The Number to Check If Any Odd Digit present : ");
            int num = Convert.ToInt32(Console.ReadLine());

            OddDigit oddDigit=new OddDigit();
            bool res=oddDigit.isOddDigit(num);

            if (res)
                Console.WriteLine($"The {num} Contains Odd Digits");
            else
                Console.WriteLine($"The {num} does not Contains any Odd Digits");
        }

        private static void printEvenOrNot()
        {

            Console.WriteLine("Enter The Number to Check If Only Even Digit present : ");
            int num = Convert.ToInt32(Console.ReadLine());

            EvenDigit evenDigit = new EvenDigit();
            bool res=evenDigit.isEven(num);

            if (res)
                Console.WriteLine($"The {num} Contains only Even Digits");
            else
                Console.WriteLine($"The {num} does not Contains only Even Digits");

        }

        private static void printPalindrome()
        {
            Console.WriteLine("Enter The Number to Check Palindrome : ");
            int num = Convert.ToInt32(Console.ReadLine());

            PalindromeNumber palindromeNumber = new PalindromeNumber();
            bool res=palindromeNumber.isPalindrome(num);

            if (res)
                Console.WriteLine($"The {num} is Palindrome Number");
            else
                Console.WriteLine($"The {num} is Not palindrome Number");
        }

        private static void printReverse()
        {
            Console.WriteLine("Enter The Number to Check Strong : ");
            int num = Convert.ToInt32(Console.ReadLine());

            ReverseNumber reverseNumber = new ReverseNumber();
            int res= reverseNumber.reverse(num);
            Console.WriteLine($"The reverse of {num} is {res}");
        }

        private static void printStrong()
        {
            Console.WriteLine("Enter The Number to Check Strong : ");
            int num = Convert.ToInt32(Console.ReadLine());

            StrongNumber strongNumber = new StrongNumber();
            bool res=strongNumber.isStrong(num);

            if(res)
                Console.WriteLine($"The {num} is Strong Number");
            else
                Console.WriteLine($"The {num} is Not Strong Number");

        }

        private static void printPrime()
        {
            Console.WriteLine("Enter The Number to Check Prime : ");
            int num = Convert.ToInt32(Console.ReadLine());

            PrimeOfSum primeOfSum = new PrimeOfSum();
            primeOfSum.sumOfOdd(num);
        }

        private static void printNeon()
        {
            Console.WriteLine("Enter The Number to Check Neon : ");
            int num = Convert.ToInt32(Console.ReadLine());

            NeonNumber neonNumber = new NeonNumber();
            bool res = neonNumber.isNeon(num);

            if(res)
                Console.WriteLine($"The {num} is Neon Number");
            else
                Console.WriteLine($"The {num} is Not Neon Number");

        }

        public static void printSpy()
        {
            Console.WriteLine("Enter The Number to Check Spy : ");
            int num=Convert.ToInt32(Console.ReadLine());

            SpyNumber sN = new SpyNumber();
            bool res=sN.isSpy(num);

            if (res)
                Console.WriteLine($"The {num} is Spy Number");
            else
                Console.WriteLine($"The {num} is Not Spy Number");
        }
    }
}
