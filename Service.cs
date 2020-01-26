using System;
using System.Collections.Generic;
using System.Text;

namespace Labs_3
{
    class Service
    {
        private string _clientName;
        private string _staffName;
        private List<Car> _cars = new List<Car>();

        public Service(string staffName, string clientName)
        {
            _clientName = clientName;
            _staffName = staffName;
        }
        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void RemoveCar(int id)
        {
            _cars.RemoveAt(id);
        }

        public string StaffName
        {
            get
            {
                return _staffName;
            }
        }

        public string ClientName
        {
            get
            {
                return _clientName;
            }
        }
    }
}
