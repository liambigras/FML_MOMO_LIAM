using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Oracle.ManagedDataAccess.Client;
namespace TP3
{
    public partial class Form_CreationCircuit : Form
    {
        string userid;
        int rowId;
        //public Form_CreationCircuit(string id, int i);
        OracleConnection con =  new OracleConnection("Data source = " + "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = mercure.clg.qc.ca)"
                           + "(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = orcl.clg.qc.ca)))" + " ; User Id = " + "aboulkhi" + "; password = " + "ORACLE1" + ";");

        OracleCommand CMD;
        public donnes Circuit { get; set; }
        
        
        public Form_CreationCircuit(string id, int i)
        {
            InitializeComponent();

            userid = id;
            rowId = i;
            
        }

        public Form_CreationCircuit()
        {
            InitializeComponent();
            
        }
       
       
        
        private void Form_CreationCircuit_Load(object sender, EventArgs e) /////////////////////////////////////////////////////////////
        {
            
            
            
        }

        private void Creer_Click(object sender, EventArgs e)
        {
            if(!donnes.boss)
            {
                donnes.NomCircuit = TXTBOX_CircuitNom.Text;
                donnes.VilleD = TXTBOX_VDepart.Text;
                donnes.VilleA = TXTBOX_VArriver.Text;
                donnes.Prix = textBox1.Text;
                donnes.Duree = TXTBOX_Duree.Text;
                this.Close();
            }

            
            
        
            else
            {
                MessageBox.Show("Erreur!");
            }

}          }
    }
        
    
