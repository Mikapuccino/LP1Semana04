using System;

namespace Lucas
{
    class Program
    {
        /// <summary>
        /// Asks user for a number that is stored in Pos, then calls the
        /// Lucas method passing Pos as the argument, finally it writes
        /// the returned value
        /// </summary>
        /// <param name="args">Arguments passed by the
        /// user from the console</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Input position in the Lucas sequence: ");
            int Pos = int.Parse(Console.ReadLine());

            int FinalValue = Lucas(Pos);

            Console.WriteLine($"Number in that position is {FinalValue}");
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
