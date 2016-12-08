using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.ManagedDataAccess.Client;

namespace TP3
{
    public class donnes 
    {

        public static OracleConnection COnn;
        public static OracleCommand com;
        public static string NomCircuit;
        public static string VilleD;
        public static string VilleA;
        public static string Prix;
        public static string Duree;
        public static bool boss = false;
        public static bool ok = false;
        public static string oldNum;
        public static int row = 0;
       
    }
}
