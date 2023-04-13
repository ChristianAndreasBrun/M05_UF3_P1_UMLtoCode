using System;
using System.Collections.Generic;
using System.Text;

namespace UML_to_Code
{
    internal class Employee
    {
        public enum TYPE { Finanzas, Contabilidad, PYMES, Tesoreria };
        public TYPE Departament;
        private float Salary;
    }
}
