using System;

namespace cSharpException
{
    class Program
    {
        static void Main(string[] args)

        { 
            Console.WriteLine("Enter a number between 0 and 255: ");
            string n1 = Console.ReadLine();

            Console.WriteLine("Enter another number between 0 and 255: ");
            string n2 = Console.ReadLine();

            try
            {
                int num1 = Int32.Parse(n1);
                int num2 = Int32.Parse(n2);

                if (!(num1 >= 0 && num1 <= 255) || !(num2 >= 0 && num2 <= 255))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nArgumentOutOfRangeException: Number(s) is out of range");
            }


            Console.WriteLine("Hello World!");
        }
}
}

            