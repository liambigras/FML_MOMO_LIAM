namespace TP3
{
    partial class EspaceClient
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
            this.LB_Clients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBOX_Circuits = new System.Windows.Forms.ComboBox();
            this.GB_Supprimer = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GB_Creation = new System.Windows.Forms.GroupBox();
            this.BTN_AjouterClientCircuit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.GB_Supprimer.SuspendLayout();
            this.GB_Creation.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Clients
            // 
            this.LB_Clients.FormattingEnabled = true;
            this.LB_Clients.Location = new System.Drawing.Point(177, 23);
            this.LB_Clients.Name = "LB_Clients";
            this.LB_Clients.Size = new System.Drawing.Size(120, 134);
            this.LB_Clients.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sélectionner un Circuit";
            // 
            // CMBOX_Circuits
            // 
            this.CMBOX_Circuits.FormattingEnabled = true;
            this.CMBOX_Circuits.Location = new System.Drawing.Point(25, 25);
            this.CMBOX_Circuits.Name = "CMBOX_Circuits";
            this.CMBOX_Circuits.Size = new System.Drawing.Size(121, 21);
            this.CMBOX_Circuits.TabIndex = 3;
            // 
            // GB_Supprimer
            // 
            this.GB_Supprimer.Controls.Add(this.button2);
            this.GB_Supprimer.Controls.Add(this.button1);
            this.GB_Supprimer.Location = new System.Drawing.Point(303, 25);
            this.GB_Supprimer.Name = "GB_Supprimer";
            this.GB_Supprimer.Size = new System.Drawing.Size(159, 100);
            this.GB_Supprimer.TabIndex = 4;
            this.GB_Supprimer.TabStop = false;
            this.GB_Supprimer.Text = "Supprimer...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Client du Circuit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reservation Client";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GB_Creation
            // 
            this.GB_Creation.Controls.Add(this.button3);
            this.GB_Creation.Controls.Add(this.BTN_AjouterClientCircuit);
            this.GB_Creation.Location = new System.Drawing.Point(25, 66);
            this.GB_Creation.Name = "GB_Creation";
            this.GB_Creation.Size = new System.Drawing.Size(133, 91);
            this.GB_Creation.TabIndex = 5;
            this.GB_Creation.TabStop = false;
            this.GB_Creation.Text = "Ajouter...";
            // 
            // BTN_AjouterClientCircuit
            // 
            this.BTN_AjouterClientCircuit.Location = new System.Drawing.Point(6, 19);
            this.BTN_AjouterClientCircuit.Name = "BTN_AjouterClientCircuit";
            this.BTN_AjouterClientCircuit.Size = new System.Drawing.Size(107, 23);
            this.BTN_AjouterClientCircuit.TabIndex = 6;
            this.BTN_AjouterClientCircuit.Text = "Client à un circuit";
            this.BTN_AjouterClientCircuit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reservation de visite guidée";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Location = new System.Drawing.Point(387, 134);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(75, 23);
            this.BTN_Valider.TabIndex = 6;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = true;
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(304, 134);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Quitter.TabIndex = 7;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // EspaceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 177);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.GB_Creation);
            this.Controls.Add(this.GB_Supprimer);
            this.Controls.Add(this.CMBOX_Circuits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Clients);
            this.Name = "EspaceClient";
            this.Text = "Espace Client : Portail";
            this.GB_Supprimer.ResumeLayout(false);
            this.GB_Creation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBOX_Circuits;
        private System.Windows.Forms.GroupBox GB_Supprimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GB_Creation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_AjouterClientCircuit;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Quitter;
    }
}