using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// Returns value of lc which is the number in the Lucas sequence
        /// in the position specified by the user
        /// </summary>
        /// <param name="n">Position of the number
        /// in the Lucas sequence</param>
        /// <returns>Number in the specified position
        /// of the Lucas sequence</returns>
        private static int Lucas(int n)
        {
            int lc;
            if (n == 0)
                lc = 2;
            
            else if (n == 1)
                lc = 1;

            else
                lc = Lucas(n - 1) + Lucas(n - 2);

            return lc;
        } 
    }
}
