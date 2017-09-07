using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passage_2017
{
    class Selection
    {
        private string pays, surnom;
        private int nbrMatchsInterne, nbrMatchsExterne;
        private List<Joueur> joueurs;
        private Entraineur entraineur;

        public List<Joueur> Joueurs
        {
            get { return joueurs; }
        }

        public Selection()
        {
            joueurs = new List<Joueur>(11);
        }

        public Selection(string pays, string surnom, int interne, int externe, Entraineur e)
            : this()
        {
            this.pays = pays;
            this.surnom = surnom;
            this.nbrMatchsInterne = interne;
            this.nbrMatchsExterne = externe;
            this.entraineur = e;
        }

        private Joueur GetJoueur(string nom)
        {
            Joueur j = null;

            foreach (Joueur je in joueurs)
            {
                if (je.Nom == nom)
                {
                    j = je;
                    break;
                }
            }

            return j;
        }

        public void Ajouter(Joueur j)
        {
            joueurs.Add(j);
        }

        public void AjouterAll(Joueur[] liste)
        {
            foreach (Joueur j in liste)
                Ajouter(j);
        }

        public void Supprimer(string nom)
        {
            if (joueurs.Count == 0)
                throw new Exception("Liste vide!");

            Joueur j = GetJoueur(nom);
            if (j != null)
                joueurs.Remove(j);
        }
    }
}
