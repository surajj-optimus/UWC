namespace DotNetAssignments
{
    /// <summary>
    /// TestStringArray is used for the purpose of showing array of strings.
    /// </summary>
    public class TestStringArray
    {
        /// <summary>
        /// It is the entry point of TestStringArray.
        /// </summary>
        /// <param name="args"></param>
        public static void Main()
        {
            foreach(string car in GetStringArray())
            {
                OutputService<string>.Display(car);
            }
        }

        /// <summary>
        /// GetStringArray method is used for returning the string array
        /// </summary>
        /// <returns></returns>
        public static string[] GetStringArray()
        {
            string[] cars = AssignmentsUtility.Cars;
            return cars;
        }
    }
}
