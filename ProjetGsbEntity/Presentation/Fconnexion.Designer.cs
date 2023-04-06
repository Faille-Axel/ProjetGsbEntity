namespace ProjetGsbEntity.Presentation
{
    partial class Fconnexion
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMotPasse = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.tbAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(288, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion d\'un visiteur";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(356, 318);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(6);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(180, 29);
            this.tbLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mot de passe ";
            // 
            // tbMotPasse
            // 
            this.tbMotPasse.Location = new System.Drawing.Point(356, 447);
            this.tbMotPasse.Margin = new System.Windows.Forms.Padding(6);
            this.tbMotPasse.Name = "tbMotPasse";
            this.tbMotPasse.PasswordChar = '*';
            this.tbMotPasse.Size = new System.Drawing.Size(180, 29);
            this.tbMotPasse.TabIndex = 4;
            // 
            // btValider
            // 
            this.btValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btValider.Location = new System.Drawing.Point(488, 562);
            this.btValider.Margin = new System.Windows.Forms.Padding(6);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(138, 42);
            this.btValider.TabIndex = 5;
            this.btValider.Text = "Connecter";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // tbAnnuler
            // 
            this.tbAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tbAnnuler.Location = new System.Drawing.Point(696, 562);
            this.tbAnnuler.Margin = new System.Windows.Forms.Padding(6);
            this.tbAnnuler.Name = "tbAnnuler";
            this.tbAnnuler.Size = new System.Drawing.Size(138, 42);
            this.tbAnnuler.TabIndex = 6;
            this.tbAnnuler.Text = "Annuler";
            this.tbAnnuler.UseVisualStyleBackColor = true;
            // 
            // Fconnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 657);
            this.Controls.Add(this.tbAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbMotPasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Fconnexion";
            this.Text = "Fconnexion";
            this.Validated += new System.EventHandler(this.btValider_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMotPasse;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button tbAnnuler;
    }
}