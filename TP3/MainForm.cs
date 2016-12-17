using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;


namespace TP3
{
    public partial class MainForm : Form
    {

        int MonumentCote = 0;
       
        public MainForm()
        {
            
            InitializeComponent();

        }
        

      
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadingFormStart();
        }

       

         private void DisplayUsername()
        {
            LBL_Usager.Text = Data.UsagerID;
            LBL_Usager.Show();
        }
           
        

        private void BTN_ModifierCircuit_Click(object sender, EventArgs e)
        {
            ModifierCircuit ModifyForm = new ModifierCircuit();
            ModifyForm.Show();
          

        }

     

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            
        }
       
            
    

        private void LB_Monuments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        
       

       

        private void BTN_Circuits_Click(object sender, EventArgs e)
        {
            HideAllComponents_between_Btns();
            ShowCircuitsBtnComponents();
        }

        private void TakeOffMainMenu()
        {
            if(PN_Logo.Visible)
            {
                PN_Logo.Hide();
            }
            if(LB_Advertisement.Visible)
            {
                LB_Advertisement.Hide();
            }
        }
        
        //Instancie les composants pour le clique sur circuit
        private void ShowCircuitsBtnComponents()
        {
            DGV_CircuitsListe.Show();
            BTN_Ajouter.Show();
            PN_DeleteCheatLabel.Show();
            BTN_Recherche.Show();
            BTN_Information.Show();
            TakeOffMainMenu();
        }  
        private void ShowMonumentsBtnComponents()
        {
            
            LBL_Circuits.Show();
            LV_Circuits_MonumentsP.Show();
            BTN_AddMonument.Show();
            DGV_Monuments.Show();
            PN_MonumentsComponents.Show();
            TakeOffMainMenu();
        }  

        //loads les Plus Information quand on est sur la page des circuits
        private void ShowMonumentsInformationsComponents()
        {
            PN_Informations.Show();
            PB_MonumentImage.Show();
            PN_Arrows.Show();

            showInformation = true;
        }

        //Hides the information Panel
        private void OnlyHideInformationsPanel()
        {
            PN_Informations.Hide();
            PB_MonumentImage.Hide();
            PN_Arrows.Hide();
            showInformation = false;
        }

        private void LoadingFormStart()
        {
            //loads the username
            DisplayUsername();
            PN_Logo.Show();
            LB_Advertisement.Show();

            HideAllComponents_between_Btns();
        }
        
        private void HideAllComponents_between_Btns()
        {
            
            BTN_Ajouter.Hide();
            BTN_Recherche.Hide();
            BTN_Information.Hide();
            BTN_AddMonument.Hide();
            DGV_CircuitsListe.Hide();
            DGV_Monuments.Hide();
            DGV_Reservs.Hide();
            LBL_Circuits.Hide();
            LV_Circuits_MonumentsP.Hide();
            PN_DeleteCheatLabel.Hide();
            PN_MonumentsComponents.Hide();
            PN_Clients.Hide();
            PN_Reservation.Hide();
            OnlyHideInformationsPanel();

        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_Monuments_Click(object sender, EventArgs e)
        {
            HideAllComponents_between_Btns();
            ClearPBStars();
            MonumentCote = 0;
            ShowMonumentsBtnComponents();
        }

        bool showInformation = false;
        private void BTN_Information_Click(object sender, EventArgs e)
        {
            if (!showInformation)
                ShowMonumentsInformationsComponents();
            else
                OnlyHideInformationsPanel();
        }

        private void BTN_Leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PB_MonumentImage_Click(object sender, EventArgs e)
        {

        }

        private void PB_Star1_Click(object sender, EventArgs e)
        {
            ClearPBStars();
            if (PB_Star1.BackgroundImage != TP3.Properties.Resources._Star01)
            {
                MonumentCote = 1;
                PB_Star1.BackgroundImage = TP3.Properties.Resources._Star01;
            }     
        }

        private void ClearPBStars()
        {
            PB_Star1.BackgroundImage = TP3.Properties.Resources._star;
            PB_Star2.BackgroundImage = TP3.Properties.Resources._star;
            PB_Star3.BackgroundImage = TP3.Properties.Resources._star;
            PB_Star4.BackgroundImage = TP3.Properties.Resources._star;
            PB_Star5.BackgroundImage = TP3.Properties.Resources._star;
        }

        private void PB_Star2_Click(object sender, EventArgs e)
        {
            ClearPBStars();
            if (PB_Star2.BackgroundImage != TP3.Properties.Resources._Star01)
            {
                MonumentCote = 2;
                PB_Star1.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star2.BackgroundImage = TP3.Properties.Resources._Star01;
            }
        }

        private void PB_Star3_Click(object sender, EventArgs e)
        {
            ClearPBStars();
            if (PB_Star3.BackgroundImage != TP3.Properties.Resources._Star01)
            {
                MonumentCote = 3;
                PB_Star1.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star2.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star3.BackgroundImage = TP3.Properties.Resources._Star01;
            }
        }

        private void PB_Star4_Click(object sender, EventArgs e)
        {
            ClearPBStars();
            if (PB_Star4.BackgroundImage != TP3.Properties.Resources._Star01)
            {
                MonumentCote = 4;
                PB_Star1.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star2.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star3.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star4.BackgroundImage = TP3.Properties.Resources._Star01;
            }
        }

        private void PB_Star5_Click(object sender, EventArgs e)
        {
            ClearPBStars();
            if (PB_Star5.BackgroundImage != TP3.Properties.Resources._Star01)
            {
                MonumentCote = 5;
                PB_Star1.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star2.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star3.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star4.BackgroundImage = TP3.Properties.Resources._Star01;
                PB_Star5.BackgroundImage = TP3.Properties.Resources._Star01;
            }
        }

        private void BTN_Clients_Click(object sender, EventArgs e)
        {
            TakeOffMainMenu();
            HideAllComponents_between_Btns();
            PN_Clients.Show();
            DGV_Clients.Show();

        }

        private void BTN_Reservations_Click(object sender, EventArgs e)
        {
            TakeOffMainMenu();
            HideAllComponents_between_Btns();
            DGV_Reservs.Show();
            PN_Reservation.Show();
        }
    }
}
