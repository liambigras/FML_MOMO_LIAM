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
            this.DGV_CircuitsListe = new System.Windows.Forms.DataGridView();
            this.PB_MonumentImage = new System.Windows.Forms.PictureBox();
            this.LBL_NombredeMonuments = new System.Windows.Forms.Label();
            this.BTN_Precedent = new System.Windows.Forms.Button();
            this.LB_Monuments = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IMGbouton = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LBL_Monuments = new System.Windows.Forms.Label();
            this.LB_Monument = new System.Windows.Forms.ListBox();
            this.BTN_Prochain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_ClientRéservéCircuit = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_Circuits = new System.Windows.Forms.Button();
            this.BTN_Monuments = new System.Windows.Forms.Button();
            this.BTN_Clients = new System.Windows.Forms.Button();
            this.BTN_Reservations = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_Usager = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BTN_Connectivity = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.PN_DeleteCheatLabel = new System.Windows.Forms.Panel();
            this.BTN_Recherche = new System.Windows.Forms.Button();
            this.LB_Advertisement = new System.Windows.Forms.Label();
            this.PB_Boat = new System.Windows.Forms.PictureBox();
            this.PB_Mountains = new System.Windows.Forms.PictureBox();
            this.PB_Sign = new System.Windows.Forms.PictureBox();
            this.PB_Map = new System.Windows.Forms.PictureBox();
            this.PN_Logo = new System.Windows.Forms.Panel();
            this.PN_Arrows = new System.Windows.Forms.Panel();
            this.BTN_Information = new System.Windows.Forms.Button();
            this.PN_Informations = new System.Windows.Forms.Panel();
            this.LBL_indexSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CircuitsListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MonumentImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PN_DeleteCheatLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Boat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Mountains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Map)).BeginInit();
            this.PN_Logo.SuspendLayout();
            this.PN_Arrows.SuspendLayout();
            this.PN_Informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_CircuitsListe
            // 
            this.DGV_CircuitsListe.AllowUserToAddRows = false;
            this.DGV_CircuitsListe.AllowUserToDeleteRows = false;
            this.DGV_CircuitsListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CircuitsListe.BackgroundColor = System.Drawing.Color.LightBlue;
            this.DGV_CircuitsListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_CircuitsListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_CircuitsListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CircuitsListe.Location = new System.Drawing.Point(217, 60);
            this.DGV_CircuitsListe.Name = "DGV_CircuitsListe";
            this.DGV_CircuitsListe.ReadOnly = true;
            this.DGV_CircuitsListe.Size = new System.Drawing.Size(780, 242);
            this.DGV_CircuitsListe.TabIndex = 0;
            this.DGV_CircuitsListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PB_MonumentImage
            // 
            this.PB_MonumentImage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PB_MonumentImage.Location = new System.Drawing.Point(225, 32);
            this.PB_MonumentImage.Name = "PB_MonumentImage";
            this.PB_MonumentImage.Size = new System.Drawing.Size(166, 127);
            this.PB_MonumentImage.TabIndex = 9;
            this.PB_MonumentImage.TabStop = false;
            // 
            // LBL_NombredeMonuments
            // 
            this.LBL_NombredeMonuments.AutoSize = true;
            this.LBL_NombredeMonuments.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NombredeMonuments.Location = new System.Drawing.Point(228, 225);
            this.LBL_NombredeMonuments.Name = "LBL_NombredeMonuments";
            this.LBL_NombredeMonuments.Size = new System.Drawing.Size(25, 20);
            this.LBL_NombredeMonuments.TabIndex = 13;
            this.LBL_NombredeMonuments.Text = "Nbr";
            // 
            // BTN_Precedent
            // 
            this.BTN_Precedent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_Precedent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Precedent.BackgroundImage")));
            this.BTN_Precedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Precedent.FlatAppearance.BorderSize = 0;
            this.BTN_Precedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Precedent.Location = new System.Drawing.Point(0, 3);
            this.BTN_Precedent.Name = "BTN_Precedent";
            this.BTN_Precedent.Size = new System.Drawing.Size(83, 35);
            this.BTN_Precedent.TabIndex = 14;
            this.BTN_Precedent.UseVisualStyleBackColor = false;
            // 
            // LB_Monuments
            // 
            this.LB_Monuments.BackColor = System.Drawing.Color.SkyBlue;
            this.LB_Monuments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_Monuments.FormattingEnabled = true;
            this.LB_Monuments.Location = new System.Drawing.Point(11, 49);
            this.LB_Monuments.Name = "LB_Monuments";
            this.LB_Monuments.Size = new System.Drawing.Size(173, 195);
            this.LB_Monuments.TabIndex = 16;
            this.LB_Monuments.SelectedIndexChanged += new System.EventHandler(this.LB_Monuments_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ordre des visites";
            // 
            // IMGbouton
            // 
            this.IMGbouton.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IMGbouton.ImageSize = new System.Drawing.Size(40, 40);
            this.IMGbouton.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LBL_Monuments
            // 
            this.LBL_Monuments.AutoSize = true;
            this.LBL_Monuments.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Monuments.Location = new System.Drawing.Point(225, 63);
            this.LBL_Monuments.Name = "LBL_Monuments";
            this.LBL_Monuments.Size = new System.Drawing.Size(110, 34);
            this.LBL_Monuments.TabIndex = 1;
            this.LBL_Monuments.Text = "Monuments";
            // 
            // LB_Monument
            // 
            this.LB_Monument.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Monument.FormattingEnabled = true;
            this.LB_Monument.ItemHeight = 14;
            this.LB_Monument.Location = new System.Drawing.Point(231, 100);
            this.LB_Monument.Name = "LB_Monument";
            this.LB_Monument.Size = new System.Drawing.Size(177, 228);
            this.LB_Monument.TabIndex = 0;
            // 
            // BTN_Prochain
            // 
            this.BTN_Prochain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_Prochain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Prochain.BackgroundImage")));
            this.BTN_Prochain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Prochain.FlatAppearance.BorderSize = 0;
            this.BTN_Prochain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Prochain.Location = new System.Drawing.Point(83, 3);
            this.BTN_Prochain.Name = "BTN_Prochain";
            this.BTN_Prochain.Size = new System.Drawing.Size(80, 35);
            this.BTN_Prochain.TabIndex = 27;
            this.BTN_Prochain.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Meilleur circuit contenant ce monument :";
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
            // LB_ClientRéservéCircuit
            // 
            this.LB_ClientRéservéCircuit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LB_ClientRéservéCircuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_ClientRéservéCircuit.FormattingEnabled = true;
            this.LB_ClientRéservéCircuit.Location = new System.Drawing.Point(788, 533);
            this.LB_ClientRéservéCircuit.Name = "LB_ClientRéservéCircuit";
            this.LB_ClientRéservéCircuit.Size = new System.Drawing.Size(132, 156);
            this.LB_ClientRéservéCircuit.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Réservation du Circuits";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(938, 569);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 95);
            this.button3.TabIndex = 26;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(961, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Supprimer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(954, 667);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Réservation";
            // 
            // BTN_Circuits
            // 
            this.BTN_Circuits.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_Circuits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Circuits.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Circuits.FlatAppearance.BorderSize = 0;
            this.BTN_Circuits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Circuits.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Circuits.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BTN_Circuits.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Circuits.Image")));
            this.BTN_Circuits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Circuits.Location = new System.Drawing.Point(0, 0);
            this.BTN_Circuits.Name = "BTN_Circuits";
            this.BTN_Circuits.Size = new System.Drawing.Size(217, 69);
            this.BTN_Circuits.TabIndex = 33;
            this.BTN_Circuits.Text = " Circuits";
            this.BTN_Circuits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Circuits.UseVisualStyleBackColor = false;
            this.BTN_Circuits.Click += new System.EventHandler(this.BTN_Circuits_Click);
            // 
            // BTN_Monuments
            // 
            this.BTN_Monuments.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_Monuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Monuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Monuments.FlatAppearance.BorderSize = 0;
            this.BTN_Monuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Monuments.Font = new System.Drawing.Font("Agency FB", 18F);
            this.BTN_Monuments.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BTN_Monuments.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Monuments.Image")));
            this.BTN_Monuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Monuments.Location = new System.Drawing.Point(0, 207);
            this.BTN_Monuments.Name = "BTN_Monuments";
            this.BTN_Monuments.Size = new System.Drawing.Size(217, 69);
            this.BTN_Monuments.TabIndex = 34;
            this.BTN_Monuments.Text = " Monuments";
            this.BTN_Monuments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Monuments.UseVisualStyleBackColor = false;
            this.BTN_Monuments.Click += new System.EventHandler(this.BTN_Monuments_Click);
            // 
            // BTN_Clients
            // 
            this.BTN_Clients.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Clients.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Clients.FlatAppearance.BorderSize = 0;
            this.BTN_Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clients.Font = new System.Drawing.Font("Agency FB", 18F);
            this.BTN_Clients.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BTN_Clients.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Clients.Image")));
            this.BTN_Clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Clients.Location = new System.Drawing.Point(0, 69);
            this.BTN_Clients.Name = "BTN_Clients";
            this.BTN_Clients.Size = new System.Drawing.Size(217, 69);
            this.BTN_Clients.TabIndex = 35;
            this.BTN_Clients.Text = " Clients";
            this.BTN_Clients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Clients.UseVisualStyleBackColor = false;
            // 
            // BTN_Reservations
            // 
            this.BTN_Reservations.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_Reservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Reservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Reservations.FlatAppearance.BorderSize = 0;
            this.BTN_Reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reservations.Font = new System.Drawing.Font("Agency FB", 18F);
            this.BTN_Reservations.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BTN_Reservations.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Reservations.Image")));
            this.BTN_Reservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Reservations.Location = new System.Drawing.Point(0, 138);
            this.BTN_Reservations.Name = "BTN_Reservations";
            this.BTN_Reservations.Size = new System.Drawing.Size(217, 69);
            this.BTN_Reservations.TabIndex = 36;
            this.BTN_Reservations.Text = "  Reservations";
            this.BTN_Reservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Reservations.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSlateGray;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Agency FB", 18F);
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 688);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(217, 69);
            this.button8.TabIndex = 37;
            this.button8.Text = " Quitter";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.BTN_Monuments);
            this.panel1.Controls.Add(this.BTN_Reservations);
            this.panel1.Controls.Add(this.BTN_Clients);
            this.panel1.Controls.Add(this.BTN_Circuits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 759);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.LBL_Usager);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.BTN_Connectivity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 60);
            this.panel2.TabIndex = 39;
            // 
            // LBL_Usager
            // 
            this.LBL_Usager.AutoSize = true;
            this.LBL_Usager.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Usager.Location = new System.Drawing.Point(849, 15);
            this.LBL_Usager.Name = "LBL_Usager";
            this.LBL_Usager.Size = new System.Drawing.Size(77, 24);
            this.LBL_Usager.TabIndex = 36;
            this.LBL_Usager.Text = "LBL_Usager";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(784, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Usager :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 36);
            this.label11.TabIndex = 34;
            this.label11.Text = "Bienvenue!";
            // 
            // BTN_Connectivity
            // 
            this.BTN_Connectivity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Connectivity.BackgroundImage")));
            this.BTN_Connectivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Connectivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Connectivity.FlatAppearance.BorderSize = 0;
            this.BTN_Connectivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Connectivity.Location = new System.Drawing.Point(162, 0);
            this.BTN_Connectivity.Name = "BTN_Connectivity";
            this.BTN_Connectivity.Size = new System.Drawing.Size(70, 60);
            this.BTN_Connectivity.TabIndex = 33;
            this.BTN_Connectivity.UseVisualStyleBackColor = true;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_Ajouter.BackColor = System.Drawing.Color.SlateGray;
            this.BTN_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ajouter.FlatAppearance.BorderSize = 0;
            this.BTN_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ajouter.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Ajouter.Image")));
            this.BTN_Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Ajouter.Location = new System.Drawing.Point(330, 301);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(188, 48);
            this.BTN_Ajouter.TabIndex = 40;
            this.BTN_Ajouter.Text = "    Ajouter";
            this.BTN_Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Ajouter.UseVisualStyleBackColor = false;
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_Supprimer.BackColor = System.Drawing.Color.SlateGray;
            this.BTN_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Supprimer.FlatAppearance.BorderSize = 0;
            this.BTN_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Supprimer.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Supprimer.Image")));
            this.BTN_Supprimer.Location = new System.Drawing.Point(0, -3);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(195, 48);
            this.BTN_Supprimer.TabIndex = 41;
            this.BTN_Supprimer.Text = "   Supprimer";
            this.BTN_Supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Supprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Supprimer.UseVisualStyleBackColor = false;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // PN_DeleteCheatLabel
            // 
            this.PN_DeleteCheatLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PN_DeleteCheatLabel.BackColor = System.Drawing.Color.SlateGray;
            this.PN_DeleteCheatLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PN_DeleteCheatLabel.Controls.Add(this.BTN_Supprimer);
            this.PN_DeleteCheatLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PN_DeleteCheatLabel.Location = new System.Drawing.Point(526, 301);
            this.PN_DeleteCheatLabel.Name = "PN_DeleteCheatLabel";
            this.PN_DeleteCheatLabel.Size = new System.Drawing.Size(195, 48);
            this.PN_DeleteCheatLabel.TabIndex = 43;
            // 
            // BTN_Recherche
            // 
            this.BTN_Recherche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_Recherche.BackColor = System.Drawing.Color.SlateGray;
            this.BTN_Recherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Recherche.FlatAppearance.BorderSize = 0;
            this.BTN_Recherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Recherche.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Recherche.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Recherche.Image")));
            this.BTN_Recherche.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Recherche.Location = new System.Drawing.Point(797, 303);
            this.BTN_Recherche.Name = "BTN_Recherche";
            this.BTN_Recherche.Size = new System.Drawing.Size(188, 46);
            this.BTN_Recherche.TabIndex = 44;
            this.BTN_Recherche.Text = "    Recherche";
            this.BTN_Recherche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Recherche.UseVisualStyleBackColor = false;
            // 
            // LB_Advertisement
            // 
            this.LB_Advertisement.AutoSize = true;
            this.LB_Advertisement.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Advertisement.Location = new System.Drawing.Point(252, 108);
            this.LB_Advertisement.Name = "LB_Advertisement";
            this.LB_Advertisement.Size = new System.Drawing.Size(453, 116);
            this.LB_Advertisement.TabIndex = 45;
            this.LB_Advertisement.Text = "Le programme de Tourisme\r\n le plus utilisé au monde!";
            // 
            // PB_Boat
            // 
            this.PB_Boat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Boat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Boat.BackgroundImage")));
            this.PB_Boat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Boat.Location = new System.Drawing.Point(63, 58);
            this.PB_Boat.Name = "PB_Boat";
            this.PB_Boat.Size = new System.Drawing.Size(63, 57);
            this.PB_Boat.TabIndex = 46;
            this.PB_Boat.TabStop = false;
            // 
            // PB_Mountains
            // 
            this.PB_Mountains.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Mountains.BackgroundImage")));
            this.PB_Mountains.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Mountains.Location = new System.Drawing.Point(0, 0);
            this.PB_Mountains.Name = "PB_Mountains";
            this.PB_Mountains.Size = new System.Drawing.Size(63, 59);
            this.PB_Mountains.TabIndex = 47;
            this.PB_Mountains.TabStop = false;
            // 
            // PB_Sign
            // 
            this.PB_Sign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Sign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Sign.BackgroundImage")));
            this.PB_Sign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Sign.Location = new System.Drawing.Point(63, 0);
            this.PB_Sign.Name = "PB_Sign";
            this.PB_Sign.Size = new System.Drawing.Size(63, 59);
            this.PB_Sign.TabIndex = 49;
            this.PB_Sign.TabStop = false;
            // 
            // PB_Map
            // 
            this.PB_Map.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PB_Map.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Map.BackgroundImage")));
            this.PB_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Map.Location = new System.Drawing.Point(0, 58);
            this.PB_Map.Name = "PB_Map";
            this.PB_Map.Size = new System.Drawing.Size(63, 57);
            this.PB_Map.TabIndex = 48;
            this.PB_Map.TabStop = false;
            // 
            // PN_Logo
            // 
            this.PN_Logo.Controls.Add(this.PB_Sign);
            this.PN_Logo.Controls.Add(this.PB_Mountains);
            this.PN_Logo.Controls.Add(this.PB_Boat);
            this.PN_Logo.Controls.Add(this.PB_Map);
            this.PN_Logo.Location = new System.Drawing.Point(766, 108);
            this.PN_Logo.Name = "PN_Logo";
            this.PN_Logo.Size = new System.Drawing.Size(126, 116);
            this.PN_Logo.TabIndex = 50;
            // 
            // PN_Arrows
            // 
            this.PN_Arrows.Controls.Add(this.BTN_Prochain);
            this.PN_Arrows.Controls.Add(this.BTN_Precedent);
            this.PN_Arrows.Location = new System.Drawing.Point(225, 162);
            this.PN_Arrows.Name = "PN_Arrows";
            this.PN_Arrows.Size = new System.Drawing.Size(166, 41);
            this.PN_Arrows.TabIndex = 51;
            // 
            // BTN_Information
            // 
            this.BTN_Information.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_Information.BackColor = System.Drawing.Color.SlateGray;
            this.BTN_Information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Information.FlatAppearance.BorderSize = 0;
            this.BTN_Information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Information.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Information.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Information.Image")));
            this.BTN_Information.Location = new System.Drawing.Point(421, 360);
            this.BTN_Information.Name = "BTN_Information";
            this.BTN_Information.Size = new System.Drawing.Size(195, 48);
            this.BTN_Information.TabIndex = 52;
            this.BTN_Information.Text = "   Informations";
            this.BTN_Information.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Information.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Information.UseVisualStyleBackColor = false;
            this.BTN_Information.Click += new System.EventHandler(this.BTN_Information_Click);
            // 
            // PN_Informations
            // 
            this.PN_Informations.Controls.Add(this.PB_MonumentImage);
            this.PN_Informations.Controls.Add(this.LBL_indexSelected);
            this.PN_Informations.Controls.Add(this.label1);
            this.PN_Informations.Controls.Add(this.label3);
            this.PN_Informations.Controls.Add(this.PN_Arrows);
            this.PN_Informations.Controls.Add(this.LB_Monuments);
            this.PN_Informations.Controls.Add(this.LBL_NombredeMonuments);
            this.PN_Informations.Location = new System.Drawing.Point(262, 437);
            this.PN_Informations.Name = "PN_Informations";
            this.PN_Informations.Size = new System.Drawing.Size(499, 281);
            this.PN_Informations.TabIndex = 53;
            // 
            // LBL_indexSelected
            // 
            this.LBL_indexSelected.AutoSize = true;
            this.LBL_indexSelected.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_indexSelected.Location = new System.Drawing.Point(193, 224);
            this.LBL_indexSelected.Name = "LBL_indexSelected";
            this.LBL_indexSelected.Size = new System.Drawing.Size(15, 20);
            this.LBL_indexSelected.TabIndex = 19;
            this.LBL_indexSelected.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "/";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(997, 819);
            this.Controls.Add(this.PN_Informations);
            this.Controls.Add(this.BTN_Information);
            this.Controls.Add(this.PN_Logo);
            this.Controls.Add(this.LB_Advertisement);
            this.Controls.Add(this.BTN_Recherche);
            this.Controls.Add(this.PN_DeleteCheatLabel);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LBL_Monuments);
            this.Controls.Add(this.DGV_CircuitsListe);
            this.Controls.Add(this.LB_Monument);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_ClientRéservéCircuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Formulaire de Gestions";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CircuitsListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MonumentImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PN_DeleteCheatLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Boat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Mountains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Map)).EndInit();
            this.PN_Logo.ResumeLayout(false);
            this.PN_Arrows.ResumeLayout(false);
            this.PN_Informations.ResumeLayout(false);
            this.PN_Informations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PB_MonumentImage;
        private System.Windows.Forms.Label LBL_NombredeMonuments;
        private System.Windows.Forms.Button BTN_Precedent;
        private System.Windows.Forms.ListBox LB_Monuments;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView DGV_CircuitsListe;
        private System.Windows.Forms.ImageList IMGbouton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ListBox LB_ClientRéservéCircuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_Prochain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBL_Monuments;
        private System.Windows.Forms.ListBox LB_Monument;
        private System.Windows.Forms.Button BTN_Circuits;
        private System.Windows.Forms.Button BTN_Monuments;
        private System.Windows.Forms.Button BTN_Clients;
        private System.Windows.Forms.Button BTN_Reservations;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTN_Connectivity;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Panel PN_DeleteCheatLabel;
        private System.Windows.Forms.Button BTN_Recherche;
        private System.Windows.Forms.Label LB_Advertisement;
        private System.Windows.Forms.PictureBox PB_Boat;
        private System.Windows.Forms.PictureBox PB_Mountains;
        private System.Windows.Forms.PictureBox PB_Sign;
        private System.Windows.Forms.PictureBox PB_Map;
        private System.Windows.Forms.Panel PN_Logo;
        private System.Windows.Forms.Label LBL_Usager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PN_Arrows;
        private System.Windows.Forms.Button BTN_Information;
        private System.Windows.Forms.Panel PN_Informations;
        private System.Windows.Forms.Label LBL_indexSelected;
        private System.Windows.Forms.Label label1;
    }
}

