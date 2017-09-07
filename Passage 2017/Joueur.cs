/*
 * Author : Mohammed FAKHAM
 * FB : fb.com/mohammed.fakham
 * Project : Correction Passage 2017 V2 POO et PE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passage_2017
{
    class Joueur
    {
        protected string nom, position;
        protected int age;
        protected bool experimente;

        public string Nom
        {
            get { return nom; }
            set { this.nom = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public bool Experimente
        {
            get { return experimente; }
            set { experimente = value; }
        }

        public Joueur()
        { }

        public Joueur(string nom, int age, string position, bool experimente)
        {
            this.Nom = nom;
            this.Age = age;
            this.Position = position;
            this.Experimente = experimente;
        }

        public virtual decimal CalculerPrime(int interne, int externe)
        {
            decimal prime = 0M;

            prime = (20000 * interne) + (30000 * externe);

            if (experimente)
                prime += prime / 2;

            return prime;
        }
    }
}
