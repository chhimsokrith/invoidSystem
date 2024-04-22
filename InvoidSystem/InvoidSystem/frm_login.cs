using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoidSystem
{
    public partial class frm_login : Form
    {
        public static frm_login FL;
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        public frm_login()
        {
            InitializeComponent();
            FL = this;
        }

        ConnectionDB op = new ConnectionDB();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection con = op.Getcon();
            string query = "Select * From Tbl_User where username = '" + txtUserName.Text + "' and password='" + txtPassword.Text + "'";
            da = new OleDbDataAdapter(query, con);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                frm_main main = new frm_main();
                main.ShowDialog();
            }
        }
    }
}
