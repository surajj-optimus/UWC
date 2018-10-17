using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOpsConcepts
{
    /// <summary>
    /// It represents an entity of four wheeler vehicles.
    /// </summary>
    public abstract class Vehicle
    {
        #region

        private string _make;
        private int _yearOfManufacture;
        private string _model;
        private float _speed;

        #endregion

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public int ManufactureYear
        {
            get
            {
                return _yearOfManufacture;
            }
            set
            {
                _yearOfManufacture = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        /// <summary>
        /// Vehicle Constructor is used for the purpose of initializing a vehicle.
        /// </summary>
        /// <param name="make"></param>
        /// <param name="manufactureYear"></param>
        /// <param name="model"></param>
        /// <param name="speed"></param>
        public Vehicle(string make, int manufactureYear, string model, float speed)
        {
            _make = make;
            _yearOfManufacture = manufactureYear;
            _model = model;
            _speed = speed;
        }

        public Vehicle() { }

        /// <summary>
        /// Accelerate is used for the purpose of accelerating the vehicle.
        /// </summary>
        public abstract void Accelerate();

        /// <summary>
        /// Deaccelerate is the method used for the purpose of deaccelerating the vehicle.
        /// </summary>
        public abstract void Deaccelarate();

        /// <summary>
        /// Stop is the method for the purpose of stoping the vehicle.
        /// </summary>
        public abstract void Stop();

        /// <summary>
        /// IsMoving is the method used for the purpose of getting 
        /// whether the vehicle is moving or not.
        /// </summary>
        /// <returns></returns>
        public abstract bool IsMoving();

    }
}
