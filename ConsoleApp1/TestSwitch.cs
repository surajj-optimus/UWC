using System;

namespace DotNetAssignments
{
    /// <summary>
    /// TestSwitch is the class used for the purpose of implementing switch case.
    /// </summary>
    class TestSwitch
    {
        #region private members
        private const string _vB = "VB";
        private const string _cSharp = "C#";
        private static readonly string _vBOutput;
        private static readonly string _cSharpOutput;
        private static readonly string _defaultOutput;
        #endregion

        /// <summary>
        /// TestSwitch is the constructor used for the purpose of initialization of 
        /// input and output variables.
        /// </summary>
        static TestSwitch()
        {
            _vBOutput = AssignmentsUtility.VisualBasicOutput;
            _cSharpOutput = AssignmentsUtility.CSharpOutput;
            _defaultOutput = AssignmentsUtility.DefaultOutput;
        }

        /// <summary>
        /// Entry point for TestSwitch.
        /// </summary>
        public static void Main()
        {
            try
            {
                string inputFromUser = Console.ReadLine();
                string inputAfterValidation = ValidateInputService<string>.Check(inputFromUser);
                string output = DecisionMaking(inputAfterValidation);
                OutputService<string>.Display(output);
            }
            catch (Exception e)
            {
                OutputService<Exception>.Display(e);
            }
        }

        /// <summary>
        /// SwitchDecisionMaking method is responsible for the purpose of making decision 
        /// and returning output on the basis of input provided by the user.
        /// </summary>
        /// <param name="inputFromUser">It is the input taken from user.</param>
        /// <returns>It returns the output.</returns>
        private static string DecisionMaking(string inputFromUser)
        {
            switch (inputFromUser)
            {
                case _vB:
                    return _vBOutput;
                case _cSharp:
                    return _cSharpOutput;
                default:
                    return _defaultOutput;
            }
        } 
    }
}
