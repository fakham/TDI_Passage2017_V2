using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passage_2017
{
    class Entraineur
    {
        private string nom;
        private DateTime dateFinContrat;
        private int nbrAnneesContrat;
        private decimal primeAnnuelle;
        public decimal PrimeAnnuelle
        {
            get { return primeAnnuelle; }
            set
            {
                if (value < 300000 || value > 600000)
                    throw new Exception("prime annuelle doit etre entre 300000 MAD et 600000 MAD");

                primeAnnuelle = value;
            }
        }

        public Entraineur(string nom, DateTime dateFinContrat, int nbrAnneesContrat, decimal primeAnnuelle)
        {
            this.nom = nom;
            this.dateFinContrat = dateFinContrat;
            this.nbrAnneesContrat = nbrAnneesContrat;
            this.PrimeAnnuelle = primeAnnuelle;
        }

        public DateTime DeterminerDebutContrat()
        {
            return new DateTime(dateFinContrat.Year - nbrAnneesContrat, dateFinContrat.Month, dateFinContrat.Day);
        }
    }
}
