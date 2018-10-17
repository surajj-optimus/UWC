using System;

namespace DotNetAssignments
{
    /// <summary>
    /// TestString is used for the purpose of performing string operations.
    /// </summary>
    public class TestString
    {
        /// <summary>
        /// It is entry point of TestString.
        /// </summary>
        public static void Main()
        {
            //constant string required in manipulation of sample string.
            const string dummyString = "Suraj";

            //Get string on which operations are required to be done 
            string sampleString = AssignmentsUtility.SampleString;

            AccessString(dummyString, sampleString);
            StringManipulation(dummyString, sampleString);  
        }

        /// <summary>
        /// It is used for the purpose of Accessing string.
        /// </summary>
        /// <param name="dummyString"></param>
        /// <param name="sampleString"></param>
        private static void AccessString(string dummyString, string sampleString)
        {
            OutputService<object>.Display(sampleString.Clone());
            OutputService<int>.Display(sampleString.CompareTo(dummyString));
            OutputService<bool>.Display(sampleString.Contains(dummyString));
            OutputService<bool>.Display(sampleString.EndsWith(dummyString));
            OutputService<bool>.Display(sampleString.Equals(dummyString));
            OutputService<int>.Display(sampleString.GetHashCode());
            OutputService<Type>.Display(sampleString.GetType());
            OutputService<TypeCode>.Display(sampleString.GetTypeCode());
            OutputService<int>.Display(sampleString.IndexOf(dummyString));
        }

        /// <summary>
        /// It is used of the purpose of manipulation of the string.
        /// </summary>
        /// <param name="dummyString"></param>
        /// <param name="sampleString"></param>
        private static void StringManipulation(string dummyString, string sampleString)
        {
            OutputService<string>.Display(sampleString.ToLower());
            OutputService<string>.Display(sampleString.ToUpper());
            OutputService<string>.Display(sampleString.Substring(0, 1));
            OutputService<int>.Display(sampleString.IndexOf(dummyString));
        }
    }
}
