using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetGsbEntity.Presentation
{
    public partial class FAffichePraticien : Form
    {
        private List<Models.Domain.Praticien> mesPraticiens = null;
        public FAffichePraticien(List<Models.Domain.Praticien> mesPrat)
        {
            InitializeComponent();
            mesPraticiens = mesPrat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAffichePraticien_Load(object sender, EventArgs e)
        {
            dgvPraticien.DataSource = mesPraticiens;
        }
    }
}
