using TopAskedQues.NeonCheck;
using TopAskedQues.SpyNumberCheck;
using TopAskedQues.StrongNumberCheck;
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
                Console.WriteLine("Option 12 :Sum of each digit untill getting Single digit");
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
                   
                }
                else if (option == 6)
                {
                    
                }
                else if (option == 7)
                {
                    
                }
                else if (option == 8)
                {
                   
                }
                else if (option == 9)
                {
                  
                }
                else if (option == 10)
                {
                    
                }
                else if (option == 11)
                {
                  
                }
                else if (option == 12)
                {
                   

                }
                else if (option == 13)
                {
                  
                }
                else if (option == 14)
                {
                  
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
