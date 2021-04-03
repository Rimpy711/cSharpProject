using System;

namespace cSharpPrime
{
    public class Program
    {

        public static string PrimeFactors(int number)
        {
            // F10
            string res = string.Empty;

            for (int i = 2; i <= number; ++i)
            {
               // res = res + "*";
                while (number % i == 0)
                {
                    res = res + i;
                    number = number / i;
                    if(i<=number)
                    res = res + "*";

                }
            }

            return res;
        }



        static void Main(string[] args)
        {
            // F5
            Console.WriteLine("Enter a number to calclulate Prime Factor: ");
            string n1 = Console.ReadLine();
            int num1 = Int32.Parse(n1);

            Console.WriteLine(PrimeFactors(num1));

            Console.WriteLine("\n\nHave a nice day!");

        
        }
    }
}

