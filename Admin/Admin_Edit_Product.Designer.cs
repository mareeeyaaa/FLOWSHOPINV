namespace FLOWSHOPINV.Admin
{
    partial class Admin_Edit_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Edit_Product));
            this.prodnamelbl = new System.Windows.Forms.Label();
            this.prodnameTB = new System.Windows.Forms.TextBox();
            this.prlbl = new System.Windows.Forms.Label();
            this.prTB = new System.Windows.Forms.TextBox();
            this.ctgTB = new System.Windows.Forms.TextBox();
            this.ctglbl = new System.Windows.Forms.Label();
            this.quanlbl = new System.Windows.Forms.Label();
            this.quanTB = new System.Windows.Forms.TextBox();
            this.descripTB = new System.Windows.Forms.TextBox();
            this.dcrplbl = new System.Windows.Forms.Label();
            this.sttlbl = new System.Windows.Forms.Label();
            this.sttTB = new System.Windows.Forms.TextBox();
            this.fpCB = new System.Windows.Forms.CheckBox();
            this.addprodPB = new System.Windows.Forms.PictureBox();
            this.prodimglbl = new System.Windows.Forms.Label();
            this.choosesfTB = new System.Windows.Forms.TextBox();
            this.cfbtn = new System.Windows.Forms.Button();
            this.descisionpanel = new System.Windows.Forms.Panel();
            this.closebutton = new System.Windows.Forms.Button();
            this.scbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addprodPB)).BeginInit();
            this.descisionpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodnamelbl
            // 
            this.prodnamelbl.AutoSize = true;
            this.prodnamelbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodnamelbl.Location = new System.Drawing.Point(12, 27);
            this.prodnamelbl.Name = "prodnamelbl";
            this.prodnamelbl.Size = new System.Drawing.Size(117, 22);
            this.prodnamelbl.TabIndex = 22;
            this.prodnamelbl.Text = "Product Name";
            // 
            // prodnameTB
            // 
            this.prodnameTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prodnameTB.Location = new System.Drawing.Point(16, 73);
            this.prodnameTB.Multiline = true;
            this.prodnameTB.Name = "prodnameTB";
            this.prodnameTB.Size = new System.Drawing.Size(298, 40);
            this.prodnameTB.TabIndex = 23;
            this.prodnameTB.TextChanged += new System.EventHandler(this.prodnameTB_TextChanged);
            // 
            // prlbl
            // 
            this.prlbl.AutoSize = true;
            this.prlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prlbl.Location = new System.Drawing.Point(12, 136);
            this.prlbl.Name = "prlbl";
            this.prlbl.Size = new System.Drawing.Size(47, 22);
            this.prlbl.TabIndex = 24;
            this.prlbl.Text = "Price";
            this.prlbl.Click += new System.EventHandler(this.prlbl_Click);
            // 
            // prTB
            // 
            this.prTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prTB.Location = new System.Drawing.Point(16, 172);
            this.prTB.Multiline = true;
            this.prTB.Name = "prTB";
            this.prTB.Size = new System.Drawing.Size(298, 40);
            this.prTB.TabIndex = 25;
            this.prTB.TextChanged += new System.EventHandler(this.prTB_TextChanged);
            // 
            // ctgTB
            // 
            this.ctgTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ctgTB.Location = new System.Drawing.Point(16, 271);
            this.ctgTB.Multiline = true;
            this.ctgTB.Name = "ctgTB";
            this.ctgTB.Size = new System.Drawing.Size(298, 40);
            this.ctgTB.TabIndex = 26;
            this.ctgTB.TextChanged += new System.EventHandler(this.ctgTB_TextChanged);
            // 
            // ctglbl
            // 
            this.ctglbl.AutoSize = true;
            this.ctglbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctglbl.Location = new System.Drawing.Point(12, 235);
            this.ctglbl.Name = "ctglbl";
            this.ctglbl.Size = new System.Drawing.Size(78, 22);
            this.ctglbl.TabIndex = 27;
            this.ctglbl.Text = "Category";
            // 
            // quanlbl
            // 
            this.quanlbl.AutoSize = true;
            this.quanlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlbl.Location = new System.Drawing.Point(12, 349);
            this.quanlbl.Name = "quanlbl";
            this.quanlbl.Size = new System.Drawing.Size(77, 22);
            this.quanlbl.TabIndex = 28;
            this.quanlbl.Text = "Quantity";
            // 
            // quanTB
            // 
            this.quanTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quanTB.Location = new System.Drawing.Point(16, 393);
            this.quanTB.Multiline = true;
            this.quanTB.Name = "quanTB";
            this.quanTB.Size = new System.Drawing.Size(298, 40);
            this.quanTB.TabIndex = 29;
            this.quanTB.TextChanged += new System.EventHandler(this.quanTB_TextChanged);
            // 
            // descripTB
            // 
            this.descripTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descripTB.Location = new System.Drawing.Point(359, 73);
            this.descripTB.Multiline = true;
            this.descripTB.Name = "descripTB";
            this.descripTB.Size = new System.Drawing.Size(389, 139);
            this.descripTB.TabIndex = 30;
            this.descripTB.TextChanged += new System.EventHandler(this.descripTB_TextChanged);
            // 
            // dcrplbl
            // 
            this.dcrplbl.AutoSize = true;
            this.dcrplbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcrplbl.Location = new System.Drawing.Point(355, 27);
            this.dcrplbl.Name = "dcrplbl";
            this.dcrplbl.Size = new System.Drawing.Size(97, 22);
            this.dcrplbl.TabIndex = 31;
            this.dcrplbl.Text = "Description";
            // 
            // sttlbl
            // 
            this.sttlbl.AutoSize = true;
            this.sttlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sttlbl.Location = new System.Drawing.Point(355, 235);
            this.sttlbl.Name = "sttlbl";
            this.sttlbl.Size = new System.Drawing.Size(57, 22);
            this.sttlbl.TabIndex = 32;
            this.sttlbl.Text = "Status";
            // 
            // sttTB
            // 
            this.sttTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sttTB.Location = new System.Drawing.Point(359, 271);
            this.sttTB.Multiline = true;
            this.sttTB.Name = "sttTB";
            this.sttTB.Size = new System.Drawing.Size(389, 40);
            this.sttTB.TabIndex = 33;
            this.sttTB.TextChanged += new System.EventHandler(this.sttTB_TextChanged);
            // 
            // fpCB
            // 
            this.fpCB.AutoSize = true;
            this.fpCB.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpCB.Location = new System.Drawing.Point(359, 333);
            this.fpCB.Name = "fpCB";
            this.fpCB.Size = new System.Drawing.Size(137, 22);
            this.fpCB.TabIndex = 38;
            this.fpCB.Text = "Featured Products";
            this.fpCB.UseVisualStyleBackColor = true;
            // 
            // addprodPB
            // 
            this.addprodPB.Image = ((System.Drawing.Image)(resources.GetObject("addprodPB.Image")));
            this.addprodPB.Location = new System.Drawing.Point(359, 393);
            this.addprodPB.Name = "addprodPB";
            this.addprodPB.Size = new System.Drawing.Size(389, 217);
            this.addprodPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addprodPB.TabIndex = 39;
            this.addprodPB.TabStop = false;
            // 
            // prodimglbl
            // 
            this.prodimglbl.AutoSize = true;
            this.prodimglbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodimglbl.Location = new System.Drawing.Point(355, 368);
            this.prodimglbl.Name = "prodimglbl";
            this.prodimglbl.Size = new System.Drawing.Size(119, 22);
            this.prodimglbl.TabIndex = 40;
            this.prodimglbl.Text = "Product Image";
            // 
            // choosesfTB
            // 
            this.choosesfTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.choosesfTB.Location = new System.Drawing.Point(359, 616);
            this.choosesfTB.Multiline = true;
            this.choosesfTB.Name = "choosesfTB";
            this.choosesfTB.Size = new System.Drawing.Size(389, 48);
            this.choosesfTB.TabIndex = 41;
            this.choosesfTB.TextChanged += new System.EventHandler(this.choosesfTB_TextChanged);
            // 
            // cfbtn
            // 
            this.cfbtn.BackColor = System.Drawing.SystemColors.Control;
            this.cfbtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfbtn.Location = new System.Drawing.Point(375, 627);
            this.cfbtn.Name = "cfbtn";
            this.cfbtn.Size = new System.Drawing.Size(87, 28);
            this.cfbtn.TabIndex = 42;
            this.cfbtn.Text = "Choose File";
            this.cfbtn.UseVisualStyleBackColor = false;
            // 
            // descisionpanel
            // 
            this.descisionpanel.Controls.Add(this.scbtn);
            this.descisionpanel.Controls.Add(this.closebutton);
            this.descisionpanel.Location = new System.Drawing.Point(-18, 685);
            this.descisionpanel.Name = "descisionpanel";
            this.descisionpanel.Size = new System.Drawing.Size(804, 63);
            this.descisionpanel.TabIndex = 43;
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.closebutton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.Location = new System.Drawing.Point(475, 20);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(133, 30);
            this.closebutton.TabIndex = 3;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = false;
            // 
            // scbtn
            // 
            this.scbtn.BackColor = System.Drawing.Color.LightPink;
            this.scbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scbtn.Location = new System.Drawing.Point(633, 20);
            this.scbtn.Name = "scbtn";
            this.scbtn.Size = new System.Drawing.Size(133, 30);
            this.scbtn.TabIndex = 39;
            this.scbtn.Text = "Save Changes";
            this.scbtn.UseVisualStyleBackColor = false;
            // 
            // Admin_Edit_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 777);
            this.Controls.Add(this.descisionpanel);
            this.Controls.Add(this.cfbtn);
            this.Controls.Add(this.choosesfTB);
            this.Controls.Add(this.prodimglbl);
            this.Controls.Add(this.addprodPB);
            this.Controls.Add(this.fpCB);
            this.Controls.Add(this.sttTB);
            this.Controls.Add(this.sttlbl);
            this.Controls.Add(this.dcrplbl);
            this.Controls.Add(this.descripTB);
            this.Controls.Add(this.quanTB);
            this.Controls.Add(this.quanlbl);
            this.Controls.Add(this.ctglbl);
            this.Controls.Add(this.ctgTB);
            this.Controls.Add(this.prTB);
            this.Controls.Add(this.prlbl);
            this.Controls.Add(this.prodnameTB);
            this.Controls.Add(this.prodnamelbl);
            this.Name = "Admin_Edit_Product";
            this.Text = "Admin_Edit_Product";
            this.Load += new System.EventHandler(this.Admin_Edit_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addprodPB)).EndInit();
            this.descisionpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prodnamelbl;
        private System.Windows.Forms.TextBox prodnameTB;
        private System.Windows.Forms.Label prlbl;
        private System.Windows.Forms.TextBox prTB;
        private System.Windows.Forms.TextBox ctgTB;
        private System.Windows.Forms.Label ctglbl;
        private System.Windows.Forms.Label quanlbl;
        private System.Windows.Forms.TextBox quanTB;
        private System.Windows.Forms.TextBox descripTB;
        private System.Windows.Forms.Label dcrplbl;
        private System.Windows.Forms.Label sttlbl;
        private System.Windows.Forms.TextBox sttTB;
        private System.Windows.Forms.CheckBox fpCB;
        private System.Windows.Forms.PictureBox addprodPB;
        private System.Windows.Forms.Label prodimglbl;
        private System.Windows.Forms.TextBox choosesfTB;
        private System.Windows.Forms.Button cfbtn;
        private System.Windows.Forms.Panel descisionpanel;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button scbtn;
    }
}