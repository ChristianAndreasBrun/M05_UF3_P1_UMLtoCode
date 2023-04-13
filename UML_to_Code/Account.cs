using System;
using System.Collections.Generic;
using System.Text;

namespace UML_to_Code
{
    internal class Account
    {
        public string IBAN;
        protected float Amount;


        public bool Transaction(string transaction)
        {
            return true;
        }
    }

    public struct Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Request;
    }
}
