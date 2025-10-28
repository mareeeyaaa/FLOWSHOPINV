namespace FLOWSHOPINV.Sales
{
    partial class Sales_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Panel));
            this.SalesSC = new System.Windows.Forms.SplitContainer();
            this.ssprofbtn = new System.Windows.Forms.Button();
            this.sscsbtn = new System.Windows.Forms.Button();
            this.ssprodbtn = new System.Windows.Forms.Button();
            this.ssordersbutton = new System.Windows.Forms.Button();
            this.ssdbbtn = new System.Windows.Forms.Button();
            this.HiSalesPanel = new System.Windows.Forms.Label();
            this.SalesPanelFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.StaffPanel = new System.Windows.Forms.Label();
            this.ssprofPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalesSC)).BeginInit();
            this.SalesSC.Panel1.SuspendLayout();
            this.SalesSC.Panel2.SuspendLayout();
            this.SalesSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssprofPB)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesSC
            // 
            this.SalesSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesSC.Location = new System.Drawing.Point(0, 0);
            this.SalesSC.Name = "SalesSC";
            // 
            // SalesSC.Panel1
            // 
            this.SalesSC.Panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.SalesSC.Panel1.Controls.Add(this.ssprofPB);
            this.SalesSC.Panel1.Controls.Add(this.StaffPanel);
            this.SalesSC.Panel1.Controls.Add(this.ssprofbtn);
            this.SalesSC.Panel1.Controls.Add(this.sscsbtn);
            this.SalesSC.Panel1.Controls.Add(this.ssprodbtn);
            this.SalesSC.Panel1.Controls.Add(this.ssordersbutton);
            this.SalesSC.Panel1.Controls.Add(this.ssdbbtn);
            this.SalesSC.Panel1.Controls.Add(this.HiSalesPanel);
            // 
            // SalesSC.Panel2
            // 
            this.SalesSC.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SalesSC.Panel2.Controls.Add(this.SalesPanelFLP);
            this.SalesSC.Size = new System.Drawing.Size(1616, 859);
            this.SalesSC.SplitterDistance = 332;
            this.SalesSC.TabIndex = 1;
            // 
            // ssprofbtn
            // 
            this.ssprofbtn.BackColor = System.Drawing.Color.Transparent;
            this.ssprofbtn.FlatAppearance.BorderSize = 0;
            this.ssprofbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ssprofbtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssprofbtn.Location = new System.Drawing.Point(-49, 582);
            this.ssprofbtn.Name = "ssprofbtn";
            this.ssprofbtn.Size = new System.Drawing.Size(382, 75);
            this.ssprofbtn.TabIndex = 5;
            this.ssprofbtn.Text = "👤 Profile";
            this.ssprofbtn.UseVisualStyleBackColor = false;
            // 
            // sscsbtn
            // 
            this.sscsbtn.BackColor = System.Drawing.Color.Transparent;
            this.sscsbtn.FlatAppearance.BorderSize = 0;
            this.sscsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sscsbtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscsbtn.Location = new System.Drawing.Point(-48, 494);
            this.sscsbtn.Name = "sscsbtn";
            this.sscsbtn.Size = new System.Drawing.Size(384, 82);
            this.sscsbtn.TabIndex = 4;
            this.sscsbtn.Text = "📠  Cashier";
            this.sscsbtn.UseVisualStyleBackColor = false;
            // 
            // ssprodbtn
            // 
            this.ssprodbtn.BackColor = System.Drawing.Color.Transparent;
            this.ssprodbtn.FlatAppearance.BorderSize = 0;
            this.ssprodbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ssprodbtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssprodbtn.Location = new System.Drawing.Point(-30, 413);
            this.ssprodbtn.Name = "ssprodbtn";
            this.ssprodbtn.Size = new System.Drawing.Size(363, 75);
            this.ssprodbtn.TabIndex = 3;
            this.ssprodbtn.Text = "📦  Products";
            this.ssprodbtn.UseVisualStyleBackColor = false;
            this.ssprodbtn.Click += new System.EventHandler(this.ssprodbtn_Click);
            // 
            // ssordersbutton
            // 
            this.ssordersbutton.BackColor = System.Drawing.Color.Transparent;
            this.ssordersbutton.FlatAppearance.BorderSize = 0;
            this.ssordersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ssordersbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssordersbutton.Location = new System.Drawing.Point(-49, 329);
            this.ssordersbutton.Name = "ssordersbutton";
            this.ssordersbutton.Size = new System.Drawing.Size(393, 75);
            this.ssordersbutton.TabIndex = 2;
            this.ssordersbutton.Text = "🛒  Orders";
            this.ssordersbutton.UseVisualStyleBackColor = false;
            // 
            // ssdbbtn
            // 
            this.ssdbbtn.BackColor = System.Drawing.Color.Transparent;
            this.ssdbbtn.FlatAppearance.BorderSize = 0;
            this.ssdbbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ssdbbtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssdbbtn.Location = new System.Drawing.Point(-30, 248);
            this.ssdbbtn.Name = "ssdbbtn";
            this.ssdbbtn.Size = new System.Drawing.Size(379, 75);
            this.ssdbbtn.TabIndex = 1;
            this.ssdbbtn.Text = "🗂️  Dashboard";
            this.ssdbbtn.UseVisualStyleBackColor = false;
            // 
            // HiSalesPanel
            // 
            this.HiSalesPanel.AutoSize = true;
            this.HiSalesPanel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiSalesPanel.ForeColor = System.Drawing.Color.Black;
            this.HiSalesPanel.Location = new System.Drawing.Point(100, 165);
            this.HiSalesPanel.Name = "HiSalesPanel";
            this.HiSalesPanel.Size = new System.Drawing.Size(64, 39);
            this.HiSalesPanel.TabIndex = 0;
            this.HiSalesPanel.Text = "Hi, ";
            this.HiSalesPanel.Click += new System.EventHandler(this.HiSalesPanel_Click);
            // 
            // SalesPanelFLP
            // 
            this.SalesPanelFLP.AutoScroll = true;
            this.SalesPanelFLP.BackColor = System.Drawing.Color.Transparent;
            this.SalesPanelFLP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalesPanelFLP.BackgroundImage")));
            this.SalesPanelFLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SalesPanelFLP.Location = new System.Drawing.Point(2, 2);
            this.SalesPanelFLP.Margin = new System.Windows.Forms.Padding(2);
            this.SalesPanelFLP.Name = "SalesPanelFLP";
            this.SalesPanelFLP.Size = new System.Drawing.Size(1276, 855);
            this.SalesPanelFLP.TabIndex = 2;
            // 
            // StaffPanel
            // 
            this.StaffPanel.AutoSize = true;
            this.StaffPanel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPanel.ForeColor = System.Drawing.Color.Black;
            this.StaffPanel.Location = new System.Drawing.Point(149, 165);
            this.StaffPanel.Name = "StaffPanel";
            this.StaffPanel.Size = new System.Drawing.Size(80, 39);
            this.StaffPanel.TabIndex = 8;
            this.StaffPanel.Text = "Staff";
            // 
            // ssprofPB
            // 
            this.ssprofPB.Location = new System.Drawing.Point(107, 61);
            this.ssprofPB.Name = "ssprofPB";
            this.ssprofPB.Size = new System.Drawing.Size(112, 95);
            this.ssprofPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ssprofPB.TabIndex = 9;
            this.ssprofPB.TabStop = false;
            // 
            // Sales_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1616, 859);
            this.Controls.Add(this.SalesSC);
            this.Name = "Sales_Panel";
            this.Text = "Sales_Panel";
            this.SalesSC.Panel1.ResumeLayout(false);
            this.SalesSC.Panel1.PerformLayout();
            this.SalesSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesSC)).EndInit();
            this.SalesSC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssprofPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SalesSC;
        private System.Windows.Forms.Button ssprofbtn;
        private System.Windows.Forms.Button sscsbtn;
        private System.Windows.Forms.Button ssprodbtn;
        private System.Windows.Forms.Button ssordersbutton;
        private System.Windows.Forms.Button ssdbbtn;
        private System.Windows.Forms.Label HiSalesPanel;
        private System.Windows.Forms.FlowLayoutPanel SalesPanelFLP;
        private System.Windows.Forms.Label StaffPanel;
        private System.Windows.Forms.PictureBox ssprofPB;
    }
}