using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passage_2017
{
    class International:Joueur
    {
        private int annees;
        public int Annees
        {
            get { return annees; }
            set 
            {
                if (value > age)
                    throw new Exception("Annees doit etre inferieur a l'age!");

                annees = value; 
            }
        }

        public International(string nom, int age, string position, bool experimente, int annees)
            : base(nom, age, position, experimente)
        {
            this.Annees = annees;
        }

        public override decimal CalculerPrime(int interne, int externe)
        {
            return base.CalculerPrime(interne, externe) + (5000 * annees);
        }
    }
}
