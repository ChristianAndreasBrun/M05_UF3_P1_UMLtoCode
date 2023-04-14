using System;
using System.Collections.Generic;
using System.Text;

namespace UML_to_Code
{
    public struct Address
    {
        public string Street;
        public string City;
        public string State;
        public int PostalCode;
        public string Country;

        public bool Validate()
        {
            return true;
        }
    }
}
