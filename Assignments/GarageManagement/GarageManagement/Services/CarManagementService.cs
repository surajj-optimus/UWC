using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GarageManagement.Services
{
	public class CarManagementService
	{
		/// <summary>
		/// AddCar is the method used for the purpose of adding new car.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		public static void AddCar(string name, string model, string number)
		{
			try
			{
				if (name!=null && model!=null && number!=null)
				{
					SqlConnection connection = new SqlConnection("Data Source=172.16.0.108;Initial Catalog=school_repository; User ID = sa; Password = sss");
					SqlCommand command = new SqlCommand("INSERT INTO Car VALUES('" + name + "' , '" + model + "' , '" + number + "')", connection);
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					connection.Close();
				}
			}
			catch (SqlException e)
			{
				Console.WriteLine(e);
			}
		}

		public static void GetAllCars()
		{

		}
	}
}