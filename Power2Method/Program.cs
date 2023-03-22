using System;

namespace Power2Method
{
    /// <summary>
    /// Asks user for a number and calls the PowersOf2UntilN method
    /// passing that number as the argument, then calls that method
    /// two more times passing 4 and 8 as the arguments
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method responsible of calling the other methods with 
        /// the appropriate arguments
        /// </summary>
        /// <param name="args">Arguments passed by the user when running
        /// the program</param>
        static void Main(string[] args)
        {
            // Asks user for a number for later use
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);

            // Calls method passing the number the user gave as the argument
            PowersOf2UntilN(nCount);

            // Calls method with specific values
            PowersOf2UntilN(4);
            PowersOf2UntilN(8);
        }

        /// <summary>
        /// Calls PowersOf2UntilN method passing 5 as the argument
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }

        /// <summary>
        /// Writes the value of i to the power of 1 through n
        /// </summary>
        /// <param name="n">Number that determines number of times the for
        /// loop repeats</param>
        private static void PowersOf2UntilN(int n)
        {
            for(int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Writes the value of i to the power of n1 through n2
        /// </summary>
        /// <param name="n1">First number used as a power</param>
        /// <param name="n2">Last number used as a power</param>
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for(int i = 1 << n1; i <= (1 << n2); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
