using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ADO.Net
{
	/// <summary>
	/// ManageStudents is an entity used for the purpose of management of students.
	/// </summary>
	class ManageStudents
	{
		//Change the id before executing.
		private static int _id = 12;
		private static SqlConnection _connection;

		/// <summary>
		/// It is the entry point of ManageStudents.
		/// </summary>
		public static void Main()
		{
			InsertIntoStudent();
			SelectAllStudents();
			UpdateStudent();
			SelectAllStudents();
		}

		/// <summary>
		/// SelectAllStudents is used for the purpose of selecting all the students.
		/// </summary>
		public static void SelectAllStudents()
		{
			SqlConnection connection = new SqlConnection("Data Source=172.16.0.108;Initial Catalog=school_repository; User ID = sa; Password = sss");
			SqlCommand command = new SqlCommand("SELECT * FROM STUDENT_DATA", connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
			}
			connection.Close();
			Console.WriteLine("press key");
			Console.ReadKey();
		}

		/// <summary>
		/// InsertIntoStudent is used for the purpose of adding new user.
		/// </summary>
		public static void InsertIntoStudent()
		{
			try
			{
				SqlConnection connection = new SqlConnection("Data Source=172.16.0.108;Initial Catalog=school_repository; User ID = sa; Password = sss");
				SqlCommand command = new SqlCommand("INSERT INTO STUDENT_DATA VALUES('HI')", connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				connection.Close();
			}
			catch (SqlException e)
			{
				Console.WriteLine(e);
			}
		}


		/// <summary>
		/// UpdateStudents is the method used for the purpose of updating the student.
		/// </summary>
		public static void UpdateStudent()
		{

			try
			{
				SqlConnection connection = new SqlConnection("Data Source=172.16.0.108;Initial Catalog=school_repository; User ID = sa; Password = sss");
				SqlCommand command = new SqlCommand("UPDATE STUDENT_DATA SET NAME = 'suraj'", connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				connection.Close();
			}
			catch (SqlException e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
