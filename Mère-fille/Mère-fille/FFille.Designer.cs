namespace Mère_fille
{
    partial class FFille
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
            this.lb_ChNom = new System.Windows.Forms.Label();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.bt_Changer = new System.Windows.Forms.Button();
            this.bt_MaMère = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ChNom
            // 
            this.lb_ChNom.AutoSize = true;
            this.lb_ChNom.Location = new System.Drawing.Point(41, 35);
            this.lb_ChNom.Name = "lb_ChNom";
            this.lb_ChNom.Size = new System.Drawing.Size(95, 13);
            this.lb_ChNom.TabIndex = 0;
            this.lb_ChNom.Text = "je change de nom:";
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(161, 32);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(100, 20);
            this.tb_Nom.TabIndex = 1;
            // 
            // bt_Changer
            // 
            this.bt_Changer.Location = new System.Drawing.Point(306, 30);
            this.bt_Changer.Name = "bt_Changer";
            this.bt_Changer.Size = new System.Drawing.Size(75, 23);
            this.bt_Changer.TabIndex = 2;
            this.bt_Changer.Text = "Changer";
            this.bt_Changer.UseVisualStyleBackColor = true;
            // 
            // bt_MaMère
            // 
            this.bt_MaMère.Location = new System.Drawing.Point(161, 115);
            this.bt_MaMère.Name = "bt_MaMère";
            this.bt_MaMère.Size = new System.Drawing.Size(75, 23);
            this.bt_MaMère.TabIndex = 3;
            this.bt_MaMère.Text = "Ma Mère";
            this.bt_MaMère.UseVisualStyleBackColor = true;
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 194);
            this.Controls.Add(this.bt_MaMère);
            this.Controls.Add(this.bt_Changer);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.lb_ChNom);
            this.Name = "FFille";
            this.Text = "Fille";
            this.Load += new System.EventHandler(this.FFille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ChNom;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.Button bt_Changer;
        private System.Windows.Forms.Button bt_MaMère;
    }
}