using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetGsbEntity
{
    public partial class Fprincipale : Form
    {
        /// <summary>
        /// variable partagé entre les services
        /// 
        /// </summary>
        private Models.Domain.Visiteur unVisiteur;


        public Fprincipale()
        {
            InitializeComponent();
            Init_Etat();
        }

        private void Init_Etat()
        {
            déconnexionToolStripMenuItem.Enabled = false;
            interrogerToolStripMenuItem.Enabled = false;
            FraisToolStripMenuItem.Enabled = false;
            connexionToolStripMenuItem.Enabled = true;
        }
        /// <summary>
        /// Connexion d'un visiteur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] Credential = new  String[] { " ", " " };
            String login;
            String mdp;
           
                Presentation.Fconnexion f = new Presentation.Fconnexion(Credential);
             
                DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                //
                login = Credential[0];
                mdp = Credential[1];
                unVisiteur = Models.Dao.ServiceConnexion.getInstance().RechercheUnVisiteur(login);
                // on controle le mot de passe
                try
                {
                    if (unVisiteur != null)
                    {
                        try
                        {
                            String sel = unVisiteur.SelVisiteur;
                            // on récupère le sel 
                            Byte[] salt = Utilitaires.MonMotPassHash.transformeEnBytes(sel);
                            // on génère le mot de passe 
                            Byte[] tempo = Utilitaires.MonMotPassHash.transformeEnBytes(unVisiteur.PwdVisiteur);
                            if (Utilitaires.MonMotPassHash.VerifyPassword(salt, mdp, tempo) == true)

                            {
                                lb_etat.Text = "Etat connecté";
                                déconnexionToolStripMenuItem.Enabled = true;
                                interrogerToolStripMenuItem.Enabled = true;
                                FraisToolStripMenuItem.Enabled = true;
                                connexionToolStripMenuItem.Enabled = false;
                                                         }
                            else
                                MessageBox.Show("Erreur", "Erreur lors du contrôle  du mot de passe pour : " + Credential[0]);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Erreur", "Erreur lors du contrôle : " + err.Message);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur", "Erreur  login erroné : " + Credential[0]);

                    }
                }
                catch (MesExceptions.MonException er)
                {
                    MessageBox.Show("Erreur", "Erreur lors de l'authentification : " + er.Message);

                }
            }
        }
             

        /// <summary>
        /// On quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unVisiteur = null;
            Init_Etat();

        }
      
        /// <summary>
        /// ajout d'un Frais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Domain.Frais unFrais = new Models.Domain.Frais();
                List<Models.Domain.Etat> mesEtats = Models.Dao.ServiceVisiteur.getInstance().ListedesEtats();
                Presentation.FajoutFrais f = new Presentation.FajoutFrais(mesEtats, unFrais);
                f.ShowDialog();
                unFrais.IdVisiteur= unVisiteur.IdVisiteur;
                Models.Dao.ServiceVisiteur.getInstance().AjouteFrais(unFrais);
                Models.Dao.ServiceVisiteur.getInstance().MiseAjourDuModele();
            }
           
            catch (MesExceptions.MonException er)
            {
                MessageBox.Show(er.Message, "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Domain.Frais unFrais = new Models.Domain.Frais();
                List<Models.Domain.Etat> mesEtats = Models.Dao.ServiceVisiteur.getInstance().ListedesEtats();
                List<Models.Domain.Frais> mesFrais = Models.Dao.ServiceVisiteur.getInstance().ListedesFraisVisiteur(unVisiteur.IdVisiteur);
                Presentation.Fmodification f = new Presentation.Fmodification(mesFrais, unFrais, mesEtats);
                f.ShowDialog();
                unFrais.IdVisiteur = unVisiteur.IdVisiteur;
                Models.Dao.ServiceVisiteur.getInstance().MiseAjourDuModele();
            }

            catch (MesExceptions.MonException er)
            {
                MessageBox.Show(er.Message, "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void miseÀJourMotPasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Models.Domain.Visiteur> mesVisiteurs;
            try
            {

                mesVisiteurs = Models.Dao.ServiceVisiteur.getInstance().GetListeVisiteur();
                Byte[] selByte;
                Byte[] mdpByte;
                String sel;
                String mdp;
                foreach (Models.Domain.Visiteur unV in mesVisiteurs)
                {
                     selByte = Utilitaires.MonMotPassHash.GenerateSalt();
                     mdpByte = Utilitaires.MonMotPassHash.PasswordHashe("secret", selByte);
                     sel = Utilitaires.MonMotPassHash.BytesToString(selByte);
                     mdp = Utilitaires.MonMotPassHash.BytesToString(mdpByte);
                    unV.SelVisiteur = sel;
                    unV.PwdVisiteur = mdp;
                }
                
                Models.Dao.ServiceVisiteur.getInstance().MiseAjourDuModele();
                MessageBox.Show("Mise à jour", "Mise à jour effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MesExceptions.MonException er)
            {
                MessageBox.Show(er.Message, "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Appel de la liste des Frais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listeDesFraisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Models.Domain.Frais> mesFrais = Models.Dao.ServiceVisiteur.getInstance().ListedesFraisVisiteur(unVisiteur.IdVisiteur);
                Presentation.FAfficheFrais f = new Presentation.FAfficheFrais(mesFrais);
                f.ShowDialog();
            }
            catch (MesExceptions.MonException er)
            {
                MessageBox.Show(er.Message, "Lecture des Frais", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ajouterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
    }
    

