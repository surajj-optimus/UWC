using System;

namespace DotNetInduction.Domain
{
    public class Vehicle : IComparable<Vehicle>, IEquatable<Vehicle>
    {
        #region private members
        private string _name;
        #endregion

        /// <summary>
        /// Name property specifies name of the vehicle.
        /// </summary>
        public virtual string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// CompareTo method is used for comparison of vehicles with current vehicle.
        /// </summary>
        /// <param name="vehicle">Vehicle entity is used as parameter.</param>
        /// <returns></returns>
        public int CompareTo(Vehicle vehicle)
        {
            if (vehicle.Name[0] < Name[0])
            {
                return 1;
            }
            else if(vehicle.Name[0] > Name[0])
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// ToString method is used for the purpose of displaying vehicles information.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Vehicle: " + Name;
        }

        /// <summary>
        /// GetHash code is used for the purpose of getting the hash code.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 0;
        }

        /// <summary>
        /// Equals method is used for the purpose of comparing vehicle instances.
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public bool Equals(Vehicle vehicle)
        {
            if (!(vehicle is Vehicle))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
