using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageManagement.Models
{
	/// <summary>
	/// Car is an entity that represents a four wheel vehicle in a garage.
	/// </summary>
	public class Car
	{
		public string Name { get; set; }
		public string Model { get; set; }
		public string Number { get; set; }
	}
}