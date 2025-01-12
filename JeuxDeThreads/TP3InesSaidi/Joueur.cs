using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3InesSaidi
{
    public class Joueur
    { 
        //variable avec get/set
        public string Nom {  get; set; }

        public int Pointage { get; set; }
        public ConsoleColor Couleur { get; set; }

        public int ScoreGlobal { get; set; }



        //constructeur par défaut
        public Joueur() { }

        //constructeur avec tous les paramètres
        public Joueur(string nom, ConsoleColor couleur)
        {
            Nom = nom;
            Pointage = 0;
            Couleur = couleur;
            ScoreGlobal = 0;
        }
    }
}
