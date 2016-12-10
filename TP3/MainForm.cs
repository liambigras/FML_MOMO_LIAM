using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace TP3
{
    public partial class MainForm : Form
    {
        OracleCommandBuilder bui;
        OracleConnection con;
            OracleCommand cmAjout_;
            OracleDataAdapter D = new OracleDataAdapter(); //lie entre le data set et les donnée ervir d'un objet DataAdapter pour remplir de données un DataSet puis répercuter les modifications réalisées sur une source de données. Il est possible de définir les actions à réaliser par le DataAdapter en utilisant l'une des quatre propriétés suivantes. Chaque propriété exécutera soit un ordre SQL soit une procédure stockée.
            DataSet DA = new DataSet();
            public donnes Circuit { get; set; }
         private int selected_Circuit = -1;
        public Form_CreationCircuit C;
        string str;
        int i;
        public MainForm()
        {
            
            InitializeComponent();
           
            
        }
        

        private void FirstLoad()
        {
            string slctLoad = "select * from CIRCUIT";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstLoad();
        }

       

          
           
        

        private void BTN_ModifierCircuit_Click(object sender, EventArgs e)
        {
            ModifierCircuit ModifyForm = new ModifierCircuit();
            ModifyForm.Show();
          

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

       
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            
        }
        private void BTN_AjouterCircuit_Click(object sender, EventArgs e)
        {
           
            
            
        }

            
        private void BTN_SupprimerCircuit_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                OracleCommand del = new OracleCommand("Delete from Disques where Nodisque=" + row.Cells[0].Value, con);
                dataGridView1.Rows.RemoveAt(row.Index);
                del.ExecuteNonQuery();
            }*/
        }

        private void LB_Monuments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            Form_CreationCircuit op = new Form_CreationCircuit();
            op.ShowDialog();
            try
            {
                string sql = "insert into disques values('" + donnes.VilleD + ",'" +
  donnes.VilleA + "'," + donnes.Prix + "," + donnes.NomCircuit + "," + donnes.Duree + ")";
                OracleCommand add = new OracleCommand(sql, donnes.COnn);
                add.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifierCircuit F = new ModifierCircuit();
            F.ShowDialog();
        }

        private void monumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchMonument R = new FormSearchMonument();
            R.ShowDialog();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationClient R = new ReservationClient();
            R.ShowDialog();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Monument M = new Monument();
            M.ShowDialog();
        }
    }
}
