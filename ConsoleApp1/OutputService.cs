using System;

namespace DotNetAssignments
{
    /// <summary>
    /// OutputService is responsible for displaying output.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class OutputService<T>
    {
        /// <summary>
        /// DisplayOutput method is responsible for showing the output to the user. 
        /// </summary>
        /// <param name="output">output for the user.</param>
        public static void Display(T output)
        {
            try
            {
                Console.WriteLine(output);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
