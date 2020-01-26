using System.Collections.Generic;

namespace Labs_3
{
    public class CountryCollection
    {
        private List<Country> _country = new List<Country>();

        public void Add(Country country)
        {
            _country.Add(country);
        }
        public List<Country> GetCollection()
        {
            return _country;
        }
        public void Remove(int id)
        {
            _country.RemoveAt(id);
        }
    }
}
