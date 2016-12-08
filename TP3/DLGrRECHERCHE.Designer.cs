namespace TP3
{
    partial class FormSearchMonument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchMonument));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Recherche = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Monuments = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LV_CircuitsPositions = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.Column_Circuit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(46, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cotation:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(171, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "étoiles";
            // 
            // BTN_Recherche
            // 
            this.BTN_Recherche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Recherche.BackgroundImage")));
            this.BTN_Recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Recherche.FlatAppearance.BorderSize = 0;
            this.BTN_Recherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Recherche.Location = new System.Drawing.Point(137, 75);
            this.BTN_Recherche.Name = "BTN_Recherche";
            this.BTN_Recherche.Size = new System.Drawing.Size(84, 74);
            this.BTN_Recherche.TabIndex = 4;
            this.BTN_Recherche.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recherche par...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rechercher";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(40, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 74);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Annuler";
            // 
            // LB_Monuments
            // 
            this.LB_Monuments.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LB_Monuments.FormattingEnabled = true;
            this.LB_Monuments.Location = new System.Drawing.Point(248, 23);
            this.LB_Monuments.Name = "LB_Monuments";
            this.LB_Monuments.Size = new System.Drawing.Size(120, 160);
            this.LB_Monuments.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(245, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monuments";
            // 
            // LV_CircuitsPositions
            // 
            this.LV_CircuitsPositions.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LV_CircuitsPositions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_Circuit,
            this.column_Position});
            this.LV_CircuitsPositions.Location = new System.Drawing.Point(374, 23);
            this.LV_CircuitsPositions.Name = "LV_CircuitsPositions";
            this.LV_CircuitsPositions.Size = new System.Drawing.Size(120, 160);
            this.LV_CircuitsPositions.TabIndex = 11;
            this.LV_CircuitsPositions.UseCompatibleStateImageBehavior = false;
            this.LV_CircuitsPositions.SelectedIndexChanged += new System.EventHandler(this.LV_CircuitsPositions_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(374, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Circuits et Position";
            // 
            // Column_Circuit
            // 
            this.Column_Circuit.Text = "Circuits";
            // 
            // column_Position
            // 
            this.column_Position.Text = "Position";
            // 
            // FormSearchMonument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(514, 190);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LV_CircuitsPositions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LB_Monuments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Recherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearchMonument";
            this.Text = "Recherche Monument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Recherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LB_Monuments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView LV_CircuitsPositions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader Column_Circuit;
        private System.Windows.Forms.ColumnHeader column_Position;
    }
}