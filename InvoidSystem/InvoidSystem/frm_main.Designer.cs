namespace InvoidSystem
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.P_Top = new System.Windows.Forms.Panel();
            this.lblMB = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.T_MB = new DevComponents.AdvTree.AdvTree();
            this.M_Product = new DevComponents.AdvTree.Node();
            this.P_Product = new DevComponents.AdvTree.Node();
            this.Product_Input = new DevComponents.AdvTree.Node();
            this.Product_List = new DevComponents.AdvTree.Node();
            this.P_Category = new DevComponents.AdvTree.Node();
            this.Cate_Input = new DevComponents.AdvTree.Node();
            this.Cate_List = new DevComponents.AdvTree.Node();
            this.P_Brand = new DevComponents.AdvTree.Node();
            this.Brand_Input = new DevComponents.AdvTree.Node();
            this.Brand_List = new DevComponents.AdvTree.Node();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.M_Sale = new DevComponents.AdvTree.Node();
            this.P_Sale = new DevComponents.AdvTree.Node();
            this.P_HisSale = new DevComponents.AdvTree.Node();
            this.P_NoteCustomer = new DevComponents.AdvTree.Node();
            this.P_Stock = new DevComponents.AdvTree.Node();
            this.M_Customer = new DevComponents.AdvTree.Node();
            this.T_CustomerInput = new DevComponents.AdvTree.Node();
            this.C_CustomerList = new DevComponents.AdvTree.Node();
            this.M_PricePromotion = new DevComponents.AdvTree.Node();
            this.Barcode = new DevComponents.AdvTree.Node();
            this.Price_Promotion = new DevComponents.AdvTree.Node();
            this.M_UserControl = new DevComponents.AdvTree.Node();
            this.U_UserList = new DevComponents.AdvTree.Node();
            this.U_ChangePW = new DevComponents.AdvTree.Node();
            this.M_Tools = new DevComponents.AdvTree.Node();
            this.T_Money = new DevComponents.AdvTree.Node();
            this.T_Post = new DevComponents.AdvTree.Node();
            this.T_Printer = new DevComponents.AdvTree.Node();
            this.M_SwithUser = new DevComponents.AdvTree.Node();
            this.M_BackupFile = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle3 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle4 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.P_MB = new DevComponents.DotNetBar.PanelEx();
            this.P_Top.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_MB)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Top
            // 
            this.P_Top.BackColor = System.Drawing.Color.Navy;
            this.P_Top.Controls.Add(this.lblMB);
            this.P_Top.Controls.Add(this.lblTimer);
            this.P_Top.Controls.Add(this.panel3);
            this.P_Top.Controls.Add(this.pictureBox1);
            this.P_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Top.Location = new System.Drawing.Point(0, 0);
            this.P_Top.Margin = new System.Windows.Forms.Padding(4);
            this.P_Top.Name = "P_Top";
            this.P_Top.Size = new System.Drawing.Size(1716, 65);
            this.P_Top.TabIndex = 22;
            // 
            // lblMB
            // 
            this.lblMB.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMB.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMB.Location = new System.Drawing.Point(349, 10);
            this.lblMB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(129, 44);
            this.lblMB.TabIndex = 28;
            this.lblMB.Text = "Admin";
            this.lblMB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimer.Location = new System.Drawing.Point(90, 10);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(239, 43);
            this.lblTimer.TabIndex = 28;
            this.lblTimer.Text = "00:00:00 00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(1415, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 52);
            this.panel3.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(121, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 52);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(175, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 52);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(233, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 52);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::InvoidSystem.Properties.Resources._7572360;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // T_MB
            // 
            this.T_MB.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.T_MB.BackColor = System.Drawing.Color.OldLace;
            // 
            // 
            // 
            this.T_MB.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.T_MB.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.T_MB.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.T_MB.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.T_MB.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.T_MB.BackgroundStyle.Class = "TreeBorderKey";
            this.T_MB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.T_MB.ColorSchemeStyle = DevComponents.AdvTree.eColorSchemeStyle.VS2005;
            this.T_MB.Dock = System.Windows.Forms.DockStyle.Left;
            this.T_MB.Font = new System.Drawing.Font("Kh Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_MB.ForeColor = System.Drawing.Color.AliceBlue;
            this.T_MB.Location = new System.Drawing.Point(0, 65);
            this.T_MB.Margin = new System.Windows.Forms.Padding(4);
            this.T_MB.Name = "T_MB";
            this.T_MB.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.M_Product,
            this.M_Sale,
            this.M_Customer,
            this.M_PricePromotion,
            this.M_UserControl,
            this.M_Tools,
            this.M_SwithUser,
            this.M_BackupFile});
            this.T_MB.NodesConnector = this.nodeConnector1;
            this.T_MB.NodeStyle = this.elementStyle1;
            this.T_MB.PathSeparator = ";";
            this.T_MB.Size = new System.Drawing.Size(321, 681);
            this.T_MB.Styles.Add(this.elementStyle1);
            this.T_MB.Styles.Add(this.elementStyle3);
            this.T_MB.Styles.Add(this.elementStyle4);
            this.T_MB.Styles.Add(this.elementStyle2);
            this.T_MB.TabIndex = 23;
            this.T_MB.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.T_MB_AfterNodeSelect);
            // 
            // M_Product
            // 
            this.M_Product.Expanded = true;
            this.M_Product.Image = ((System.Drawing.Image)(resources.GetObject("M_Product.Image")));
            this.M_Product.Name = "M_Product";
            this.M_Product.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.P_Product,
            this.P_Category,
            this.P_Brand});
            this.M_Product.Style = this.elementStyle1;
            this.M_Product.StyleSelected = this.elementStyle1;
            this.M_Product.Text = "គ្រប់គ្រងផលិតផល";
            // 
            // P_Product
            // 
            this.P_Product.Expanded = true;
            this.P_Product.Name = "P_Product";
            this.P_Product.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.Product_Input,
            this.Product_List});
            this.P_Product.Text = "ផលិតផល";
            // 
            // Product_Input
            // 
            this.Product_Input.Expanded = true;
            this.Product_Input.Name = "Product_Input";
            this.Product_Input.Text = "បញ្ចូលផលិតផលថ្មី";
            // 
            // Product_List
            // 
            this.Product_List.Expanded = true;
            this.Product_List.Name = "Product_List";
            this.Product_List.Text = "ព័ត៌មានផលិតផលថ្មី";
            // 
            // P_Category
            // 
            this.P_Category.Name = "P_Category";
            this.P_Category.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.Cate_Input,
            this.Cate_List});
            this.P_Category.Text = "ប្រភេទ";
            // 
            // Cate_Input
            // 
            this.Cate_Input.Expanded = true;
            this.Cate_Input.Name = "Cate_Input";
            this.Cate_Input.Text = "បញ្ចូលប្រភេទផលិតផល";
            // 
            // Cate_List
            // 
            this.Cate_List.Expanded = true;
            this.Cate_List.Name = "Cate_List";
            this.Cate_List.Text = "ព័ត៌មានផលិតផល";
            // 
            // P_Brand
            // 
            this.P_Brand.Name = "P_Brand";
            this.P_Brand.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.Brand_Input,
            this.Brand_List});
            this.P_Brand.Text = "ម៉ាក់យីហោ";
            // 
            // Brand_Input
            // 
            this.Brand_Input.Expanded = true;
            this.Brand_Input.Name = "Brand_Input";
            this.Brand_Input.Text = "បញ្ចូលម៉ាក់យីហោ";
            // 
            // Brand_List
            // 
            this.Brand_List.Expanded = true;
            this.Brand_List.Name = "Brand_List";
            this.Brand_List.Text = "ព័ត៌មានម៉ាកយីហោ";
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // M_Sale
            // 
            this.M_Sale.Expanded = true;
            this.M_Sale.Image = ((System.Drawing.Image)(resources.GetObject("M_Sale.Image")));
            this.M_Sale.Name = "M_Sale";
            this.M_Sale.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.P_Sale,
            this.P_HisSale,
            this.P_NoteCustomer,
            this.P_Stock});
            this.M_Sale.Text = "គ្រប់គ្រងការលក់";
            // 
            // P_Sale
            // 
            this.P_Sale.Expanded = true;
            this.P_Sale.Name = "P_Sale";
            this.P_Sale.Text = "ប្រតិបត្តិការលក់";
            // 
            // P_HisSale
            // 
            this.P_HisSale.Expanded = true;
            this.P_HisSale.Name = "P_HisSale";
            this.P_HisSale.Text = "របាយការណ៍លក់ប្រចាំថ្ងៃ";
            // 
            // P_NoteCustomer
            // 
            this.P_NoteCustomer.Expanded = true;
            this.P_NoteCustomer.Name = "P_NoteCustomer";
            this.P_NoteCustomer.Text = "របាយការណ៍លក់-អតិថិជន";
            // 
            // P_Stock
            // 
            this.P_Stock.Expanded = true;
            this.P_Stock.Name = "P_Stock";
            this.P_Stock.Text = "របាយការណ៍ស្ថានភាពស្តុកទំនិញ";
            // 
            // M_Customer
            // 
            this.M_Customer.Image = ((System.Drawing.Image)(resources.GetObject("M_Customer.Image")));
            this.M_Customer.Name = "M_Customer";
            this.M_Customer.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.T_CustomerInput,
            this.C_CustomerList});
            this.M_Customer.Text = "គ្រប់គ្រងអតិថិជន";
            // 
            // T_CustomerInput
            // 
            this.T_CustomerInput.Expanded = true;
            this.T_CustomerInput.Name = "T_CustomerInput";
            this.T_CustomerInput.Text = "បញ្ចូលអតិថិជនថ្មី";
            // 
            // C_CustomerList
            // 
            this.C_CustomerList.Expanded = true;
            this.C_CustomerList.Name = "C_CustomerList";
            this.C_CustomerList.Text = "បញ្ជីអតិថិជន និងប្រវត្តិរូប";
            // 
            // M_PricePromotion
            // 
            this.M_PricePromotion.Image = ((System.Drawing.Image)(resources.GetObject("M_PricePromotion.Image")));
            this.M_PricePromotion.Name = "M_PricePromotion";
            this.M_PricePromotion.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.Barcode,
            this.Price_Promotion});
            this.M_PricePromotion.Text = "គ្រប់គ្រងតម្លៃផលិតផល";
            // 
            // Barcode
            // 
            this.Barcode.Expanded = true;
            this.Barcode.Name = "Barcode";
            this.Barcode.Text = "បង្កើតBarCode";
            // 
            // Price_Promotion
            // 
            this.Price_Promotion.Expanded = true;
            this.Price_Promotion.Name = "Price_Promotion";
            this.Price_Promotion.Text = "កំណត់តម្លៃផលិតផល";
            // 
            // M_UserControl
            // 
            this.M_UserControl.Image = ((System.Drawing.Image)(resources.GetObject("M_UserControl.Image")));
            this.M_UserControl.Name = "M_UserControl";
            this.M_UserControl.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.U_UserList,
            this.U_ChangePW});
            this.M_UserControl.Text = "គ្រប់គ្រងសិទ្ធប្រើប្រាស់";
            // 
            // U_UserList
            // 
            this.U_UserList.Expanded = true;
            this.U_UserList.Name = "U_UserList";
            this.U_UserList.Text = "គណនីប្រើប្រាស់";
            // 
            // U_ChangePW
            // 
            this.U_ChangePW.Expanded = true;
            this.U_ChangePW.Name = "U_ChangePW";
            this.U_ChangePW.Text = "ផ្លាស់ប្តូរលេខសំងាត់";
            // 
            // M_Tools
            // 
            this.M_Tools.Image = ((System.Drawing.Image)(resources.GetObject("M_Tools.Image")));
            this.M_Tools.Name = "M_Tools";
            this.M_Tools.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.T_Money,
            this.T_Post,
            this.T_Printer});
            this.M_Tools.Text = "ជំនួយការកម្មវិធី";
            // 
            // T_Money
            // 
            this.T_Money.Expanded = true;
            this.T_Money.Name = "T_Money";
            this.T_Money.Text = "កំណត់អត្រាប្តូរប្រាក់";
            // 
            // T_Post
            // 
            this.T_Post.Expanded = true;
            this.T_Post.Name = "T_Post";
            this.T_Post.Text = "កំណត់មុខតំណែង";
            // 
            // T_Printer
            // 
            this.T_Printer.Expanded = true;
            this.T_Printer.Name = "T_Printer";
            this.T_Printer.Text = "កំណត់ម៉ាស៊ីនព្រីនធើ";
            // 
            // M_SwithUser
            // 
            this.M_SwithUser.Expanded = true;
            this.M_SwithUser.Image = ((System.Drawing.Image)(resources.GetObject("M_SwithUser.Image")));
            this.M_SwithUser.Name = "M_SwithUser";
            this.M_SwithUser.Text = "ផ្លាស់ប្តូរគណនី";
            // 
            // M_BackupFile
            // 
            this.M_BackupFile.Expanded = true;
            this.M_BackupFile.Image = ((System.Drawing.Image)(resources.GetObject("M_BackupFile.Image")));
            this.M_BackupFile.Name = "M_BackupFile";
            this.M_BackupFile.Text = "ធ្វើសមកាលកម្មទិន្នន័យ";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle3
            // 
            this.elementStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.elementStyle3.BackColor2 = System.Drawing.Color.Navy;
            this.elementStyle3.BackColorGradientAngle = 90;
            this.elementStyle3.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderBottomWidth = 1;
            this.elementStyle3.BorderColor = System.Drawing.Color.Navy;
            this.elementStyle3.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderLeftWidth = 1;
            this.elementStyle3.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderRightWidth = 1;
            this.elementStyle3.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderTopWidth = 1;
            this.elementStyle3.CornerDiameter = 4;
            this.elementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle3.Description = "BlueNight";
            this.elementStyle3.Name = "elementStyle3";
            this.elementStyle3.PaddingBottom = 1;
            this.elementStyle3.PaddingLeft = 1;
            this.elementStyle3.PaddingRight = 1;
            this.elementStyle3.PaddingTop = 1;
            this.elementStyle3.TextColor = System.Drawing.Color.White;
            // 
            // elementStyle4
            // 
            this.elementStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle4.BackColorGradientAngle = 90;
            this.elementStyle4.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle4.BorderBottomWidth = 1;
            this.elementStyle4.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle4.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle4.BorderLeftWidth = 1;
            this.elementStyle4.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle4.BorderRightWidth = 1;
            this.elementStyle4.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle4.BorderTopWidth = 1;
            this.elementStyle4.CornerDiameter = 4;
            this.elementStyle4.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle4.Description = "Blue";
            this.elementStyle4.Name = "elementStyle4";
            this.elementStyle4.PaddingBottom = 1;
            this.elementStyle4.PaddingLeft = 1;
            this.elementStyle4.PaddingRight = 1;
            this.elementStyle4.PaddingTop = 1;
            this.elementStyle4.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle2
            // 
            this.elementStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elementStyle2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(224)))), ((int)(((byte)(252)))));
            this.elementStyle2.BackColorGradientAngle = 90;
            this.elementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderBottomWidth = 1;
            this.elementStyle2.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderLeftWidth = 1;
            this.elementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderRightWidth = 1;
            this.elementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderTopWidth = 1;
            this.elementStyle2.CornerDiameter = 4;
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Description = "BlueLight";
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.PaddingBottom = 1;
            this.elementStyle2.PaddingLeft = 1;
            this.elementStyle2.PaddingRight = 1;
            this.elementStyle2.PaddingTop = 1;
            this.elementStyle2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(84)))), ((int)(((byte)(115)))));
            // 
            // P_MB
            // 
            this.P_MB.CanvasColor = System.Drawing.SystemColors.Control;
            this.P_MB.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.P_MB.DisabledBackColor = System.Drawing.Color.Empty;
            this.P_MB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_MB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_MB.Location = new System.Drawing.Point(321, 65);
            this.P_MB.Margin = new System.Windows.Forms.Padding(4);
            this.P_MB.Name = "P_MB";
            this.P_MB.Size = new System.Drawing.Size(1395, 681);
            this.P_MB.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.P_MB.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.P_MB.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.P_MB.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.P_MB.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.P_MB.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.P_MB.Style.GradientAngle = 90;
            this.P_MB.TabIndex = 34;
            this.P_MB.Text = "Welcome";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 746);
            this.Controls.Add(this.P_MB);
            this.Controls.Add(this.T_MB);
            this.Controls.Add(this.P_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.Text = "frm_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.P_Top.ResumeLayout(false);
            this.P_Top.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_MB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Top;
        public System.Windows.Forms.Label lblMB;
        public System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        public DevComponents.AdvTree.AdvTree T_MB;
        public DevComponents.AdvTree.Node M_Product;
        public DevComponents.AdvTree.Node P_Product;
        public DevComponents.AdvTree.Node Product_Input;
        public DevComponents.AdvTree.Node Product_List;
        public DevComponents.AdvTree.Node P_Category;
        public DevComponents.AdvTree.Node Cate_Input;
        public DevComponents.AdvTree.Node Cate_List;
        public DevComponents.AdvTree.Node P_Brand;
        public DevComponents.AdvTree.Node Brand_Input;
        public DevComponents.AdvTree.Node Brand_List;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        public DevComponents.AdvTree.Node M_Sale;
        public DevComponents.AdvTree.Node P_Sale;
        public DevComponents.AdvTree.Node P_HisSale;
        public DevComponents.AdvTree.Node P_NoteCustomer;
        public DevComponents.AdvTree.Node P_Stock;
        public DevComponents.AdvTree.Node M_Customer;
        public DevComponents.AdvTree.Node T_CustomerInput;
        public DevComponents.AdvTree.Node C_CustomerList;
        public DevComponents.AdvTree.Node M_PricePromotion;
        public DevComponents.AdvTree.Node Barcode;
        public DevComponents.AdvTree.Node Price_Promotion;
        public DevComponents.AdvTree.Node M_UserControl;
        public DevComponents.AdvTree.Node U_UserList;
        public DevComponents.AdvTree.Node U_ChangePW;
        public DevComponents.AdvTree.Node M_Tools;
        public DevComponents.AdvTree.Node T_Money;
        public DevComponents.AdvTree.Node T_Post;
        public DevComponents.AdvTree.Node T_Printer;
        public DevComponents.AdvTree.Node M_SwithUser;
        public DevComponents.AdvTree.Node M_BackupFile;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle3;
        private DevComponents.DotNetBar.ElementStyle elementStyle4;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        public DevComponents.DotNetBar.PanelEx P_MB;
    }
}