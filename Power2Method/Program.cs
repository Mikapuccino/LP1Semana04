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
            // Calls method with specific values
            PowersOf2UntilN(4);
            PowersOf2UntilN(8);
        }

        // Method calls PowersOf2UntilN method passing 5 as the argument
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
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
