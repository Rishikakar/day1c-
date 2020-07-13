using System;

namespace NumberDivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                    Console.WriteLine(i);
                }
            }
        }
    }
}