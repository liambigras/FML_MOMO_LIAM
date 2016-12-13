namespace TP3
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.BTN_Connexion = new System.Windows.Forms.Button();
            this.BTN_Quit = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'usager :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14F);
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mot de passe :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.SkyBlue;
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUser.Font = new System.Drawing.Font("Agency FB", 14F);
            this.textUser.Location = new System.Drawing.Point(142, 39);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(168, 30);
            this.textUser.TabIndex = 1;
            this.textUser.Text = "bigrasli";
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // BTN_Connexion
            // 
            this.BTN_Connexion.BackColor = System.Drawing.Color.LightBlue;
            this.BTN_Connexion.FlatAppearance.BorderSize = 0;
            this.BTN_Connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Connexion.Font = new System.Drawing.Font("Agency FB", 14F);
            this.BTN_Connexion.Location = new System.Drawing.Point(142, 149);
            this.BTN_Connexion.Name = "BTN_Connexion";
            this.BTN_Connexion.Size = new System.Drawing.Size(168, 34);
            this.BTN_Connexion.TabIndex = 2;
            this.BTN_Connexion.Text = "Connexion";
            this.BTN_Connexion.UseVisualStyleBackColor = false;
            this.BTN_Connexion.Click += new System.EventHandler(this.BTN_Connexion_Click);
            // 
            // BTN_Quit
            // 
            this.BTN_Quit.BackColor = System.Drawing.Color.LightBlue;
            this.BTN_Quit.FlatAppearance.BorderSize = 0;
            this.BTN_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Quit.Font = new System.Drawing.Font("Agency FB", 14F);
            this.BTN_Quit.Location = new System.Drawing.Point(142, 201);
            this.BTN_Quit.Name = "BTN_Quit";
            this.BTN_Quit.Size = new System.Drawing.Size(168, 34);
            this.BTN_Quit.TabIndex = 2;
            this.BTN_Quit.Text = "Quitter";
            this.BTN_Quit.UseVisualStyleBackColor = false;
            this.BTN_Quit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.SkyBlue;
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Font = new System.Drawing.Font("Agency FB", 14F);
            this.textPassword.Location = new System.Drawing.Point(142, 88);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(168, 30);
            this.textPassword.TabIndex = 1;
            this.textPassword.Text = "ORACLE1";
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            this.textPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPassword_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Connexion);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTN_Quit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textUser);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 278);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP3.Properties.Resources.login_icon_png_19;
            this.pictureBox1.Location = new System.Drawing.Point(29, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(360, 291);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connexion";
            this.Text = "Système de Tourisme :";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button BTN_Connexion;
        private System.Windows.Forms.Button BTN_Quit;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}