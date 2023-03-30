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
  
    public partial class FAfficheFrais : Form
    {
        private List<Models.Domain.Frais> mesFrais = null;
        public FAfficheFrais(List<Models.Domain.Frais> mesF)
        {
            InitializeComponent();
            mesFrais = mesF;

        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAfficheFrais_Load(object sender, EventArgs e)
        {
            dgvFrais.DataSource = mesFrais;
        }
    }
}
