namespace Mère_fille
{
    partial class FMere
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
            this.lbLesFilles = new System.Windows.Forms.ListBox();
            this.bt_New = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_Show = new System.Windows.Forms.Button();
            this.bt_Hide = new System.Windows.Forms.Button();
            this.bt_ShDial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLesFilles
            // 
            this.lbLesFilles.FormattingEnabled = true;
            this.lbLesFilles.Location = new System.Drawing.Point(43, 62);
            this.lbLesFilles.Name = "lbLesFilles";
            this.lbLesFilles.Size = new System.Drawing.Size(190, 121);
            this.lbLesFilles.TabIndex = 0;
            // 
            // bt_New
            // 
            this.bt_New.Location = new System.Drawing.Point(43, 12);
            this.bt_New.Name = "bt_New";
            this.bt_New.Size = new System.Drawing.Size(75, 23);
            this.bt_New.TabIndex = 1;
            this.bt_New.Text = "New()";
            this.bt_New.UseVisualStyleBackColor = true;
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(158, 12);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 23);
            this.bt_Close.TabIndex = 2;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            // 
            // bt_Show
            // 
            this.bt_Show.Location = new System.Drawing.Point(43, 189);
            this.bt_Show.Name = "bt_Show";
            this.bt_Show.Size = new System.Drawing.Size(75, 23);
            this.bt_Show.TabIndex = 3;
            this.bt_Show.Text = "Show";
            this.bt_Show.UseVisualStyleBackColor = true;
            // 
            // bt_Hide
            // 
            this.bt_Hide.Location = new System.Drawing.Point(158, 189);
            this.bt_Hide.Name = "bt_Hide";
            this.bt_Hide.Size = new System.Drawing.Size(75, 23);
            this.bt_Hide.TabIndex = 4;
            this.bt_Hide.Text = "Hide";
            this.bt_Hide.UseVisualStyleBackColor = true;
            // 
            // bt_ShDial
            // 
            this.bt_ShDial.Location = new System.Drawing.Point(43, 218);
            this.bt_ShDial.Name = "bt_ShDial";
            this.bt_ShDial.Size = new System.Drawing.Size(75, 23);
            this.bt_ShDial.TabIndex = 5;
            this.bt_ShDial.Text = "ShowDialog";
            this.bt_ShDial.UseVisualStyleBackColor = true;
            // 
            // FMere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 271);
            this.Controls.Add(this.bt_ShDial);
            this.Controls.Add(this.bt_Hide);
            this.Controls.Add(this.bt_Show);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_New);
            this.Controls.Add(this.lbLesFilles);
            this.Name = "FMere";
            this.Text = "Mère";
            this.Load += new System.EventHandler(this.FMere_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLesFilles;
        private System.Windows.Forms.Button bt_New;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_Show;
        private System.Windows.Forms.Button bt_Hide;
        private System.Windows.Forms.Button bt_ShDial;
    }
}

