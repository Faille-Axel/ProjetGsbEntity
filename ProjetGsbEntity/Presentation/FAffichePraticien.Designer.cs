namespace ProjetGsbEntity.Presentation
{
    partial class FAffichePraticien
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
            this.dgvPraticien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(908, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Affichage de la liste des Praticiens";
            // 
            // dgvPraticien
            // 
            this.dgvPraticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPraticien.Location = new System.Drawing.Point(227, 143);
            this.dgvPraticien.Name = "dgvPraticien";
            this.dgvPraticien.RowTemplate.Height = 25;
            this.dgvPraticien.Size = new System.Drawing.Size(908, 247);
            this.dgvPraticien.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1002, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FAffichePraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPraticien);
            this.Controls.Add(this.label1);
            this.Name = "FAffichePraticien";
            this.Text = "FAffichePraticien";
            this.Load += new System.EventHandler(this.FAffichePraticien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPraticien;
        private System.Windows.Forms.Button button1;
    }
}