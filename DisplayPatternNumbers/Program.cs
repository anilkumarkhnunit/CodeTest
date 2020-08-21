using System;

namespace DisplayPatternNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int j = 1;
            for (int i = 1; j <= 10; i++)
            {
                Console.WriteLine();
                for (int q = i; q > 0; q--)
                {
                    Console.Write(j++ + " ");             
                }
            }
            Console.ReadLine();
        }
    }
}
