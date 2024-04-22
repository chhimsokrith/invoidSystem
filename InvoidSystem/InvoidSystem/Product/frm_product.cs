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

namespace InvoidSystem.Product
{
    public partial class frm_product : Form
    {
        public static frm_product _Product;
        ConnectionDB op = new ConnectionDB();
        public frm_product()
        {
            InitializeComponent();
            _Product = this;
        }
        public void ShowData()
        {
            OleDbConnection con = op.Getcon();
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * from QueryProduct ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGVShow.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DGVShow.RowTemplate.Height = 50;
                
                int n = DGVShow.Rows.Add();
                DGVShow.Font = new System.Drawing.Font("Kh Battambang", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               


                DGVShow.Rows[n].Cells[2].Value = dr["pro_code"].ToString();
                DGVShow.Rows[n].Cells[3].Value = dr["pro_name"].ToString();
                DGVShow.Rows[n].Cells[4].Value = dr["cate_name"].ToString();
                DGVShow.Rows[n].Cells[5].Value = dr["price_in"].ToString();
                DGVShow.Rows[n].Cells[6].Value = dr["price_out"].ToString();
                DGVShow.Rows[n].Cells[7].Value = dr["createAt"].ToString();
                DGVShow.Rows[n].Cells[8].Value = (byte[])dr["img"];

                DGVShow.Sort(DGVShow.Columns[2], ListSortDirection.Descending);
                DGVShow.ClearSelection();
            }
        }

        private void frm_product_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
