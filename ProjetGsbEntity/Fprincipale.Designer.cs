namespace ProjetGsbEntity
{
    partial class Fprincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interrogerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesPraticiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourMotPasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_etat = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.praticienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.interrogerToolStripMenuItem,
            this.FraisToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.praticienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click_1);
            // 
            // interrogerToolStripMenuItem
            // 
            this.interrogerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesFraisToolStripMenuItem,
            this.listeDesPraticiensToolStripMenuItem});
            this.interrogerToolStripMenuItem.Name = "interrogerToolStripMenuItem";
            this.interrogerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.interrogerToolStripMenuItem.Text = "Interroger";
            this.interrogerToolStripMenuItem.Click += new System.EventHandler(this.interrogerToolStripMenuItem_Click);
            // 
            // listeDesFraisToolStripMenuItem
            // 
            this.listeDesFraisToolStripMenuItem.Name = "listeDesFraisToolStripMenuItem";
            this.listeDesFraisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesFraisToolStripMenuItem.Text = "Liste des Frais";
            this.listeDesFraisToolStripMenuItem.Click += new System.EventHandler(this.listeDesFraisToolStripMenuItem_Click_1);
            // 
            // listeDesPraticiensToolStripMenuItem
            // 
            this.listeDesPraticiensToolStripMenuItem.Name = "listeDesPraticiensToolStripMenuItem";
            this.listeDesPraticiensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesPraticiensToolStripMenuItem.Text = "Liste des praticiens";
            this.listeDesPraticiensToolStripMenuItem.Click += new System.EventHandler(this.listeDesPraticiensToolStripMenuItem_Click);
            // 
            // FraisToolStripMenuItem
            // 
            this.FraisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.FraisToolStripMenuItem.Name = "FraisToolStripMenuItem";
            this.FraisToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.FraisToolStripMenuItem.Text = "Frais";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click_1);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseÀJourMotPasseToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // miseÀJourMotPasseToolStripMenuItem
            // 
            this.miseÀJourMotPasseToolStripMenuItem.Name = "miseÀJourMotPasseToolStripMenuItem";
            this.miseÀJourMotPasseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.miseÀJourMotPasseToolStripMenuItem.Text = "Mise à jour Mot Passe";
            this.miseÀJourMotPasseToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourMotPasseToolStripMenuItem_Click);
            // 
            // lb_etat
            // 
            this.lb_etat.AutoSize = true;
            this.lb_etat.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_etat.Location = new System.Drawing.Point(14, 490);
            this.lb_etat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_etat.Name = "lb_etat";
            this.lb_etat.Size = new System.Drawing.Size(123, 21);
            this.lb_etat.TabIndex = 1;
            this.lb_etat.Text = "non connecté";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1328, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // praticienToolStripMenuItem
            // 
            this.praticienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1});
            this.praticienToolStripMenuItem.Name = "praticienToolStripMenuItem";
            this.praticienToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.praticienToolStripMenuItem.Text = "Praticien";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            // 
            // Fprincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 516);
            this.Controls.Add(this.lb_etat);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Fprincipale";
            this.Text = "Gestion des Frais";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interrogerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.Label lb_etat;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourMotPasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesPraticiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem praticienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
    }
}

