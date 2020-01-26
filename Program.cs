using System;
using System.IO;
using System.Xml.Serialization;

namespace Labs_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar car = new PassengerCar(CarsType.Coupe);
            Service service = new Service("Staff", "Clietn");
            Country country = new Country("RU", "Russia");
            car.Country = country;
            service.AddCar(car);
            
            XmlSerializer formatter = new XmlSerializer(typeof(Service), new Type[] { typeof(PassengerCar), typeof(Country) });
            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, service);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
