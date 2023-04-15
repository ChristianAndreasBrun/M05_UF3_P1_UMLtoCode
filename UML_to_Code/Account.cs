using System;
using System.Collections.Generic;
using System.Text;

namespace UML_to_Code
{
    public class Account
    {
        public string IBAN;
        protected float Amount;

        public List<Transaction> transaction;

        public bool Transaction(string transactionType)
        {
            return true;
        }
    }

    public class Investing : Account
    {
        public float Interest;
        public float ApplyInterest()
        {
            return Interest;
        }
    }

    public class Saving : Account
    {
        private float ProtectedAmount;
        public float LiberateSaving() 
        { 
            return ProtectedAmount; 
        }
    }
}
