using System;

namespace Ret3rdWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence");
            string s = Console.ReadLine();
            string[] sp = s.Split(" ");
            Console.WriteLine("third word is " + sp[2]);
        }
    }
}
