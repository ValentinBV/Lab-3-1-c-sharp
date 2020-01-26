using System;

namespace Labs_3
{
    abstract class Car
    {
        private CarsType carsType;
        private float _weight;
        private int _year;
        private Country _country;

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

        public Country Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (value.GetType() == typeof(Country))
                {
                    _country = value;
                } else
                {
                    throw new ArgumentException("Value must be instance of Country object");
                }
            }
        }
    }
}
