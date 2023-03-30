using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetGsbEntity.Presentation
{
   
    public partial class FajoutFrais : Form

    {
        private List<Models.Domain.Etat> mesEtats;
        private Models.Domain.Frais unFrais;
        public FajoutFrais(List<Models.Domain.Etat> mesE, Models.Domain.Frais unF)
        {
            InitializeComponent();
            mesEtats = mesE;
            unFrais = unF;
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Gestion de la combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FajoutFrais_Load(object sender, EventArgs e)
        {
            
                cbEtat.DisplayMember = "Text";
                cbEtat.ValueMember = "Value";

                foreach (Models.Domain.Etat unEtat in mesEtats)
                {
                    cbEtat.Items.Add(new { Text = unEtat.LibEtat, Value = unEtat.IdEtat });
                }
        }

        /// <summary>
        /// Contrôle des données numériques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nb_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                var controller = (TextBox)sender;
                String text = controller.Text;

                if (NombreOccurence(text, '.') == 1)
                {
                    if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
                else
                {
                    if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)46))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
        }

        int NombreOccurence(String chn, char c)
        {
            int cnt = 0;
            foreach (char car in chn)
            {
                if (c == car) cnt++;
            }
            return cnt;
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            String temp = "";
            int v= (int)(cbEtat.SelectedItem as dynamic).Value;
            unFrais.IdEtat = v;
           // unFrais.id_etat = 
                temp = tbAnneeMois.Text;
                if (temp != "")
                {
                    unFrais.Anneemois = temp;
                    temp = tbMontantValide.Text;
                    if (temp != "")
                    {
                        unFrais.Montantvalide = Decimal.Parse(temp);
                    unFrais.Datemodification = (DateTime)dtDateModif.Value;
                        temp = tbNbJustificatifs.Text;
                        if (temp != "")
                        {
                            unFrais.Nbjustificatifs = Int16.Parse(temp);  
                        }
                        else
                        {
                            MessageBox.Show("erreur de saisie", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtDateModif.Focus();
                        }     
                    }
                    else
                    {
                        MessageBox.Show("erreur de saisie", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbMontantValide.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("erreur de saisie", "Saisie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbAnneeMois.Focus();
                }

            }
            

        }
    }

