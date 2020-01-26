using System;

namespace Labs_3
{
    abstract public class Car
    {
        protected CarsType carsType;
        private float _weight;
        private int _year;
        public Country Country { get; set; }

        public Car()
        {

        }
        public Car(CarsType type)
        {
            carsType = type;
        }

        public float Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                } else
                {
                    throw new ArgumentOutOfRangeException("weight", "Value must be more than zero");
                }
            }
        }

        public CarsType CarsType
        {
            get
            {
                return carsType;
            }
        }

        public int Year
        {
            set
            {
                if (value > 0)
                {
                    _year = value;
                } else
                {
                    throw new ArgumentOutOfRangeException("year", "Value must be more than zero");
                }
            }
            get
            {
                return _year;
            }
        }
    }
}
