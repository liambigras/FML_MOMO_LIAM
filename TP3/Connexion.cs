using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TP3
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void BTN_Connexion_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con = new OracleConnection();

            string maBase = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = mercure.clg.qc.ca)"
                           + "(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = orcl.clg.qc.ca)))";
            string userID = textUser.Text;
            string password = textPassword.Text;

           

            con.ConnectionString = "Data source = " + maBase + " ; User Id = " + userID + "; password = " + password + ";";
            con.Open();

            MessageBox.Show(con.State.ToString());
            this.Hide();
            MainForm F = new MainForm();
            F.ShowDialog();
            Close();

           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
