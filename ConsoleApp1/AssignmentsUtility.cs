using DotNetInduction.Domain;
using System.Configuration;

namespace DotNetAssignments
{
    /// <summary>
    /// AssignmentsUtility is responsible for extracting the data from user accessible property file.
    /// </summary>
    public static class AssignmentsUtility
    {
        #region public members
        
        #region Switch and if-else properties
        public static readonly string VisualBasic = ConfigurationManager.AppSettings["VB"];
        public static readonly string VisualBasicOutput = ConfigurationManager.AppSettings["VBOutput"];
        public static readonly string CSharp = ConfigurationManager.AppSettings["C#"];
        public static readonly string CSharpOutput = Properties.Settings.Default.COutput;
        public static readonly string DefaultOutput = ConfigurationManager.AppSettings["DefaultOutput"];
        #endregion

        #region TestString proeperties
        public static readonly string SampleString = Properties.Settings.Default.SampleString;
        public static readonly string SpecialCharacters = Properties.Settings.Default.SpecialCharacters;
        public static readonly string ExceptionMessage = Properties.Settings.Default.ExceptionMessage;
        #endregion

        #region Vehicle Collection properties.
        public static readonly string[] Cars = { Properties.Settings.Default.Vehicle1,Properties.Settings.Default.Vehicle2,Properties.Settings.Default.Vehicle3 };
        public static readonly string UpdatedVehicle = Properties.Settings.Default.UpdatedVehicle;
        public static readonly string VehicleAfterUpdateSignature = Properties.Settings.Default.VehicleAfterUpdateSignature;
        public static readonly string DisplayVehiclesSignature = Properties.Settings.Default.DisplayVehiclesSignature;
        public static readonly string DisplayTrucksSignature = Properties.Settings.Default.DisplayTrucksSignature;
        public static readonly string DisplayCarsSignature = Properties.Settings.Default.DisplayCarsSignature;
        #endregion

        #region Random Range
        public static readonly int Max = Properties.Settings.Default.MaxRandom;
        public static readonly int Min = Properties.Settings.Default.MinRandom;
        #endregion

        #region Student
        public static readonly string DefaultMessage = Properties.Settings.Default.DefaultMessage;
        public static readonly string EnterNameMessage = Properties.Settings.Default.StudentNameSignature;
        public static readonly string EnterAgeMessage = Properties.Settings.Default.StudentAgeSignature;
        public static readonly string StudentDetailsMessage = Properties.Settings.Default.StudentDetailsSignature;
        #endregion

        #endregion

        #region public collections

        #region Vehicles
        public static Vehicle[] Vehicles = new Vehicle[]{
            new Vehicle()
            {
                Name = Properties.Settings.Default.Vehicle1
            },
            new Vehicle()
            {
                Name = Properties.Settings.Default.Vehicle2
            },
            new Vehicle()
            {
                Name = Properties.Settings.Default.Vehicle3
            }
        };
        #endregion

        #region Cars
        public static Car[] CarsCollection = new Car[]{
            new Car()
            {
                Name = Properties.Settings.Default.Vehicle1
            },
            new Car()
            {
                Name = Properties.Settings.Default.Vehicle2
            },
            new Car()
            {
                Name = Properties.Settings.Default.Vehicle3
            }
        };
        #endregion

        #region trucks
        public static Truck[] Trucks = new Truck[]{
            new Truck()
            {
                Name = Properties.Settings.Default.Truck1
            },
            new Truck()
            {
                Name = Properties.Settings.Default.Truck2
            },
            new Truck()
            {
                Name = Properties.Settings.Default.Truck3
            }
        };
        #endregion

        #endregion

    }
}
