using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu
{
    public partial class Form1 : Form
    {

        bool PartieEnCours;
        string motJeu;
        string motAffiche;
        char[] LettresUtilisés = new char[26];
        int viesJoueur;
        Image[] pendues = new Image[11];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialisation des images de pendus
            pendues[0] = Pendu.Properties.Resources.pendu10;
            pendues[1] = Pendu.Properties.Resources.pendu9;
            pendues[2] = Pendu.Properties.Resources.pendu8;
            pendues[3] = Pendu.Properties.Resources.pendu7;
            pendues[4] = Pendu.Properties.Resources.pendu6;
            pendues[5] = Pendu.Properties.Resources.pendu5;
            pendues[6] = Pendu.Properties.Resources.pendu4;
            pendues[7] = Pendu.Properties.Resources.pendu3;
            pendues[8] = Pendu.Properties.Resources.pendu2;
            pendues[9] = Pendu.Properties.Resources.pendu1;
            pendues[10] = Pendu.Properties.Resources.pendu0;

            lblGagneOuPerdu.Text = "";

            InitialisationPartie();

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Si la partie n'est pas en cours, le mot doit être saisie dans le champ tbxUtilisateur
            if (!PartieEnCours)
            {
                string motSaisie = txbUtilisateur.Text;
                //Vérification de la validité du mot

                //Pas de mot
                if (motSaisie.Length <= 0)
                {
                    lblInfos.Text = "Pas de mot saisie";
                }
                //Mot trop long
                else if (motSaisie.Length > 15)
                {
                    lblInfos.Text = "Le mot doit comporter moins de 15 lettres";
                }
                //Longueur mot ok
                else
                {
                    //Vérification de la validité du mot
                    if (MotValide(motSaisie))
                    {
                        InitialisationDeviner(motSaisie);
                    }
                    else
                    {
                        lblInfos.Text = "Le mot ne doit contenir que des lettres";
                    }


                }

            }
            //Si la partie est en cours et que le joueur essaie de deviner le mot
            else if(txbUtilisateur.Text != "")
            {
                //Vérification de la saisie de l'utilisateur
                string motSaisie = txbUtilisateur.Text;
                if (!MotValide(motSaisie))
                {
                    lblInfos.Text = "Le mot ne doit contenir que des lettres";
                }
                else if (motSaisie.Length > 15)
                {
                    lblInfos.Text = "Le mot ne peut pas contenir plus de 15 lettres";
                }
                else 
                {
                    DevinerMot(motSaisie);
                }
            }
            //Sinon le joueur essaie de choisir une lettre
            else
            {
                //Si aucune lettre n'est selectionné
                if(cmbLettres.SelectedIndex == -1)
                {
                    lblInfos.Text = "Aucune lettre n'est selectionné";
                }
                else
                {
                    DevinerLettre();
                }
            }
        }

        void InitialisationPartie()
        {
            PartieEnCours = false;
            lblMotAffiche.Text = "";
            lblInfos.Text = "Choisissez un mot à faire deviner";
            PartieEnCours = false;

            cmbLettres.Items.Clear();

        }

        void InitialisationDeviner(string mot)
        {
            viesJoueur = 10;
            imgPendu.Image = pendues[viesJoueur];

            PartieEnCours = true;
            txbUtilisateur.Text = "";

            motJeu = mot;
            motJeu =  motJeu.ToUpper();

            //Initialisation de cmbLettres
            for (int i = 0; i < 26; i++)
            {
                cmbLettres.Items.Add(char.ConvertFromUtf32((int)'A' + i));
            }

            //Création du mot Affiché
            motAffiche = "_";

            for (int i = 1; i < motJeu.Length; i++)
            {
                motAffiche += " _";
            }
            lblMotAffiche.Text = motAffiche;
            lblInfos.Text = "Choisissez une lettre dans le menu puis validez";
        }

        void DevinerMot(string motSaisie)
        {
            motSaisie = motSaisie.ToUpper();
            //Si le mot correspond
            if (motSaisie == motJeu)
            {
                Gagne();

            }
            else
            {
                viesJoueur--;
                imgPendu.Image = pendues[viesJoueur];
                txbUtilisateur.Text = "";
                if (viesJoueur == 0)
                {
                    Perdu();
                }
            }

        }

        void DevinerLettre()
        {
            char caractere = cmbLettres.SelectedItem.ToString()[0];

            //Si la lettre est bien dans le mot
            if ( motJeu.Contains( caractere.ToString() ))
            {

                //Remplacer les caractere correspondant dans motAffiche
                for(int i=0; i<motJeu.Length; i++)
                {
                    if(motJeu[i] == caractere )
                    {
                        motAffiche =  motAffiche.Insert(i * 2, caractere.ToString());
                        motAffiche =  motAffiche.Remove(i * 2 +1, 1);
                    }
                }

                lblMotAffiche.Text = motAffiche;
                cmbLettres.Items.RemoveAt(cmbLettres.SelectedIndex);
                cmbLettres.SelectedIndex = -1;

            }
            else
            {
                viesJoueur--;
                imgPendu.Image = pendues[viesJoueur];
                cmbLettres.SelectedIndex = -1;
                if (viesJoueur == 0)
                {
                    Perdu();
                }
            }
        }

        void Perdu()
        {
            lblGagneOuPerdu.Text = "Perdu...";
            lblMotAffiche.Text = motJeu;
            InitialisationPartie();
        }

        void Gagne()
        {
            lblGagneOuPerdu.Text = "VOUS AVEZ GAGNE !";
            InitialisationPartie();
        }

        //Renvoi True uniquement si le mot est composé uniquement de lettres (majuscule ou minuscule)
        static bool MotValide(string mot)
        {
            bool motValide = true;
            for(int i=0; i<mot.Length && motValide; i++)
            {
                if( !CaractereValide(mot[i]))
                {
                    motValide = false;
                }
            }
            return motValide;
        }

        //Renvoi True uniquement si le caractère est une lettre (majuscule ou minuscule)
        static bool CaractereValide(char c)
        {
            //Si il s'agi d'une Majuscule
            if( c >='A' && c <='Z')
            {
                return true;
            }
            //Si c'est une minuscule
            else if(c >= 'a' && c <= 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txbUtilisateur_TextChanged(object sender, EventArgs e)
        {
            cmbLettres.SelectedIndex = -1;
        }

        private void cmbLettres_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbUtilisateur.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
