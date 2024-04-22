using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoidSystem
{
    internal class ConnectionDB
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public OleDbConnection Getcon()
        {
            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CHHIMSOKRITH\Desktop\InvoidSystem\InvoidDB.accdb; Persist Security Info = True; Jet OLEDB:Database Password = 123"
                //  ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\IMS_POS\IMSPOS.accdb; Persist Security Info = True; Jet OLEDB:Database Password = 1"
                // ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\IMSPOS.accdb; Persist Security Info = True; Jet OLEDB:Database Password = 1"

            };

            return con;
        }
    }
}
