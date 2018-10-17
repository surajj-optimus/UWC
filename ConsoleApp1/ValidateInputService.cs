using System.Text.RegularExpressions;

namespace DotNetAssignments
{
    /// <summary>
    /// Check method is used for the purpose of validating the input from the user.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ValidateInputService<T>
    {
        /// <summary>
        /// Check method is responsible for the purpose of validating the input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Check(T input)
        {
            NullInputExamination(input);
            SpecialCharactersExamination(input.ToString());
            return input.ToString();
        }

        /// <summary>
        /// SpecialCharactersExamination method is responsible for validating the special characters.
        /// </summary>
        /// <param name="input"></param>
        private static void SpecialCharactersExamination(string input)
        {
            var regexItem = new Regex(AssignmentsUtility.SpecialCharacters);

            if (regexItem.IsMatch(input))
            {
                throw new InvalidInputException(input);
            }
        }

        /// <summary>
        /// NullInputExamination is the method responsible for the purpose of validating the null input by the user.
        /// </summary>
        /// <param name="input">input from user.</param>
        private static void NullInputExamination(T input)
        {
            if(input==null)
            {
                throw new InvalidInputException(input.ToString());
            }
        }
    }
}
