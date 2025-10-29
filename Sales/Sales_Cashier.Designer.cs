namespace FLOWSHOPINV.Sales
{
    partial class Sales_Cashier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Cashier));
            this.RecievedOrdersFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.sscashsfpanel = new System.Windows.Forms.Panel();
            this.statCB = new System.Windows.Forms.ComboBox();
            this.ssfsbPHTB = new PlaceholderTextBox.PlaceholderTextBox();
            this.searchPB = new System.Windows.Forms.PictureBox();
            this.SSCashiernextbtn = new System.Windows.Forms.Button();
            this.ssCashierPrevbtn = new System.Windows.Forms.Button();
            this.ordertabpanel = new System.Windows.Forms.Panel();
            this.sscashord1panel = new System.Windows.Forms.Panel();
            this.sscashorderidlbl = new System.Windows.Forms.Label();
            this.ordnumlbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.daylbl = new System.Windows.Forms.Label();
            this.shoplbl = new System.Windows.Forms.Label();
            this.totalpricelbl = new System.Windows.Forms.Label();
            this.ssstat2btn = new System.Windows.Forms.Button();
            this.sscashierdelbtn = new System.Windows.Forms.Button();
            this.sscashorderdeetspanel = new System.Windows.Forms.Panel();
            this.qtyprodlbl = new System.Windows.Forms.Label();
            this.prodnamelbl = new System.Windows.Forms.Label();
            this.prodprclbl = new System.Windows.Forms.Label();
            this.qtyprod1lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadOrderpanel = new System.Windows.Forms.Panel();
            this.sstlobtn = new System.Windows.Forms.Button();
            this.sscashiertotalordlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sscashregisterbtn = new System.Windows.Forms.Button();
            this.sscashorderbtn1 = new System.Windows.Forms.Button();
            this.addordbtn = new System.Windows.Forms.Button();
            this.orderidbtnlbl = new System.Windows.Forms.Button();
            this.RecievedOrdersFLP.SuspendLayout();
            this.sscashsfpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPB)).BeginInit();
            this.ordertabpanel.SuspendLayout();
            this.sscashord1panel.SuspendLayout();
            this.sscashorderdeetspanel.SuspendLayout();
            this.LoadOrderpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecievedOrdersFLP
            // 
            this.RecievedOrdersFLP.BackColor = System.Drawing.SystemColors.Window;
            this.RecievedOrdersFLP.Controls.Add(this.sscashsfpanel);
            this.RecievedOrdersFLP.Location = new System.Drawing.Point(41, 97);
            this.RecievedOrdersFLP.Name = "RecievedOrdersFLP";
            this.RecievedOrdersFLP.Size = new System.Drawing.Size(810, 717);
            this.RecievedOrdersFLP.TabIndex = 1;
            // 
            // sscashsfpanel
            // 
            this.sscashsfpanel.BackColor = System.Drawing.SystemColors.Window;
            this.sscashsfpanel.Controls.Add(this.statCB);
            this.sscashsfpanel.Controls.Add(this.ssfsbPHTB);
            this.sscashsfpanel.Controls.Add(this.searchPB);
            this.sscashsfpanel.Controls.Add(this.SSCashiernextbtn);
            this.sscashsfpanel.Controls.Add(this.ssCashierPrevbtn);
            this.sscashsfpanel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscashsfpanel.Location = new System.Drawing.Point(3, 3);
            this.sscashsfpanel.Name = "sscashsfpanel";
            this.sscashsfpanel.Size = new System.Drawing.Size(810, 64);
            this.sscashsfpanel.TabIndex = 6;
            // 
            // statCB
            // 
            this.statCB.AutoCompleteCustomSource.AddRange(new string[] {
            "All Orders",
            "Active ",
            "Inactive"});
            this.statCB.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statCB.FormattingEnabled = true;
            this.statCB.Items.AddRange(new object[] {
            "All Status",
            "Processing",
            "Pending",
            "Done",
            "Return",
            "Cancelled"});
            this.statCB.Location = new System.Drawing.Point(436, 18);
            this.statCB.Name = "statCB";
            this.statCB.Size = new System.Drawing.Size(104, 28);
            this.statCB.TabIndex = 6;
            // 
            // ssfsbPHTB
            // 
            this.ssfsbPHTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssfsbPHTB.Location = new System.Drawing.Point(53, 18);
            this.ssfsbPHTB.Multiline = true;
            this.ssfsbPHTB.Name = "ssfsbPHTB";
            this.ssfsbPHTB.PlaceholderText = "Search Orders...";
            this.ssfsbPHTB.Size = new System.Drawing.Size(369, 28);
            this.ssfsbPHTB.TabIndex = 1;
            // 
            // searchPB
            // 
            this.searchPB.Image = ((System.Drawing.Image)(resources.GetObject("searchPB.Image")));
            this.searchPB.Location = new System.Drawing.Point(27, 22);
            this.searchPB.Name = "searchPB";
            this.searchPB.Size = new System.Drawing.Size(23, 24);
            this.searchPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPB.TabIndex = 3;
            this.searchPB.TabStop = false;
            // 
            // SSCashiernextbtn
            // 
            this.SSCashiernextbtn.BackColor = System.Drawing.Color.LightPink;
            this.SSCashiernextbtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSCashiernextbtn.ForeColor = System.Drawing.Color.Black;
            this.SSCashiernextbtn.Location = new System.Drawing.Point(631, 18);
            this.SSCashiernextbtn.Name = "SSCashiernextbtn";
            this.SSCashiernextbtn.Size = new System.Drawing.Size(84, 28);
            this.SSCashiernextbtn.TabIndex = 36;
            this.SSCashiernextbtn.Text = "⮞";
            this.SSCashiernextbtn.UseVisualStyleBackColor = false;
            // 
            // ssCashierPrevbtn
            // 
            this.ssCashierPrevbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ssCashierPrevbtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssCashierPrevbtn.ForeColor = System.Drawing.Color.Black;
            this.ssCashierPrevbtn.Location = new System.Drawing.Point(550, 18);
            this.ssCashierPrevbtn.Name = "ssCashierPrevbtn";
            this.ssCashierPrevbtn.Size = new System.Drawing.Size(84, 28);
            this.ssCashierPrevbtn.TabIndex = 35;
            this.ssCashierPrevbtn.Text = "⮜";
            this.ssCashierPrevbtn.UseVisualStyleBackColor = false;
            // 
            // ordertabpanel
            // 
            this.ordertabpanel.BackColor = System.Drawing.Color.Transparent;
            this.ordertabpanel.Controls.Add(this.orderidbtnlbl);
            this.ordertabpanel.Controls.Add(this.addordbtn);
            this.ordertabpanel.Controls.Add(this.sscashorderbtn1);
            this.ordertabpanel.Controls.Add(this.sscashregisterbtn);
            this.ordertabpanel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertabpanel.Location = new System.Drawing.Point(41, 34);
            this.ordertabpanel.Name = "ordertabpanel";
            this.ordertabpanel.Size = new System.Drawing.Size(1210, 66);
            this.ordertabpanel.TabIndex = 14;
            // 
            // sscashord1panel
            // 
            this.sscashord1panel.BackColor = System.Drawing.Color.Azure;
            this.sscashord1panel.Controls.Add(this.sscashierdelbtn);
            this.sscashord1panel.Controls.Add(this.ssstat2btn);
            this.sscashord1panel.Controls.Add(this.totalpricelbl);
            this.sscashord1panel.Controls.Add(this.shoplbl);
            this.sscashord1panel.Controls.Add(this.sscashorderidlbl);
            this.sscashord1panel.Controls.Add(this.ordnumlbl);
            this.sscashord1panel.Controls.Add(this.timelbl);
            this.sscashord1panel.Controls.Add(this.daylbl);
            this.sscashord1panel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscashord1panel.Location = new System.Drawing.Point(41, 166);
            this.sscashord1panel.Name = "sscashord1panel";
            this.sscashord1panel.Size = new System.Drawing.Size(810, 64);
            this.sscashord1panel.TabIndex = 37;
            // 
            // sscashorderidlbl
            // 
            this.sscashorderidlbl.AutoSize = true;
            this.sscashorderidlbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscashorderidlbl.ForeColor = System.Drawing.Color.Black;
            this.sscashorderidlbl.Location = new System.Drawing.Point(175, 34);
            this.sscashorderidlbl.Name = "sscashorderidlbl";
            this.sscashorderidlbl.Size = new System.Drawing.Size(85, 18);
            this.sscashorderidlbl.TabIndex = 3;
            this.sscashorderidlbl.Text = "SPR4K9T82L";
            // 
            // ordnumlbl
            // 
            this.ordnumlbl.AutoSize = true;
            this.ordnumlbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.ordnumlbl.Location = new System.Drawing.Point(195, 12);
            this.ordnumlbl.Name = "ordnumlbl";
            this.ordnumlbl.Size = new System.Drawing.Size(44, 22);
            this.ordnumlbl.TabIndex = 2;
            this.ordnumlbl.Text = "OO1";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.ForeColor = System.Drawing.Color.Black;
            this.timelbl.Location = new System.Drawing.Point(33, 34);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(39, 18);
            this.timelbl.TabIndex = 1;
            this.timelbl.Text = "12:51";
            // 
            // daylbl
            // 
            this.daylbl.AutoSize = true;
            this.daylbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.daylbl.Location = new System.Drawing.Point(26, 12);
            this.daylbl.Name = "daylbl";
            this.daylbl.Size = new System.Drawing.Size(61, 22);
            this.daylbl.TabIndex = 0;
            this.daylbl.Text = "Today ";
            // 
            // shoplbl
            // 
            this.shoplbl.AutoSize = true;
            this.shoplbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoplbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.shoplbl.Location = new System.Drawing.Point(371, 12);
            this.shoplbl.Name = "shoplbl";
            this.shoplbl.Size = new System.Drawing.Size(97, 22);
            this.shoplbl.TabIndex = 4;
            this.shoplbl.Text = "Bloom Track";
            // 
            // totalpricelbl
            // 
            this.totalpricelbl.AutoSize = true;
            this.totalpricelbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.totalpricelbl.Location = new System.Drawing.Point(528, 12);
            this.totalpricelbl.Name = "totalpricelbl";
            this.totalpricelbl.Size = new System.Drawing.Size(62, 22);
            this.totalpricelbl.TabIndex = 5;
            this.totalpricelbl.Text = "₱ 8,100";
            // 
            // ssstat2btn
            // 
            this.ssstat2btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ssstat2btn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssstat2btn.Location = new System.Drawing.Point(625, 12);
            this.ssstat2btn.Name = "ssstat2btn";
            this.ssstat2btn.Size = new System.Drawing.Size(75, 23);
            this.ssstat2btn.TabIndex = 10;
            this.ssstat2btn.Text = "Processing";
            this.ssstat2btn.UseVisualStyleBackColor = false;
            // 
            // sscashierdelbtn
            // 
            this.sscashierdelbtn.BackColor = System.Drawing.Color.Transparent;
            this.sscashierdelbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sscashierdelbtn.BackgroundImage")));
            this.sscashierdelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sscashierdelbtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscashierdelbtn.Location = new System.Drawing.Point(750, 9);
            this.sscashierdelbtn.Name = "sscashierdelbtn";
            this.sscashierdelbtn.Size = new System.Drawing.Size(34, 32);
            this.sscashierdelbtn.TabIndex = 26;
            this.sscashierdelbtn.UseVisualStyleBackColor = false;
            // 
            // sscashorderdeetspanel
            // 
            this.sscashorderdeetspanel.BackColor = System.Drawing.SystemColors.Control;
            this.sscashorderdeetspanel.Controls.Add(this.label6);
            this.sscashorderdeetspanel.Controls.Add(this.sscashiertotalordlbl);
            this.sscashorderdeetspanel.Controls.Add(this.LoadOrderpanel);
            this.sscashorderdeetspanel.Controls.Add(this.label5);
            this.sscashorderdeetspanel.Controls.Add(this.label4);
            this.sscashorderdeetspanel.Controls.Add(this.label3);
            this.sscashorderdeetspanel.Controls.Add(this.label2);
            this.sscashorderdeetspanel.Controls.Add(this.label1);
            this.sscashorderdeetspanel.Controls.Add(this.qtyprod1lbl);
            this.sscashorderdeetspanel.Controls.Add(this.prodprclbl);
            this.sscashorderdeetspanel.Controls.Add(this.prodnamelbl);
            this.sscashorderdeetspanel.Controls.Add(this.qtyprodlbl);
            this.sscashorderdeetspanel.Location = new System.Drawing.Point(851, 99);
            this.sscashorderdeetspanel.Name = "sscashorderdeetspanel";
            this.sscashorderdeetspanel.Size = new System.Drawing.Size(400, 715);
            this.sscashorderdeetspanel.TabIndex = 38;
            // 
            // qtyprodlbl
            // 
            this.qtyprodlbl.AutoSize = true;
            this.qtyprodlbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyprodlbl.ForeColor = System.Drawing.Color.Black;
            this.qtyprodlbl.Location = new System.Drawing.Point(9, 25);
            this.qtyprodlbl.Name = "qtyprodlbl";
            this.qtyprodlbl.Size = new System.Drawing.Size(15, 18);
            this.qtyprodlbl.TabIndex = 27;
            this.qtyprodlbl.Text = "1";
            // 
            // prodnamelbl
            // 
            this.prodnamelbl.AutoSize = true;
            this.prodnamelbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodnamelbl.ForeColor = System.Drawing.Color.Black;
            this.prodnamelbl.Location = new System.Drawing.Point(112, 25);
            this.prodnamelbl.Name = "prodnamelbl";
            this.prodnamelbl.Size = new System.Drawing.Size(82, 18);
            this.prodnamelbl.TabIndex = 28;
            this.prodnamelbl.Text = "Eternal Rose";
            // 
            // prodprclbl
            // 
            this.prodprclbl.AutoSize = true;
            this.prodprclbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodprclbl.ForeColor = System.Drawing.Color.Black;
            this.prodprclbl.Location = new System.Drawing.Point(328, 25);
            this.prodprclbl.Name = "prodprclbl";
            this.prodprclbl.Size = new System.Drawing.Size(53, 18);
            this.prodprclbl.TabIndex = 29;
            this.prodprclbl.Text = "₱ 2,500";
            // 
            // qtyprod1lbl
            // 
            this.qtyprod1lbl.AutoSize = true;
            this.qtyprod1lbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyprod1lbl.ForeColor = System.Drawing.Color.Black;
            this.qtyprod1lbl.Location = new System.Drawing.Point(9, 55);
            this.qtyprod1lbl.Name = "qtyprod1lbl";
            this.qtyprod1lbl.Size = new System.Drawing.Size(15, 18);
            this.qtyprod1lbl.TabIndex = 30;
            this.qtyprod1lbl.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Garden Fairytale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(112, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Golden Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(328, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "₱ 4,800";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(328, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "₱ 2,800";
            // 
            // LoadOrderpanel
            // 
            this.LoadOrderpanel.Controls.Add(this.sstlobtn);
            this.LoadOrderpanel.Location = new System.Drawing.Point(0, 593);
            this.LoadOrderpanel.Name = "LoadOrderpanel";
            this.LoadOrderpanel.Size = new System.Drawing.Size(400, 119);
            this.LoadOrderpanel.TabIndex = 36;
            // 
            // sstlobtn
            // 
            this.sstlobtn.BackColor = System.Drawing.Color.DarkCyan;
            this.sstlobtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sstlobtn.ForeColor = System.Drawing.Color.White;
            this.sstlobtn.Location = new System.Drawing.Point(12, 19);
            this.sstlobtn.Name = "sstlobtn";
            this.sstlobtn.Size = new System.Drawing.Size(369, 81);
            this.sstlobtn.TabIndex = 37;
            this.sstlobtn.Text = "Load Order";
            this.sstlobtn.UseVisualStyleBackColor = false;
            // 
            // sscashiertotalordlbl
            // 
            this.sscashiertotalordlbl.AutoSize = true;
            this.sscashiertotalordlbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscashiertotalordlbl.ForeColor = System.Drawing.Color.Black;
            this.sscashiertotalordlbl.Location = new System.Drawing.Point(7, 562);
            this.sscashiertotalordlbl.Name = "sscashiertotalordlbl";
            this.sscashiertotalordlbl.Size = new System.Drawing.Size(63, 28);
            this.sscashiertotalordlbl.TabIndex = 37;
            this.sscashiertotalordlbl.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(295, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 38;
            this.label6.Text = "₱ 10,100";
            // 
            // sscashregisterbtn
            // 
            this.sscashregisterbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sscashregisterbtn.FlatAppearance.BorderSize = 0;
            this.sscashregisterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sscashregisterbtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscashregisterbtn.ForeColor = System.Drawing.Color.Black;
            this.sscashregisterbtn.Location = new System.Drawing.Point(56, 35);
            this.sscashregisterbtn.Name = "sscashregisterbtn";
            this.sscashregisterbtn.Size = new System.Drawing.Size(84, 28);
            this.sscashregisterbtn.TabIndex = 37;
            this.sscashregisterbtn.Text = "Register";
            this.sscashregisterbtn.UseVisualStyleBackColor = false;
            // 
            // sscashorderbtn1
            // 
            this.sscashorderbtn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sscashorderbtn1.FlatAppearance.BorderSize = 0;
            this.sscashorderbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sscashorderbtn1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscashorderbtn1.ForeColor = System.Drawing.Color.Black;
            this.sscashorderbtn1.Location = new System.Drawing.Point(146, 35);
            this.sscashorderbtn1.Name = "sscashorderbtn1";
            this.sscashorderbtn1.Size = new System.Drawing.Size(84, 28);
            this.sscashorderbtn1.TabIndex = 38;
            this.sscashorderbtn1.Text = "Orders";
            this.sscashorderbtn1.UseVisualStyleBackColor = false;
            this.sscashorderbtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addordbtn
            // 
            this.addordbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addordbtn.FlatAppearance.BorderSize = 0;
            this.addordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addordbtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addordbtn.ForeColor = System.Drawing.Color.Black;
            this.addordbtn.Location = new System.Drawing.Point(236, 35);
            this.addordbtn.Name = "addordbtn";
            this.addordbtn.Size = new System.Drawing.Size(53, 28);
            this.addordbtn.TabIndex = 39;
            this.addordbtn.Text = "➕ ";
            this.addordbtn.UseVisualStyleBackColor = false;
            // 
            // orderidbtnlbl
            // 
            this.orderidbtnlbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orderidbtnlbl.FlatAppearance.BorderSize = 0;
            this.orderidbtnlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderidbtnlbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidbtnlbl.ForeColor = System.Drawing.Color.Black;
            this.orderidbtnlbl.Location = new System.Drawing.Point(295, 35);
            this.orderidbtnlbl.Name = "orderidbtnlbl";
            this.orderidbtnlbl.Size = new System.Drawing.Size(84, 28);
            this.orderidbtnlbl.TabIndex = 40;
            this.orderidbtnlbl.Text = "SPR4K9T82L";
            this.orderidbtnlbl.UseVisualStyleBackColor = false;
            // 
            // Sales_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.sscashorderdeetspanel);
            this.Controls.Add(this.ordertabpanel);
            this.Controls.Add(this.sscashord1panel);
            this.Controls.Add(this.RecievedOrdersFLP);
            this.Name = "Sales_Cashier";
            this.Size = new System.Drawing.Size(1276, 855);
            this.RecievedOrdersFLP.ResumeLayout(false);
            this.sscashsfpanel.ResumeLayout(false);
            this.sscashsfpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPB)).EndInit();
            this.ordertabpanel.ResumeLayout(false);
            this.sscashord1panel.ResumeLayout(false);
            this.sscashord1panel.PerformLayout();
            this.sscashorderdeetspanel.ResumeLayout(false);
            this.sscashorderdeetspanel.PerformLayout();
            this.LoadOrderpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RecievedOrdersFLP;
        private System.Windows.Forms.Panel ordertabpanel;
        private System.Windows.Forms.Panel sscashsfpanel;
        private System.Windows.Forms.ComboBox statCB;
        private PlaceholderTextBox.PlaceholderTextBox ssfsbPHTB;
        private System.Windows.Forms.PictureBox searchPB;
        private System.Windows.Forms.Button SSCashiernextbtn;
        private System.Windows.Forms.Button ssCashierPrevbtn;
        private System.Windows.Forms.Panel sscashord1panel;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label daylbl;
        private System.Windows.Forms.Label ordnumlbl;
        private System.Windows.Forms.Label sscashorderidlbl;
        private System.Windows.Forms.Label totalpricelbl;
        private System.Windows.Forms.Label shoplbl;
        private System.Windows.Forms.Button ssstat2btn;
        private System.Windows.Forms.Button sscashierdelbtn;
        private System.Windows.Forms.Panel sscashorderdeetspanel;
        private System.Windows.Forms.Label prodprclbl;
        private System.Windows.Forms.Label prodnamelbl;
        private System.Windows.Forms.Label qtyprodlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label qtyprod1lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LoadOrderpanel;
        private System.Windows.Forms.Label sscashiertotalordlbl;
        private System.Windows.Forms.Button sstlobtn;
        private System.Windows.Forms.Button sscashorderbtn1;
        private System.Windows.Forms.Button sscashregisterbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button orderidbtnlbl;
        private System.Windows.Forms.Button addordbtn;
    }
}
