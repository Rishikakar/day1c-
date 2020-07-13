using System;

namespace greatestnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            String str = Console.ReadLine();
            String[] ch = str.Split(',');
            int Maximum = Convert.ToInt32(ch[0]);
            for (int i = 1; i < ch.Length; i++)
            {
                if (Convert.ToInt32(ch[i]) > Maximum)
                {
                    Maximum = Convert.ToInt32(ch[i]);
                }
            }
            Console.WriteLine(Maximum);



        }
    }
}