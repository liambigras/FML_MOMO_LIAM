using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace TP3
{
    public static class Data
    {
        public static OracleConnection DBconnection = new OracleConnection();
        public const string maBase = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = mercure.clg.qc.ca)"
                          + "(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = orcl.clg.qc.ca)))";
        public static string UsagerID { get; set; }
    }
}
