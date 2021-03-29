using System;

namespace cSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100;
            for (int j = 1; j <= length; j++)
            {
                Console.Write(j);
                if (j == 100)
                {
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(",");
                }
                if (j % 15 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}