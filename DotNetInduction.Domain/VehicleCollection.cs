using System.Collections;
using System.Collections.Generic;

namespace DotNetInduction.Domain
{
    /// <summary>
    /// VehicleCollection entity represents the collection of the vehicles.
    /// </summary>
    public class VehicleCollection : IEnumerable
    {
        private static List<Vehicle> _vehicles = new List<Vehicle>();

        /// <summary>
        /// Add method is used for the purpose of adding the vehicles 
        /// for the purpose of creation collection of vehicles.
        /// </summary>
        /// <param name="vehicle">It takes vehicle entity as parameter</param>
        public static void Add(List<Vehicle> vehicle)
        {
            _vehicles.AddRange(vehicle);
        }

        /// <summary>
        /// GetEnumerator is responsible for for returning enumerator 
        /// which is required for the purpose of iterating through the given list of vehicles.
        /// </summary>
        /// <returns>It returns the enumerator fot he purpose of iterating 
        /// through the list of vehicles.</returns>
        public IEnumerator GetEnumerator()
        {
           return  _vehicles.GetEnumerator();
        }

        /// <summary>
        /// GetVehicles method is used for the purpose of getting the vehicles;
        /// </summary>
        /// <returns></returns>
        public static List<Vehicle> GetVehicles()
        {
            return _vehicles;
        }
    }
}
