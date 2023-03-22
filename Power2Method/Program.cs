using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // Method writes the value of i to the power of 1 through 5
        private static void PowersOf2Until5()
        {
            for(int i = 1; i <= (1 << 5); i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
