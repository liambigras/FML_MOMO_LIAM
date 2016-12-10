namespace TP3
{
    partial class ModifierCircuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierCircuit));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTBOX_CircuitNom = new System.Windows.Forms.TextBox();
            this.TXTBOX_VDepart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTBOX_VArriver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NUD_Prix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Prix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Circuit :";
            // 
            // TXTBOX_CircuitNom
            // 
            this.TXTBOX_CircuitNom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TXTBOX_CircuitNom.Location = new System.Drawing.Point(139, 34);
            this.TXTBOX_CircuitNom.Name = "TXTBOX_CircuitNom";
            this.TXTBOX_CircuitNom.ReadOnly = true;
            this.TXTBOX_CircuitNom.Size = new System.Drawing.Size(128, 20);
            this.TXTBOX_CircuitNom.TabIndex = 1;
            // 
            // TXTBOX_VDepart
            // 
            this.TXTBOX_VDepart.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TXTBOX_VDepart.Location = new System.Drawing.Point(139, 78);
            this.TXTBOX_VDepart.Name = "TXTBOX_VDepart";
            this.TXTBOX_VDepart.Size = new System.Drawing.Size(128, 20);
            this.TXTBOX_VDepart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(53, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ville de départ :";
            // 
            // TXTBOX_VArriver
            // 
            this.TXTBOX_VArriver.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TXTBOX_VArriver.Location = new System.Drawing.Point(139, 119);
            this.TXTBOX_VArriver.Name = "TXTBOX_VArriver";
            this.TXTBOX_VArriver.Size = new System.Drawing.Size(128, 20);
            this.TXTBOX_VArriver.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(58, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ville d\'arrivée :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(103, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prix :";
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Annuler.BackgroundImage")));
            this.BTN_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Annuler.FlatAppearance.BorderSize = 0;
            this.BTN_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Annuler.Location = new System.Drawing.Point(139, 208);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(51, 47);
            this.BTN_Annuler.TabIndex = 11;
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Valider.BackgroundImage")));
            this.BTN_Valider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Valider.FlatAppearance.BorderSize = 0;
            this.BTN_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Valider.Location = new System.Drawing.Point(214, 207);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(53, 48);
            this.BTN_Valider.TabIndex = 10;
            this.BTN_Valider.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "$";
            // 
            // NUD_Prix
            // 
            this.NUD_Prix.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NUD_Prix.Location = new System.Drawing.Point(139, 161);
            this.NUD_Prix.Name = "NUD_Prix";
            this.NUD_Prix.Size = new System.Drawing.Size(128, 20);
            this.NUD_Prix.TabIndex = 13;
            this.NUD_Prix.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // ModifierCircuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(359, 313);
            this.Controls.Add(this.NUD_Prix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTBOX_VArriver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTBOX_VDepart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTBOX_CircuitNom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierCircuit";
            this.Text = "Modification d\'un Circuit";
            this.Load += new System.EventHandler(this.ModifierCircuit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Prix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBOX_CircuitNom;
        private System.Windows.Forms.TextBox TXTBOX_VDepart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTBOX_VArriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUD_Prix;
    }
}