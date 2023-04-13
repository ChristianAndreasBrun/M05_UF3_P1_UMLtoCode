using System;
using System.Collections.Generic;
using System.Text;

namespace UML_to_Code
{
    public abstract class Person
    {
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;
    }

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
