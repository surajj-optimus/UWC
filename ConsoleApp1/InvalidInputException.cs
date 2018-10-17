using System;

namespace DotNetAssignments
{
    /// <summary>
    /// InvalidInputException is an exception which is used for the purpose of specifying the custom input exception.
    /// </summary>
    [Serializable]
    public class InvalidInputException: Exception
    {
        /// <summary>
        /// InvalidInputException is responsible for printing the custom exception
        /// </summary>
        /// <param name="message"></param>
        public InvalidInputException(string message): base(string.Format(AssignmentsUtility.ExceptionMessage, message)){ }
    }
}
