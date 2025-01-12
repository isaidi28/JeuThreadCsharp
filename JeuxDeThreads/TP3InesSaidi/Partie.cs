using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TP3InesSaidi
{
    public class Partie
    {
        //variable avec get/set
        public List<Joueur> joueurs { get; set; }

        public int Tour { get; set; } = 0;

        //constructeur par défaut
        public Partie(){}

        //constructeur avec tous les paramètres
        public Partie(List <Joueur> joueurs) 
        {
            this.joueurs = joueurs;
            Tour=0;

        }
       
    }
}
