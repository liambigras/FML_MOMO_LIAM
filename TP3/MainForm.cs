using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;


namespace TP3
{
    public partial class MainForm : Form
    {
       
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
            LBL_Monuments.Show();
            LB_Monument.Show();
           

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
            DGV_CircuitsListe.Hide();
            BTN_Ajouter.Hide();
            PN_DeleteCheatLabel.Hide();
            BTN_Recherche.Hide();
            LBL_Monuments.Hide();
            LB_Monument.Hide();
            PB_MonumentImage.Hide();
            PN_Arrows.Hide();
            BTN_Information.Hide();
            PN_Informations.Hide();
        }
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_Monuments_Click(object sender, EventArgs e)
        {
            HideAllComponents_between_Btns();
            ShowMonumentsBtnComponents();
        }

        private void BTN_Information_Click(object sender, EventArgs e)
        {
            PN_Informations.Show();
            PB_MonumentImage.Show();
            PN_Arrows.Show();
        }
    }
}
