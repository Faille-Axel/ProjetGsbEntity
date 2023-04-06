namespace ProjetGsbEntity.Presentation
{
    partial class FAfficheFrais
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
            this.btFermer = new System.Windows.Forms.Button();
            this.dgvFrais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(295, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Affichage de la liste des Frais";
            // 
            // btFermer
            // 
            this.btFermer.Location = new System.Drawing.Point(1120, 493);
            this.btFermer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(233, 68);
            this.btFermer.TabIndex = 1;
            this.btFermer.Text = "Fermer";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // dgvFrais
            // 
            this.dgvFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrais.Location = new System.Drawing.Point(295, 149);
            this.dgvFrais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvFrais.Name = "dgvFrais";
            this.dgvFrais.Size = new System.Drawing.Size(941, 226);
            this.dgvFrais.TabIndex = 2;
            // 
            // FAfficheFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 629);
            this.Controls.Add(this.dgvFrais);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FAfficheFrais";
            this.Text = "FAfficheFrais";
            this.Load += new System.EventHandler(this.FAfficheFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFermer;
        private System.Windows.Forms.DataGridView dgvFrais;
    }
}