using DotNetInduction.Domain;
using System;
using System.Collections;

namespace DotNetAssignments
{
    /// <summary>
    /// TestStudent is responsible for management the student entity.
    /// </summary>
    class TestStudent
    {
        /// <summary>
        /// It is entry point of TsetStudent.
        /// </summary>
        public static void Main()
        {
            AcessStudentDetails();
        }

        /// <summary>
        /// It is used for the purpose of accessing the detais of the student and print them.
        /// </summary>
        private static void AcessStudentDetails()
        {
            Random random = new Random();
            int enrollmentNumber = random.Next(AssignmentsUtility.Min, AssignmentsUtility.Max);
            Console.WriteLine(AssignmentsUtility.EnterNameMessage);
            string name = Console.ReadLine();
            Console.WriteLine(AssignmentsUtility.EnterAgeMessage);
            string ageFromUser = Console.ReadLine();
            int age = int.Parse(ageFromUser);
            ArrayList studentDetails = new ArrayList();
            studentDetails.Add(enrollmentNumber);
            studentDetails.Add(name);
            studentDetails.Add(age);
            Student student = new Student(studentDetails);
            OutputService<Student>.Display(student);
            Console.WriteLine(AssignmentsUtility.StudentDetailsMessage);
            string choice = Console.ReadLine();
            int choiceInteger = int.Parse(choice);
            Print(choiceInteger, student);
        }

        /// <summary>
        /// It is used for accessing choice based details of student.
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="student"></param>
        private static void Print(int choice,  Student student)
        {
            switch(choice)
            {
                case (int)StudentDetails.EnrollmentNumber: OutputService<int>.Display(student.EnrollmentNumber);
                    break;
                case (int)StudentDetails.Name: OutputService<string>.Display(student.Name);
                    break;
                case (int)StudentDetails.Age: OutputService<int>.Display(student.Age);
                    break;
                default: OutputService<string>.Display(AssignmentsUtility.DefaultMessage);
                    break;

            }
        }
    }
}
