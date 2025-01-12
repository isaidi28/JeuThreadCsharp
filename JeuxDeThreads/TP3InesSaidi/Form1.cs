using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3InesSaidi
{
    public partial class Form1 : Form
    {
        //variables
        List<Joueur> joueurs = new List<Joueur>();
        public Partie nouvellePartie;


        public int MeilleurPointageForm2
        {
            get { return form2.MeilleurPointage; }
        }
        private Form2 form2;
        public Form1()
        {


            /*
             !!!NOTE AU PROFESSEUR:
            Lorsque vous démarrer le programme, il faut changer le numericUpDown apres avoir mis les 
            2 noms afin d'activer le bouton pour démarrer une partie, jouer un peu avec parfois.
            Le probleme ne voulais pas se regler avec mon ordi.
            merci et passez de bonne vacance !!
             
             */
            InitializeComponent();
            textBoxNom3.Visible = false;
            labelNom3.Visible = false;
            textBoxNom4.Visible = false;
            labelNom4.Visible = false;
            buttonDemarrerPartie.Enabled = false;
            form2 = new Form2(this, joueurs, nouvellePartie);

        }

        private void numericUpDownNbJoueur_ValueChanged(object sender, EventArgs e)
        {
            int nombreDeJoueurs = (int)numericUpDownNbJoueur.Value;
            BoutonDemarrer();

            try {
                textBoxNom3.Visible = false;
                labelNom3.Visible = false;
                textBoxNom4.Visible = false;
                labelNom4.Visible = false;
                if (nombreDeJoueurs == 3)
                {
                    textBoxNom3.Visible = true;
                    labelNom3.Visible = true;

                }
                if (nombreDeJoueurs == 4)
                {
                    textBoxNom3.Visible = true;
                    labelNom3.Visible = true;
                    textBoxNom4.Visible = true;
                    labelNom4.Visible = true;
                }
                if (nombreDeJoueurs < 2 || nombreDeJoueurs > 4)
                {
                    MessageBox.Show("Il faut au minimum 2 joueurs et au maximum 4 joueurs.");
                }
            }
            catch (Exception)
            { 
                MessageBox.Show("Il y a une erreur.");
            }
            BoutonDemarrer();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }



        private void buttonMeilleurPointage_Click(object sender, EventArgs e)
        {
             int meilleurPointage = MeilleurPointageForm2;

             
             richTextBoxPointage.AppendText($"Le meilleur pointage est : {meilleurPointage}\n");
        }

        private void textBoxNom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char touche = e.KeyChar;
            if (Char.IsLetter(touche) || Char.IsControl(touche) || Char.IsSeparator(touche))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                throw new Exception("Caractère non valide pour un nom");
            }
        }

        private void textBoxNom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char touche = e.KeyChar;
            if (Char.IsLetter(touche) || Char.IsControl(touche) || Char.IsSeparator(touche))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                throw new Exception("Caractère non valide pour un nom");
            }
        }

        private void textBoxNom3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char touche = e.KeyChar;
            if (Char.IsLetter(touche) || Char.IsControl(touche) || Char.IsSeparator(touche))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                throw new Exception("Caractère non valide pour un nom");
            }
        }

        private void textBoxNom4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char touche = e.KeyChar;
            if (Char.IsLetter(touche) || Char.IsControl(touche) || Char.IsSeparator(touche))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                throw new Exception("Caractère non valide pour un nom");
            }
        }


        public void BoutonDemarrer() 
        {
 
            if ((int)numericUpDownNbJoueur.Value == 2)
            {
                if (textBoxNom1.Text != "" && textBoxNom2.Text !="") 
                {
                    //rendre le bouton actif
                    buttonDemarrerPartie.Enabled = true;
                }

            }

            else if ((int)numericUpDownNbJoueur.Value == 3)
            {
                if (textBoxNom1.Text != "" && textBoxNom2.Text != "" && textBoxNom3.Text !="")
                {
                    //rendre le bouton actif
                    buttonDemarrerPartie.Enabled =true;
                }
            }
            else if ((int)numericUpDownNbJoueur.Value == 4)
            {
                if (textBoxNom1.Text != "" && textBoxNom2.Text != "" && textBoxNom3.Text != "" && textBoxNom4.Text != "")
                {
                    //rendre le bouton actif
                    buttonDemarrerPartie.Enabled = true;
                }
            }

            else 
            {
                //rendre le bouton inactif
                buttonDemarrerPartie.Enabled = false;
            }

        }

       

        private void buttonDemarrerPartie_Click(object sender, EventArgs e)
        {
            try
            {
                int nombreDeJoueurs = (int)numericUpDownNbJoueur.Value;

                if (nombreDeJoueurs < 2 || nombreDeJoueurs > 4)
                {
                    MessageBox.Show("Il faut au minimum 2 joueurs et au maximum 4 joueurs.");
                    return;
                }
           
                joueurs.Add(new Joueur(textBoxNom1.Text, ConsoleColor.Black)); 

                joueurs.Add(new Joueur(textBoxNom2.Text, ConsoleColor.White)); 

                if (nombreDeJoueurs >= 3)
                {
                    joueurs.Add(new Joueur(textBoxNom3.Text, ConsoleColor.Red)); 
                }

                if (nombreDeJoueurs == 4)
                {
                    joueurs.Add(new Joueur(textBoxNom4.Text, ConsoleColor.Blue)); 
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
            }


            Form2 fenetreJeu = new Form2(this, joueurs, nouvellePartie);
            fenetreJeu.ShowDialog();
        }
    }
}
