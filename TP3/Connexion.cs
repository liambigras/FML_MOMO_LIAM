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
            //string maBase = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = mercure.clg.qc.ca)"
                        //  + "(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = orcl.clg.qc.ca)))";
            Data.UsagerID = textUser.Text;
            string password = textPassword.Text;
            try
            {
                Data.DBconnection.ConnectionString = "Data source = " + Data.maBase + " ; User Id = " + Data.UsagerID + "; password = " + password + ";";
                Data.DBconnection.Open();
                MessageBox.Show(Data.DBconnection.State.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            this.Hide();
            MainForm F = new MainForm();
            F.ShowDialog();
            Close();

        }
        private void OpeningClosingForms()
        {
            if(Data.DBconnection.State == ConnectionState.Open)
            {
                MainForm _istheGODform = new MainForm();
                this.Hide();
                _istheGODform.Show();
            }
            else
            {
                textPassword.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Validate_with_Enter(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BTN_Connexion.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Validate_with_Enter(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
