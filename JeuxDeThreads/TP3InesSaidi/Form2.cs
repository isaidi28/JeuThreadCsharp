using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP3InesSaidi
{
    public partial class Form2 : Form
    {
        public Partie partie;
        Random aleatoire;
        Thread unThread, deuxThread, troisThread, quatreThread;
        private int indexJoueurActuel = 0;


        //variable de
        private string[] deNoir = new string[6];
        private string[] deBlanc = new string[6];
        private string[] deRouge = new string[6];
        private string[] deBleu = new string[6];

        private volatile int pointDeNoir;
        private volatile int pointDeBlanc;
        private volatile int pointDeRouge;
        private volatile int pointDeBleu;

        public int sommeTotalNoir;
        public int sommeTotalBlanc;
        public int sommeTotalRouge;
        public int sommeTotalBleu;

        private string chemin = Application.StartupPath + "\\";
        string fichierSon = "SonBoom.mp3";
        string fichierTxt = "MeilleurPointage.txt";


        public Form1 Form1 { get; }

        private void Form2_Load(object sender, EventArgs e)
        {
            aleatoire = new Random();

            if (Joueurs.Count < 3)
            {
                buttonLancerRouge.Enabled = false;
                buttonArretRouge.Enabled = false;
                textBoxPointRouge.Enabled = false;
                pictureBoxDeRouge.Enabled = false;
                labelJoueur3.Enabled = false;


                buttonLancerRouge.Visible = false;
                buttonArretRouge.Visible = false;
                textBoxPointRouge.Visible = false;
                pictureBoxDeRouge.Visible = false;
                labelJoueur3.Visible = false;
            }


            if (Joueurs.Count < 4)
            {
                buttonLanceBleu.Enabled = false;
                buttonArretBleu.Enabled = false;
                textBoxPointBleu.Enabled = false;
                pictureBoxDeBleu.Enabled = false;
                labelJoueur4.Enabled = false;

                buttonLanceBleu.Visible = false;
                buttonArretBleu.Visible = false;
                textBoxPointBleu.Visible = false;
                pictureBoxDeBleu.Visible = false;
                labelJoueur4.Visible = false;
            }
        }

        public List<Joueur> Joueurs { get; }


        public Form2(Form1 form1, List<Joueur> joueurs, Partie nouvellePartie)
        {
            InitializeComponent();
            InitialiserNoir();
            InitialiserBlanc();
            InitialiserRouge();
            InitialiserBleu();
            Form1 = form1;
            Joueurs = joueurs;
            partie = nouvellePartie;

        }



        /*
         *MÉTHODE POUR LES THREADS
         */

        public void Thread1()
        {
            unThread = new Thread(() =>
            {
                Random random = new Random();
                while (unThread.IsAlive)
                {
                    int faceDuDe = random.Next(1, 7);

                    if (!pictureBoxDeNoir.Disposing && !pictureBoxDeNoir.IsDisposed)
                    {
                        pictureBoxDeNoir.Invoke((MethodInvoker)delegate
                        {
                            pictureBoxDeNoir.Image = ObtenirImageDuDeNoir(faceDuDe);
                        });

                        pointDeNoir = faceDuDe;
                        textBoxPointNoir.Invoke((MethodInvoker)delegate
                        {
                            textBoxPointNoir.Text = pointDeNoir.ToString();
                        });
                    }

                    Thread.Sleep(50);
                }
            })
            { IsBackground = true };

            unThread.Start();
        }



        public void Thread2()
        {

            deuxThread = new Thread(() =>
            {
                Random random = new Random();
                while (deuxThread.IsAlive)
                {
                    int faceDuDe = random.Next(1, 7);
                    if (!pictureBoxDeBlanc.Disposing && !pictureBoxDeBlanc.IsDisposed)
                    {
                        pictureBoxDeBlanc.Invoke((MethodInvoker)delegate
                        {
                            pictureBoxDeBlanc.Image = ObtenirImageDuDeBlanc(faceDuDe);
                        });

                        pointDeBlanc = faceDuDe;
                        textBoxPointBlanc.Invoke((MethodInvoker)delegate
                        {
                            textBoxPointBlanc.Text = pointDeBlanc.ToString();
                        });
                    }

                    Thread.Sleep(50);
                }
            })
            { IsBackground = true };

            deuxThread.Start();
        }

        public void Thread3()
        {
            troisThread = new Thread(() =>
            {
                Random random = new Random();
                while (troisThread.IsAlive)
                {
                    int faceDuDe = random.Next(1, 7);
                    if (!pictureBoxDeRouge.Disposing && !pictureBoxDeRouge.IsDisposed)
                    {
                        pictureBoxDeRouge.Invoke((MethodInvoker)delegate
                        {
                            pictureBoxDeRouge.Image = ObtenirImageDuDeRouge(faceDuDe);
                        });

                        pointDeRouge = faceDuDe;
                        textBoxPointRouge.Invoke((MethodInvoker)delegate
                        {
                            textBoxPointRouge.Text = pointDeRouge.ToString();
                        });
                    }

                    Thread.Sleep(50);
                }
            })
            { IsBackground = true };

            troisThread.Start();

        }

        public void Thread4()
        {
            quatreThread = new Thread(() =>
            {
                Random random = new Random();
                while (quatreThread.IsAlive) 
                {
                    int faceDuDe = random.Next(1, 7);
                    if (!pictureBoxDeBleu.Disposing && !pictureBoxDeBleu.IsDisposed)
                    {
                        pictureBoxDeBleu.Invoke((MethodInvoker)delegate
                        {
                            pictureBoxDeBleu.Image = ObtenirImageDuDeBleu(faceDuDe);
                        });
                        pointDeBleu = faceDuDe;
                        textBoxPointBleu.Invoke((MethodInvoker)delegate
                        {
                            textBoxPointBleu.Text = pointDeBleu.ToString();
                        });
                    }

                    Thread.Sleep(50);
                }
            })
            { IsBackground = true };

            quatreThread.Start();
        }



        /*
         * Bouton arreter click
         */
        private void buttonArretNoir_Click(object sender, EventArgs e)
        {
            if (unThread != null && unThread.IsAlive)
            {
                unThread.Abort();
                unThread.Join();

                if (pointDeNoir == 1)
                {
                    sommeTotalNoir = 0;
                }
                else
                {
                    sommeTotalNoir += pointDeNoir;

                }

                textBoxPointNoir.Invoke((MethodInvoker)delegate
                {
                    textBoxPointNoir.Text = sommeTotalNoir.ToString();
                });


                if (sommeTotalNoir >= 25)
                {
                    richTextBoxJeu.Invoke((MethodInvoker)delegate
                    {
                        richTextBoxJeu.AppendText("Tu as gagné!\n");
                    });
                }
                PasserAuJoueurSuivant();
            }
        }


        private void buttonArretBlanc_Click(object sender, EventArgs e)
        {
            if (deuxThread != null && deuxThread.IsAlive)
            {
                deuxThread.Abort();
                deuxThread.Join();


                if (pointDeBlanc == 1)
                {
                    sommeTotalBlanc = 0;
                }
                else
                {
                    sommeTotalBlanc += pointDeBlanc;

                }

                textBoxPointBlanc.Invoke((MethodInvoker)delegate
                {
                    textBoxPointBlanc.Text = sommeTotalBlanc.ToString();
                });

                if (sommeTotalBlanc >= 25)
                {
                    richTextBoxJeu.Invoke((MethodInvoker)delegate
                    {
                        richTextBoxJeu.AppendText("Tu as gagné!\n");
                    });
                }
                PasserAuJoueurSuivant();

            }
        }

        private void buttonArretRouge_Click(object sender, EventArgs e)
        {
            if (troisThread != null && troisThread.IsAlive)
            {
                troisThread.Abort();
                troisThread.Join();


                if (pointDeRouge == 1)
                {
                    sommeTotalRouge = 0;
                }
                else
                {
                    sommeTotalRouge += pointDeRouge;

                }

                textBoxPointRouge.Invoke((MethodInvoker)delegate
                {
                    textBoxPointRouge.Text = sommeTotalRouge.ToString();
                });

                if (sommeTotalRouge >= 25)
                {
                    richTextBoxJeu.Invoke((MethodInvoker)delegate
                    {
                        richTextBoxJeu.AppendText("Tu as gagné!\n");
                    });
                }
                PasserAuJoueurSuivant();

            }
        }

        private void buttonArretBleu_Click(object sender, EventArgs e)
        {
            if (quatreThread != null && quatreThread.IsAlive)
            {
                quatreThread.Abort();
                quatreThread.Join();



                if (pointDeBleu == 1)
                {
                    sommeTotalBleu = 0;
                }
                else
                {
                    sommeTotalBleu += pointDeBleu;

                }

                textBoxPointBleu.Invoke((MethodInvoker)delegate
                {
                    textBoxPointBleu.Text = sommeTotalBleu.ToString();
                });

                if (sommeTotalBleu >= 25)
                {
                    richTextBoxJeu.Invoke((MethodInvoker)delegate
                    {
                        richTextBoxJeu.AppendText("Tu as gagné!\n");
                    });
                }
                PasserAuJoueurSuivant();
            }
        }

        /*
         *Méthode pour obtenir les images
         */
        private Image ObtenirImageDuDeRouge(int valeurDuDe)
        {
            string cheminImage = Path.Combine(chemin, deRouge[valeurDuDe - 1]);
            return Image.FromFile(cheminImage);
        }
        private Image ObtenirImageDuDeNoir(int valeurDuDe)
        {
            string cheminImage = Path.Combine(chemin, deNoir[valeurDuDe - 1]);
            return Image.FromFile(cheminImage);
        }
        private Image ObtenirImageDuDeBlanc(int valeurDuDe)
        {
            string cheminImage = Path.Combine(chemin, deBlanc[valeurDuDe - 1]);
            return Image.FromFile(cheminImage);
        }
        private Image ObtenirImageDuDeBleu(int valeurDuDe)
        {
            string cheminImage = Path.Combine(chemin, deBleu[valeurDuDe - 1]);
            return Image.FromFile(cheminImage);
        }

        private void buttonLanceNoir_Click(object sender, EventArgs e)
        {

            Thread1();
            JouerSon();
        }

        private void buttonLancerBlanc_Click(object sender, EventArgs e)
        {

            Thread2();
            JouerSon();

        }

        private void buttonLancerRouge_Click(object sender, EventArgs e)
        {

            Thread3();
            JouerSon();

        }

        private void buttonLanceBleu_Click(object sender, EventArgs e)
        {

            Thread4();
            JouerSon();

        }


        private void buttonSauvegarder_Click(object sender, EventArgs e)
        {
            SauvegardePoint();
        }

        /*
        * Initialisation méthode pour les dé 
        */
        public void InitialiserBleu()
        {
            for (int i = 1; i <= 6; i++)
            {
                deBleu[i - 1] = $"Bleu_{i}.png";
            }
        }

        public void InitialiserRouge()
        {
            for (int i = 1; i <= 6; i++)
            {
                deRouge[i - 1] = $"Rouge_{i}.png";
            }
        }

        public void InitialiserNoir()
        {
            for (int i = 1; i <= 6; i++)
            {
                deNoir[i - 1] = $"{i}.png";
            }
        }
        public void InitialiserBlanc()
        {
            for (int i = 1; i <= 6; i++)
            {
                deBlanc[i - 1] = $"Blanc_{i}.png";
            }
        }

        /*
         * Méthode pour faire jouer un son
         */
        public void JouerSon()
        {
            try
            {
                SoundPlayer lecteur = new SoundPlayer();
                lecteur.SoundLocation = Application.StartupPath + "\\" + fichierSon;
                lecteur.Play();
            }
            catch (Exception )
            {

                MessageBox.Show("Il y a un probleme avec le son!!");

            }
        }
        public void SauvegardePoint()
        {

            if (Joueurs != null)
            {
                string cheminFichier = Path.Combine(chemin, fichierTxt);

                using (StreamWriter writer = new StreamWriter(cheminFichier))
                {
                    foreach (Joueur joueur in Joueurs)
                    {
                        writer.WriteLine($"{joueur.Nom}:{joueur.Pointage}");
                    }
                }

                MessageBox.Show("Sauvegarde réussie !");
            }
            else
            {
                MessageBox.Show("Aucun joueur à sauvegarder !");
            }

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1.Show();
        }

        private void buttonNouvellePartie_Click(object sender, EventArgs e)
        {
            foreach (var joueur in Joueurs)
            {
                joueur.Pointage = 0;
            }

            richTextBoxJeu.AppendText("Nouvelle partie commencée. Les points ont été réinitialisés.\n");

            textBoxPointNoir.Text = "0";
            textBoxPointBlanc.Text = "0";
            textBoxPointRouge.Text = "0";
            textBoxPointBleu.Text = "0";

            ActiverDesactiverBoutons();

            ProchainTour(Joueurs[0]);
        }

        private void PasserAuJoueurSuivant()
        {
            if (Joueurs[indexJoueurActuel].Pointage == 0)
            {
                richTextBoxJeu.Invoke((MethodInvoker)delegate
                {
                    richTextBoxJeu.AppendText($"Le joueur {Joueurs[indexJoueurActuel].Nom} a terminé son tour.\n");
                });

                indexJoueurActuel = (indexJoueurActuel + 1) % Joueurs.Count;

                richTextBoxJeu.Invoke((MethodInvoker)delegate
                {
                    richTextBoxJeu.AppendText($"C'est au tour du joueur {Joueurs[indexJoueurActuel].Nom}.\n");
                });
            }
            ActiverDesactiverBoutonsJoueurs();

        }

        private void ActiverDesactiverBoutonsJoueurs()
        {
            for (int i = 0; i < Joueurs.Count; i++)
            {
                bool estTourJoueurActuel = i == indexJoueurActuel;

                switch (i)
                {
                    case 0:
                        buttonLanceNoir.Enabled = estTourJoueurActuel;
                        buttonArretNoir.Enabled = estTourJoueurActuel;
                        textBoxPointNoir.Enabled = estTourJoueurActuel;
                        pictureBoxDeNoir.Enabled = estTourJoueurActuel;
                        break;
                    case 1:
                        buttonLancerBlanc.Enabled = estTourJoueurActuel;
                        buttonArretBlanc.Enabled = estTourJoueurActuel;
                        textBoxPointBlanc.Enabled = estTourJoueurActuel;
                        pictureBoxDeBlanc.Enabled = estTourJoueurActuel;
                        break;
                    case 2:
                        buttonLancerRouge.Enabled = estTourJoueurActuel;
                        buttonArretRouge.Enabled = estTourJoueurActuel;
                        textBoxPointRouge.Enabled = estTourJoueurActuel;
                        pictureBoxDeRouge.Enabled = estTourJoueurActuel;
                        break;
                    case 3:
                        buttonLanceBleu.Enabled = estTourJoueurActuel;
                        buttonArretBleu.Enabled = estTourJoueurActuel;
                        textBoxPointBleu.Enabled = estTourJoueurActuel;
                        pictureBoxDeBleu.Enabled = estTourJoueurActuel;
                        break; 
                }
            }

        }
        private void ActiverDesactiverBoutons()
        {
            buttonLanceNoir.Enabled = true;
            buttonArretNoir.Enabled = true;
            textBoxPointNoir.Enabled = true;
            pictureBoxDeNoir.Enabled = true;

            buttonLancerBlanc.Enabled = false;
            buttonArretBlanc.Enabled = false;
            textBoxPointBlanc.Enabled = false;
            pictureBoxDeBlanc.Enabled = false;

            buttonLancerRouge.Enabled = false;
            buttonArretRouge.Enabled = false;
            textBoxPointRouge.Enabled = false;
            pictureBoxDeRouge.Enabled = false;

            buttonLanceBleu.Enabled = false;
            buttonArretBleu.Enabled = false;
            textBoxPointBleu.Enabled = false;
            pictureBoxDeBleu.Enabled = false;
        }

        private void ProchainTour(Joueur joueur)
        {
            richTextBoxJeu.AppendText($"C'est le tour de {joueur.Nom}.\n");

            ActiverDesactiverBoutons();

            if (joueur == Joueurs[0])
            {
                Thread1();
            }
            else if (joueur == Joueurs[1])
            {
                Thread2();
            }
            else if (joueur == Joueurs[2])
            {
                Thread3();
            }
            else if (joueur == Joueurs[3])
            {
                Thread4();
            }
        }

        public int MeilleurPointage
        {
            get
            {
                
                if (Joueurs != null && Joueurs.Count > 0)
                {
                    
                    Joueur meilleurJoueur = Joueurs.OrderByDescending(joueur => joueur.Pointage).First();

                    
                    return  meilleurJoueur.Pointage;
                }

                
                return 0;
            }
        }

    }
}

