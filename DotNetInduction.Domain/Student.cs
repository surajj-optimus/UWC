using System;
using System.Collections;

namespace DotNetInduction.Domain
{
    /// <summary>
    /// Student Entity represents the student studying in an organisatiion.
    /// </summary>
    public class Student:IComparable<Student>
    {
        #region properties
        public int EnrollmentNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        /// <summary>
        /// Student constructor is used for the purpose of initializing the attributes of student.
        /// </summary>
        /// <param name="studentDetails"></param>
        public Student(ArrayList studentDetails)
        {
            EnrollmentNumber = (int)studentDetails[0];
            Name = (string)studentDetails[1];
            Age = (int)studentDetails[2];
        }
        
        /// <summary>
        /// CompareTo method is used for the purpose of comparing 2 objects.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ToString is used for the purpose of returning the attributes of the student.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Student: Name " + Name + " Age"+ " " + Age + " Enumber" + EnrollmentNumber;
        }
    }
}
