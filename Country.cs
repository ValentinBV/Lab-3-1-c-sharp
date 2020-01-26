using System;

namespace Labs_3
{
    [Serializable]
    public class Country
    {
        private string _code;
        private string _name;

        public Country()
        {

        }
        public Country(string codeValue, string nameValue)
        {
            if (codeValue.Length > 3 || codeValue.Length < 1)
            {
                throw new ArgumentOutOfRangeException("code", "Value must be more than 1 and small than 3");
            } else
            {
                _code = codeValue;
            }
            
            if (nameValue.Length > 20 || nameValue.Length < 1)
            {
                throw new ArgumentOutOfRangeException("name", "Value must be more than 1 and small than 20");
            } else
            {
                _name = nameValue;
            }
        }
        public string Code
        {
            get
            {
                return _code;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
