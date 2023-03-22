using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
        }

        // Method writes the value of i to the power of 1 through 5
        private static void PowersOf2Until5()
        {
            for(int i = 1; i <= (1 << 5); )
            {
                Console.WriteLine(i);
                i = i << 1;
            }
        }
    }
}
