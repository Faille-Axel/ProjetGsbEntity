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
    public partial class Fmodification : Form
    {
        List<Models.Domain.Frais> mesFrais;
        List<Models.Domain.Etat> mesEtats;
        Models.Domain.Frais unFrais;
        public Fmodification(List<Models.Domain.Frais>   mesF, Models.Domain.Frais f, List<Models.Domain.Etat> mesE)
        {
            InitializeComponent();
            this.mesFrais = mesF;
            this.unFrais = f;
            this.mesEtats = mesE;
        }


        /// <summary>
        /// On prépara les listes déroulants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fmodification_Load(object sender, EventArgs e)
        {
            foreach (Models.Domain.Frais unf in mesFrais)
            {
                cbFrais.Items.Add(unf.IdFrais);
            }

                 cbEtat.DisplayMember = "Text";
                cbEtat.ValueMember = "Value";
                foreach (Models.Domain.Etat unEtat in mesEtats)
                {
                    cbEtat.Items.Add(new { Text = unEtat.LibEtat, Value = unEtat.IdEtat });
                }
              
         
        }
        /// <summary>
        /// Sur l'événemement id Sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFrais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            Boolean trouve = false;

            int id = Int16.Parse(cbFrais.Text);

            while (index < mesFrais.Count && !trouve )
            {
                if ( id==mesFrais.ElementAtOrDefault(index).IdFrais)
                    {
                    trouve = true;
                    unFrais = mesFrais.ElementAtOrDefault(index);
                    dtDateModif.Value =(DateTime)  unFrais.Datemodification;
                    tbAnneeMois.Text = unFrais.Anneemois;
                    tbNbJustificatifs.Text = unFrais.Nbjustificatifs.ToString();
                    tbMontant.Text = unFrais.Montantvalide.ToString();
                    cbEtat.SelectedIndex = unFrais.IdEtat - 1;
                }
                index++;
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            int v = (int)(cbEtat.SelectedItem as dynamic).Value;
            unFrais.IdEtat = v;
            unFrais.Anneemois = tbAnneeMois.Text;
            unFrais.Montantvalide = Decimal.Parse(tbMontant.Text);
            unFrais.Nbjustificatifs = Int16.Parse(tbNbJustificatifs.Text);        
        }
    }
}
