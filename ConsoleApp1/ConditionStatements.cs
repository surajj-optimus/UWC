using System;

namespace DotNetAssignments
{
    /// <summary>
    /// ConditionStatements represents use of if-else ladder for getting required output.
    /// </summary>
    class ConditionStatements
    {
        /// <summary>
        /// Entrty point for ConditionStatements
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                string inputFromUser = Console.ReadLine();
                string vB = AssignmentsUtility.VisualBasic;
                string vBOutput = AssignmentsUtility.VisualBasicOutput;
                string cSharp = AssignmentsUtility.CSharp;
                string cSharpOutput = AssignmentsUtility.CSharpOutput;
                string defaultOutput = AssignmentsUtility.DefaultOutput;

                if (inputFromUser==vB)
                {
                    Console.WriteLine(vBOutput);
                }
                else if (inputFromUser.Equals(cSharp))
                {
                    Console.WriteLine(cSharpOutput);
                }
                else
                {
                    Console.WriteLine(defaultOutput);
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
