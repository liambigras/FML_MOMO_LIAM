namespace TP3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleDébutCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleArrivéCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuréeCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMaximaleClientCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoteCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_MonumentImage = new System.Windows.Forms.GroupBox();
            this.PB_MonumentImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_NombredeMonuments = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LB_Monuments = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IMGbouton = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.circuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_ClientRéservéCircuit = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_BestCircuits = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GB_MonumentImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MonumentImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCircuit,
            this.NomCircuit,
            this.VilleDébutCircuit,
            this.VilleArrivéCircuit,
            this.prixCircuit,
            this.DuréeCircuit,
            this.NombreMaximaleClientCircuit,
            this.CoteCircuit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(780, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumeroCircuit
            // 
            this.NumeroCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumeroCircuit.HeaderText = "NumeroCircuit";
            this.NumeroCircuit.Name = "NumeroCircuit";
            this.NumeroCircuit.ReadOnly = true;
            // 
            // NomCircuit
            // 
            this.NomCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomCircuit.HeaderText = "NomCircuit";
            this.NomCircuit.Name = "NomCircuit";
            this.NomCircuit.ReadOnly = true;
            // 
            // VilleDébutCircuit
            // 
            this.VilleDébutCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VilleDébutCircuit.HeaderText = "VilleDébut";
            this.VilleDébutCircuit.Name = "VilleDébutCircuit";
            this.VilleDébutCircuit.ReadOnly = true;
            // 
            // VilleArrivéCircuit
            // 
            this.VilleArrivéCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VilleArrivéCircuit.HeaderText = "VilleArrivé";
            this.VilleArrivéCircuit.Name = "VilleArrivéCircuit";
            this.VilleArrivéCircuit.ReadOnly = true;
            this.VilleArrivéCircuit.Width = 78;
            // 
            // prixCircuit
            // 
            this.prixCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixCircuit.HeaderText = "Prix";
            this.prixCircuit.Name = "prixCircuit";
            this.prixCircuit.ReadOnly = true;
            // 
            // DuréeCircuit
            // 
            this.DuréeCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DuréeCircuit.HeaderText = "Durée";
            this.DuréeCircuit.Name = "DuréeCircuit";
            this.DuréeCircuit.ReadOnly = true;
            // 
            // NombreMaximaleClientCircuit
            // 
            this.NombreMaximaleClientCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreMaximaleClientCircuit.HeaderText = "NbrMaximumClient";
            this.NombreMaximaleClientCircuit.Name = "NombreMaximaleClientCircuit";
            this.NombreMaximaleClientCircuit.ReadOnly = true;
            // 
            // CoteCircuit
            // 
            this.CoteCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CoteCircuit.HeaderText = "Cote";
            this.CoteCircuit.Name = "CoteCircuit";
            this.CoteCircuit.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Liste des Circuits";
            // 
            // GB_MonumentImage
            // 
            this.GB_MonumentImage.Controls.Add(this.PB_MonumentImage);
            this.GB_MonumentImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GB_MonumentImage.Location = new System.Drawing.Point(139, 236);
            this.GB_MonumentImage.Name = "GB_MonumentImage";
            this.GB_MonumentImage.Size = new System.Drawing.Size(155, 134);
            this.GB_MonumentImage.TabIndex = 2;
            this.GB_MonumentImage.TabStop = false;
            this.GB_MonumentImage.Text = "MONUMENT_NAME";
            // 
            // PB_MonumentImage
            // 
            this.PB_MonumentImage.BackColor = System.Drawing.Color.SteelBlue;
            this.PB_MonumentImage.Location = new System.Drawing.Point(5, 16);
            this.PB_MonumentImage.Name = "PB_MonumentImage";
            this.PB_MonumentImage.Size = new System.Drawing.Size(143, 109);
            this.PB_MonumentImage.TabIndex = 9;
            this.PB_MonumentImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre de monuments:";
            // 
            // LBL_NombredeMonuments
            // 
            this.LBL_NombredeMonuments.AutoSize = true;
            this.LBL_NombredeMonuments.Location = new System.Drawing.Point(766, 233);
            this.LBL_NombredeMonuments.Name = "LBL_NombredeMonuments";
            this.LBL_NombredeMonuments.Size = new System.Drawing.Size(24, 13);
            this.LBL_NombredeMonuments.TabIndex = 13;
            this.LBL_NombredeMonuments.Text = "Nbr";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(143, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 35);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LB_Monuments
            // 
            this.LB_Monuments.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LB_Monuments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_Monuments.FormattingEnabled = true;
            this.LB_Monuments.Location = new System.Drawing.Point(12, 249);
            this.LB_Monuments.Name = "LB_Monuments";
            this.LB_Monuments.Size = new System.Drawing.Size(120, 156);
            this.LB_Monuments.TabIndex = 16;
            this.LB_Monuments.SelectedIndexChanged += new System.EventHandler(this.LB_Monuments_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ordre des visites";
            // 
            // IMGbouton
            // 
            this.IMGbouton.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IMGbouton.ImageSize = new System.Drawing.Size(40, 40);
            this.IMGbouton.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuitToolStripMenuItem,
            this.monumentsToolStripMenuItem,
            this.réservationToolStripMenuItem,
            this.rechercherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // circuitToolStripMenuItem
            // 
            this.circuitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.modifyToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.circuitToolStripMenuItem.Name = "circuitToolStripMenuItem";
            this.circuitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.circuitToolStripMenuItem.Text = "Circuit";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem1.Image")));
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.modifyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("modifyToolStripMenuItem1.Image")));
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.modifyToolStripMenuItem1.Text = "Modify";
            this.modifyToolStripMenuItem1.Click += new System.EventHandler(this.modifyToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem1.Image")));
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // monumentsToolStripMenuItem
            // 
            this.monumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1});
            this.monumentsToolStripMenuItem.Name = "monumentsToolStripMenuItem";
            this.monumentsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.monumentsToolStripMenuItem.Text = "Monuments";
            this.monumentsToolStripMenuItem.Click += new System.EventHandler(this.monumentsToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ajouterToolStripMenuItem1.Image = global::TP3.Properties.Resources.add;
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // réservationToolStripMenuItem
            // 
            this.réservationToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.réservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.réservationToolStripMenuItem.Name = "réservationToolStripMenuItem";
            this.réservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.réservationToolStripMenuItem.Text = "Réservation";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ajouterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterToolStripMenuItem.Image")));
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercheToolStripMenuItem});
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rechercheToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rechercheToolStripMenuItem.Image")));
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            this.rechercheToolStripMenuItem.Click += new System.EventHandler(this.rechercheToolStripMenuItem_Click);
            // 
            // LB_ClientRéservéCircuit
            // 
            this.LB_ClientRéservéCircuit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LB_ClientRéservéCircuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_ClientRéservéCircuit.FormattingEnabled = true;
            this.LB_ClientRéservéCircuit.Location = new System.Drawing.Point(511, 249);
            this.LB_ClientRéservéCircuit.Name = "LB_ClientRéservéCircuit";
            this.LB_ClientRéservéCircuit.Size = new System.Drawing.Size(132, 156);
            this.LB_ClientRéservéCircuit.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Réservation du Circuits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Meilleur circuit pour visiter le monument";
            // 
            // TXT_BestCircuits
            // 
            this.TXT_BestCircuits.BackColor = System.Drawing.Color.LightBlue;
            this.TXT_BestCircuits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_BestCircuits.Location = new System.Drawing.Point(303, 252);
            this.TXT_BestCircuits.Name = "TXT_BestCircuits";
            this.TXT_BestCircuits.ReadOnly = true;
            this.TXT_BestCircuits.Size = new System.Drawing.Size(198, 13);
            this.TXT_BestCircuits.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(661, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 95);
            this.button3.TabIndex = 26;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(216, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 35);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(303, 269);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche circuit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Supprimer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Réservation";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(808, 429);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TXT_BestCircuits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_Monuments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GB_MonumentImage);
            this.Controls.Add(this.LB_ClientRéservéCircuit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBL_NombredeMonuments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Formulaire de Gestions";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GB_MonumentImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MonumentImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_MonumentImage;
        private System.Windows.Forms.GroupBox GB_MonumentImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_NombredeMonuments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LB_Monuments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleDébutCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleArrivéCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuréeCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMaximaleClientCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoteCircuit;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList IMGbouton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem circuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem monumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ListBox LB_ClientRéservéCircuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_BestCircuits;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

