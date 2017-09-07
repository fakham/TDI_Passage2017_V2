using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Passage_2017
{
    public partial class Form1 : Form
    {
        Selection selection1 = new Selection("Spain", "Barca", 99, 77, null);
        public Form1()
        {
            InitializeComponent();
            Joueur[] liste = { new Joueur("Joueur 1", 20, "AMR", true)};
            selection1.AjouterAll(liste);
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                selection1.Supprimer(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Enregistrer_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("selection.txt");

            foreach (Joueur j in selection1.Joueurs)
            {
                sw.WriteLine(string.Format("{0};{1};{2};{3}", j.Nom, j.Position, j.Age, j.Experimente));
            }

            sw.Close();
        }


    }
}
