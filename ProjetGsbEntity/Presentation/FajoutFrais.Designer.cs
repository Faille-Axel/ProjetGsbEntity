namespace ProjetGsbEntity.Presentation
{
    partial class FajoutFrais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.tbAnneeMois = new System.Windows.Forms.TextBox();
            this.tbNbJustificatifs = new System.Windows.Forms.TextBox();
            this.dtDateModif = new System.Windows.Forms.DateTimePicker();
            this.tbMontantValide = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajout d\'un Frais";
            // 
            // btValider
            // 
            this.btValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btValider.Location = new System.Drawing.Point(621, 532);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(125, 42);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.Location = new System.Drawing.Point(826, 532);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(125, 42);
            this.btAnnuler.TabIndex = 3;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Etat Frais :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Année mois :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre de justificatifs :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date de modification :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(101, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Montant validé :";
            // 
            // cbEtat
            // 
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Location = new System.Drawing.Point(382, 229);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(189, 21);
            this.cbEtat.TabIndex = 10;
            // 
            // tbAnneeMois
            // 
            this.tbAnneeMois.Location = new System.Drawing.Point(382, 270);
            this.tbAnneeMois.Name = "tbAnneeMois";
            this.tbAnneeMois.Size = new System.Drawing.Size(189, 20);
            this.tbAnneeMois.TabIndex = 11;
            // 
            // tbNbJustificatifs
            // 
            this.tbNbJustificatifs.Location = new System.Drawing.Point(382, 317);
            this.tbNbJustificatifs.Name = "tbNbJustificatifs";
            this.tbNbJustificatifs.Size = new System.Drawing.Size(189, 20);
            this.tbNbJustificatifs.TabIndex = 12;
            this.tbNbJustificatifs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nb_KeyPress);
            // 
            // dtDateModif
            // 
            this.dtDateModif.Location = new System.Drawing.Point(382, 368);
            this.dtDateModif.Name = "dtDateModif";
            this.dtDateModif.Size = new System.Drawing.Size(189, 20);
            this.dtDateModif.TabIndex = 13;
            // 
            // tbMontantValide
            // 
            this.tbMontantValide.Location = new System.Drawing.Point(382, 423);
            this.tbMontantValide.Name = "tbMontantValide";
            this.tbMontantValide.Size = new System.Drawing.Size(189, 20);
            this.tbMontantValide.TabIndex = 14;
            this.tbMontantValide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nb_KeyPress);
            // 
            // FajoutFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 616);
            this.Controls.Add(this.tbMontantValide);
            this.Controls.Add(this.dtDateModif);
            this.Controls.Add(this.tbNbJustificatifs);
            this.Controls.Add(this.tbAnneeMois);
            this.Controls.Add(this.cbEtat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label1);
            this.Name = "FajoutFrais";
            this.Text = "FajoutFrais";
            this.Load += new System.EventHandler(this.FajoutFrais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.TextBox tbAnneeMois;
        private System.Windows.Forms.TextBox tbNbJustificatifs;
        private System.Windows.Forms.DateTimePicker dtDateModif;
        private System.Windows.Forms.TextBox tbMontantValide;
    }
}