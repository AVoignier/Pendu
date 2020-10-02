namespace Pendu
{
    partial class Form1
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
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.lblInfos = new System.Windows.Forms.Label();
            this.txbUtilisateur = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblMotAffiche = new System.Windows.Forms.Label();
            this.cmbLettres = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblGagneOuPerdu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPendu
            // 
            this.imgPendu.Image = global::Pendu.Properties.Resources.pendu0;
            this.imgPendu.Location = new System.Drawing.Point(12, 12);
            this.imgPendu.Name = "imgPendu";
            this.imgPendu.Size = new System.Drawing.Size(365, 357);
            this.imgPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPendu.TabIndex = 0;
            this.imgPendu.TabStop = false;
            // 
            // lblInfos
            // 
            this.lblInfos.AutoSize = true;
            this.lblInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(385, 13);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(45, 16);
            this.lblInfos.TabIndex = 1;
            this.lblInfos.Text = "label1";
            // 
            // txbUtilisateur
            // 
            this.txbUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUtilisateur.Location = new System.Drawing.Point(386, 32);
            this.txbUtilisateur.Name = "txbUtilisateur";
            this.txbUtilisateur.Size = new System.Drawing.Size(246, 26);
            this.txbUtilisateur.TabIndex = 2;
            this.txbUtilisateur.TextChanged += new System.EventHandler(this.txbUtilisateur_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(390, 278);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(243, 40);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblMotAffiche
            // 
            this.lblMotAffiche.AutoSize = true;
            this.lblMotAffiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotAffiche.Location = new System.Drawing.Point(386, 61);
            this.lblMotAffiche.Name = "lblMotAffiche";
            this.lblMotAffiche.Size = new System.Drawing.Size(86, 20);
            this.lblMotAffiche.TabIndex = 5;
            this.lblMotAffiche.Text = "MotAffiche";
            // 
            // cmbLettres
            // 
            this.cmbLettres.FormattingEnabled = true;
            this.cmbLettres.Location = new System.Drawing.Point(388, 85);
            this.cmbLettres.Name = "cmbLettres";
            this.cmbLettres.Size = new System.Drawing.Size(121, 21);
            this.cmbLettres.TabIndex = 6;
            this.cmbLettres.SelectedIndexChanged += new System.EventHandler(this.cmbLettres_SelectedIndexChanged);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(390, 324);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(243, 40);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblGagneOuPerdu
            // 
            this.lblGagneOuPerdu.AutoSize = true;
            this.lblGagneOuPerdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGagneOuPerdu.Location = new System.Drawing.Point(390, 182);
            this.lblGagneOuPerdu.Name = "lblGagneOuPerdu";
            this.lblGagneOuPerdu.Size = new System.Drawing.Size(163, 24);
            this.lblGagneOuPerdu.TabIndex = 8;
            this.lblGagneOuPerdu.Text = "lblGagneOuPerdu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 385);
            this.Controls.Add(this.lblGagneOuPerdu);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.cmbLettres);
            this.Controls.Add(this.lblMotAffiche);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txbUtilisateur);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.imgPendu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPendu;
        private System.Windows.Forms.Label lblInfos;
        private System.Windows.Forms.TextBox txbUtilisateur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblMotAffiche;
        private System.Windows.Forms.ComboBox cmbLettres;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblGagneOuPerdu;
    }
}

