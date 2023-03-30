namespace ProjetGsbEntity.Presentation
{
    partial class Fmodification
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
            this.cbFrais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.tbAnneeMois = new System.Windows.Forms.TextBox();
            this.tbNbJustificatifs = new System.Windows.Forms.TextBox();
            this.dtDateModif = new System.Windows.Forms.DateTimePicker();
            this.tbMontant = new System.Windows.Forms.TextBox();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modification d\'un  Frais";
            // 
            // cbFrais
            // 
            this.cbFrais.FormattingEnabled = true;
            this.cbFrais.Location = new System.Drawing.Point(226, 101);
            this.cbFrais.Name = "cbFrais";
            this.cbFrais.Size = new System.Drawing.Size(121, 21);
            this.cbFrais.TabIndex = 3;
            this.cbFrais.SelectedIndexChanged += new System.EventHandler(this.cbFrais_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choix d\'un Frais :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Montant validé :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date de modification :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre de justificatifs :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Année mois :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Etat Frais :";
            // 
            // cbEtat
            // 
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Location = new System.Drawing.Point(423, 190);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(200, 21);
            this.cbEtat.TabIndex = 15;
            // 
            // tbAnneeMois
            // 
            this.tbAnneeMois.Location = new System.Drawing.Point(423, 236);
            this.tbAnneeMois.Name = "tbAnneeMois";
            this.tbAnneeMois.Size = new System.Drawing.Size(200, 20);
            this.tbAnneeMois.TabIndex = 16;
            // 
            // tbNbJustificatifs
            // 
            this.tbNbJustificatifs.Location = new System.Drawing.Point(423, 280);
            this.tbNbJustificatifs.Name = "tbNbJustificatifs";
            this.tbNbJustificatifs.Size = new System.Drawing.Size(200, 20);
            this.tbNbJustificatifs.TabIndex = 17;
            // 
            // dtDateModif
            // 
            this.dtDateModif.Location = new System.Drawing.Point(423, 328);
            this.dtDateModif.Name = "dtDateModif";
            this.dtDateModif.Size = new System.Drawing.Size(200, 20);
            this.dtDateModif.TabIndex = 18;
            // 
            // tbMontant
            // 
            this.tbMontant.Location = new System.Drawing.Point(423, 381);
            this.tbMontant.Name = "tbMontant";
            this.tbMontant.Size = new System.Drawing.Size(200, 20);
            this.tbMontant.TabIndex = 19;
            // 
            // btAnnuler
            // 
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.Location = new System.Drawing.Point(930, 466);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(125, 42);
            this.btAnnuler.TabIndex = 21;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // btValider
            // 
            this.btValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btValider.Location = new System.Drawing.Point(725, 466);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(125, 42);
            this.btValider.TabIndex = 20;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // Fmodification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 549);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbMontant);
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
            this.Controls.Add(this.cbFrais);
            this.Controls.Add(this.label1);
            this.Name = "Fmodification";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fmodification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFrais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.TextBox tbAnneeMois;
        private System.Windows.Forms.TextBox tbNbJustificatifs;
        private System.Windows.Forms.DateTimePicker dtDateModif;
        private System.Windows.Forms.TextBox tbMontant;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
    }
}