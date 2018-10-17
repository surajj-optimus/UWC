using DotNetInduction.Domain;
using System.Collections.Generic;

namespace DotNetAssignments
{
    /// <summary>
    /// TestVehicle is used for management of Vehicles and its children.
    /// </summary>
    class TestVehicle
    {
        public static void Main()
        {
            ListOfSortedVehicles();
            CollectionOfCarsAndTrucks();
        }

        /// <summary>
        /// ListOfSortedVehicles prints the collection of vehicles.
        /// </summary>
        private static void ListOfSortedVehicles()
        {
            List<Vehicle> vehicleCollection = new List<Vehicle>();
            vehicleCollection.AddRange(AssignmentsUtility.Vehicles);
            VehicleCollection.Add(vehicleCollection);
            SortVehicles(vehicleCollection);
            OutputService<string>.Display(AssignmentsUtility.VehicleAfterUpdateSignature);
            OutputService<Vehicle>.Display(vehicleCollection[0]);
        }

        /// <summary>
        /// It displays collection of cars and trucks.
        /// </summary>
        private static void CollectionOfCarsAndTrucks()
        {
            List<Car> carsCollection = new List<Car>();
            List<Truck> truckCollection = new List<Truck>();
            carsCollection.AddRange(AssignmentsUtility.CarsCollection);
            truckCollection.AddRange(AssignmentsUtility.Trucks);
            SortTrucks(truckCollection);
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            OutputService<bool>.Display(vehicle.Equals(car));

        }

        /// <summary>
        /// SortVehicles is the method responsible for the purpose of sorting vehicles.
        /// </summary>
        /// <param name="vehicleCollection">It takes a collection of vehicles as parameter.</param>
        private static void SortVehicles(List<Vehicle> vehicleCollection)
        {
            vehicleCollection.Sort();
            OutputService<string>.Display(AssignmentsUtility.DisplayVehiclesSignature);
            foreach (Vehicle vehicle in vehicleCollection)
            {
                OutputService<Vehicle>.Display(vehicle);
                vehicle.Name = AssignmentsUtility.UpdatedVehicle;
            }
        }

        /// <summary>
        /// SortTrucks is the method used for the purpose of sorting trucks.
        /// </summary>
        /// <param name="truckCollection">Collection of trucks is used as parameter</param>
        private static void SortTrucks(List<Truck> truckCollection)
        {
            truckCollection.Sort();
            OutputService<string>.Display(AssignmentsUtility.DisplayTrucksSignature);
            foreach (Truck truck in truckCollection)
            {
                OutputService<Truck>.Display(truck);
            }
        }
    }
}
