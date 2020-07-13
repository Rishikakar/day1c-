using System;

namespace NameLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name you want to enter");
            String str = Console.ReadLine();
            int count = str.Length;
            Console.WriteLine("You have Entered the name as " + str + " and it's length is " + count);

        }
    }
}
