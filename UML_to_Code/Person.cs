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

        public List<Address> address;
    }

    public class Customer : Person
    {
        public DateTime Registration;
        private int CreditScore;
        public List<Account> account;
    }

    public class Employee : Person
    {
        public enum TYPE { Finanzas, Contabilidad, PYMES, Tesoreria };
        public TYPE Departament;
        private float Salary;
    }
}
