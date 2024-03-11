using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heran.ex.Entities
{
    internal class Company : TaxPayer
    {
        public int NumeberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int numeberOfEmployees) : base(name, numeberOfEmployees)
        {
            NumeberOfEmployees = numeberOfEmployees;
        }

        public override double Tax()
        {
            if (NumeberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
