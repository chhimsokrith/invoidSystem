using InvoidSystem.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoidSystem
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void T_MB_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            lblMB.Text = T_MB.SelectedNode.Name;
        
            if(lblMB.Text == "Product_List")
            {
                    P_MB.Controls.Clear();
                    frm_product _Product = new frm_product();
                    _Product.StartPosition = FormStartPosition.CenterScreen;
                    _Product.TopLevel = false;
                    P_MB.Controls.Clear();
                    P_MB.Controls.Add(_Product);
                    _Product.BringToFront();
                    _Product.Show();
                }
            if(lblMB.Text == "Product_Input")
            {
                P_MB.Controls.Clear();
                frm_addproduct _Addproduct = new frm_addproduct();
                _Addproduct.ShowDialog();
            }
            

        }
    }
}
