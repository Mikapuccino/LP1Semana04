using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for a number for later use
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);

            // Calls method passing the number the user gave as the argument
            PowersOf2UntilN(nCount);
            PowersOf2UntilN(nCount);
        }

        // Method writes the value of i to the power of 1 through 5
        private static void PowersOf2Until5()
        {
            for(int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        // Method writes the value of i to the power of 1 through n,
        // n being specified by the user
        private static void PowersOf2UntilN(int n)
        {
            for(int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
