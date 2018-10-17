using DotNetInduction.Domain;
using System;

namespace DotNetAssignments
{
    /// <summary>
    /// TestEnum is used for the purpose of getting the weekdays.
    /// </summary>
    class TestEnum
    {
        /// <summary>
        /// It is entry point of TestEnum.
        /// </summary>
        static void Main()
        {
            TraverseWeekDays();
        }

        /// <summary>
        /// TraverseWeekDays is the method used for the purpose of traversing all the week days.
        /// </summary>
        private static void TraverseWeekDays()
        {
            foreach (WeekDays weekday in Enum.GetValues(typeof(WeekDays)))
            {
                OutputService<WeekDays>.Display(weekday);
            }
        }
    }
}
