using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InvoidSystem.Product
{
    public partial class frm_addproduct : Form
    {
        OleDbCommand cmd;
        public static frm_addproduct _Addproduct;
        public frm_addproduct()
        {
            InitializeComponent();
            _Addproduct = this;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image File |*.jpg;*.bmp;*gif;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(dlg.FileName);
                    PicProduct.Image = image;
                    pathname.Text = dlg.FileName.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Choose Image", "Error Image File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        ConnectionDB op = new ConnectionDB();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert();
        }
        void ShowComboCategory()
        {
            OleDbConnection con = op.Getcon();
            string sql = "Select * from Tbl_Category";
            con.Open();
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            cbcategory.DisplayMember = "cate_name";
            cbcategory.ValueMember = "id";
            cbcategory.DataSource = dt;
            con.Close();
        }
        void AutoID()
        {
            try
            {
                OleDbConnection con = op.Getcon();
                string Sl = "Select Max (pro_code) from Tbl_Product";
                cmd = new OleDbCommand(Sl, con);
                con.Open();
                var maxid = cmd.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txtcodepro.Text = "P-000001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 6));
                    intval++;
                    txtcodepro.Text = string.Format("P-{0:000000}", intval);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_addproduct_Load(object sender, EventArgs e)
        {
            AutoID();
            ShowComboCategory();
        }
        void insert()
        {
            OleDbConnection con = op.Getcon();
            MemoryStream ms = new MemoryStream();
            PicProduct.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] photo = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo, 0, photo.Length);

            string sql = "insert into Tbl_Product (pro_code,pro_name,categoryId,price_in,price_out,img,status,createAt) Values (?,?,?,?,?,@photo,?,?)";

            OleDbCommand cmd = new OleDbCommand(sql, con);

            cmd.Parameters.AddWithValue("pro_code", OleDbType.VarChar).Value = txtcodepro.Text;
            cmd.Parameters.AddWithValue("pro_name", OleDbType.VarChar).Value = txtproname.Text;
            cmd.Parameters.AddWithValue("categoryId", OleDbType.Integer).Value = cbcategory.SelectedValue;
            cmd.Parameters.AddWithValue("price_in", OleDbType.Double).Value = txtpricein.Text;
            cmd.Parameters.AddWithValue("price_out", OleDbType.Double).Value = txtpriceout.Text;
            cmd.Parameters.AddWithValue("@photo", photo);
            cmd.Parameters.AddWithValue("status", OleDbType.Integer).Value = "0";
            cmd.Parameters.AddWithValue("createAt", OleDbType.Date).Value = DateTime.Now.ToString("f");
            con.Open();
            int insertDataToAccessDatabase = cmd.ExecuteNonQuery();
            con.Close();
            //If data Has been inserted to the database output the following message
            if (insertDataToAccessDatabase > 0)
            {
                MessageBox.Show("Susccessfully.........");
            }
            AutoID();
        }
    }
}
