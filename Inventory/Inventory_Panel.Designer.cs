namespace FLOWSHOPINV.Inventory
{
    partial class Inventory_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Panel));
            this.InventorySC = new System.Windows.Forms.SplitContainer();
            this.isprofPB = new System.Windows.Forms.PictureBox();
            this.InventoryStaffPanel = new System.Windows.Forms.Label();
            this.isprofbtn = new System.Windows.Forms.Button();
            this.isresprodbtn = new System.Windows.Forms.Button();
            this.isinventorybutton = new System.Windows.Forms.Button();
            this.isdbbtn = new System.Windows.Forms.Button();
            this.HiInventoryPanel = new System.Windows.Forms.Label();
            this.InventoryPanelFLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.InventorySC)).BeginInit();
            this.InventorySC.Panel1.SuspendLayout();
            this.InventorySC.Panel2.SuspendLayout();
            this.InventorySC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isprofPB)).BeginInit();
            this.SuspendLayout();
            // 
            // InventorySC
            // 
            this.InventorySC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventorySC.Location = new System.Drawing.Point(0, 0);
            this.InventorySC.Name = "InventorySC";
            // 
            // InventorySC.Panel1
            // 
            this.InventorySC.Panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.InventorySC.Panel1.Controls.Add(this.isprofPB);
            this.InventorySC.Panel1.Controls.Add(this.InventoryStaffPanel);
            this.InventorySC.Panel1.Controls.Add(this.isprofbtn);
            this.InventorySC.Panel1.Controls.Add(this.isresprodbtn);
            this.InventorySC.Panel1.Controls.Add(this.isinventorybutton);
            this.InventorySC.Panel1.Controls.Add(this.isdbbtn);
            this.InventorySC.Panel1.Controls.Add(this.HiInventoryPanel);
            // 
            // InventorySC.Panel2
            // 
            this.InventorySC.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventorySC.Panel2.Controls.Add(this.InventoryPanelFLP);
            this.InventorySC.Size = new System.Drawing.Size(1616, 859);
            this.InventorySC.SplitterDistance = 332;
            this.InventorySC.TabIndex = 2;
            // 
            // isprofPB
            // 
            this.isprofPB.Location = new System.Drawing.Point(107, 61);
            this.isprofPB.Name = "isprofPB";
            this.isprofPB.Size = new System.Drawing.Size(112, 95);
            this.isprofPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.isprofPB.TabIndex = 9;
            this.isprofPB.TabStop = false;
            // 
            // InventoryStaffPanel
            // 
            this.InventoryStaffPanel.AutoSize = true;
            this.InventoryStaffPanel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryStaffPanel.ForeColor = System.Drawing.Color.Black;
            this.InventoryStaffPanel.Location = new System.Drawing.Point(149, 165);
            this.InventoryStaffPanel.Name = "InventoryStaffPanel";
            this.InventoryStaffPanel.Size = new System.Drawing.Size(80, 39);
            this.InventoryStaffPanel.TabIndex = 8;
            this.InventoryStaffPanel.Text = "Staff";
            // 
            // isprofbtn
            // 
            this.isprofbtn.BackColor = System.Drawing.Color.Transparent;
            this.isprofbtn.FlatAppearance.BorderSize = 0;
            this.isprofbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isprofbtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isprofbtn.Location = new System.Drawing.Point(-127, 491);
            this.isprofbtn.Name = "isprofbtn";
            this.isprofbtn.Size = new System.Drawing.Size(473, 75);
            this.isprofbtn.TabIndex = 5;
            this.isprofbtn.Text = "👤 Profile";
            this.isprofbtn.UseVisualStyleBackColor = false;
            // 
            // isresprodbtn
            // 
            this.isresprodbtn.BackColor = System.Drawing.Color.Transparent;
            this.isresprodbtn.FlatAppearance.BorderSize = 0;
            this.isresprodbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isresprodbtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isresprodbtn.Location = new System.Drawing.Point(-17, 410);
            this.isresprodbtn.Name = "isresprodbtn";
            this.isresprodbtn.Size = new System.Drawing.Size(363, 75);
            this.isresprodbtn.TabIndex = 3;
            this.isresprodbtn.Text = "📈   Restock Products";
            this.isresprodbtn.UseVisualStyleBackColor = false;
            // 
            // isinventorybutton
            // 
            this.isinventorybutton.BackColor = System.Drawing.Color.Transparent;
            this.isinventorybutton.FlatAppearance.BorderSize = 0;
            this.isinventorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isinventorybutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isinventorybutton.Location = new System.Drawing.Point(-76, 329);
            this.isinventorybutton.Name = "isinventorybutton";
            this.isinventorybutton.Size = new System.Drawing.Size(409, 75);
            this.isinventorybutton.TabIndex = 2;
            this.isinventorybutton.Text = "📇  Inventory";
            this.isinventorybutton.UseVisualStyleBackColor = false;
            // 
            // isdbbtn
            // 
            this.isdbbtn.BackColor = System.Drawing.Color.Transparent;
            this.isdbbtn.FlatAppearance.BorderSize = 0;
            this.isdbbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isdbbtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isdbbtn.Location = new System.Drawing.Point(-73, 248);
            this.isdbbtn.Name = "isdbbtn";
            this.isdbbtn.Size = new System.Drawing.Size(412, 75);
            this.isdbbtn.TabIndex = 1;
            this.isdbbtn.Text = "🗂️  Dashboard";
            this.isdbbtn.UseVisualStyleBackColor = false;
            // 
            // HiInventoryPanel
            // 
            this.HiInventoryPanel.AutoSize = true;
            this.HiInventoryPanel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiInventoryPanel.ForeColor = System.Drawing.Color.Black;
            this.HiInventoryPanel.Location = new System.Drawing.Point(100, 165);
            this.HiInventoryPanel.Name = "HiInventoryPanel";
            this.HiInventoryPanel.Size = new System.Drawing.Size(64, 39);
            this.HiInventoryPanel.TabIndex = 0;
            this.HiInventoryPanel.Text = "Hi, ";
            // 
            // InventoryPanelFLP
            // 
            this.InventoryPanelFLP.AutoScroll = true;
            this.InventoryPanelFLP.BackColor = System.Drawing.Color.Transparent;
            this.InventoryPanelFLP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPanelFLP.BackgroundImage")));
            this.InventoryPanelFLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPanelFLP.Location = new System.Drawing.Point(2, 2);
            this.InventoryPanelFLP.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryPanelFLP.Name = "InventoryPanelFLP";
            this.InventoryPanelFLP.Size = new System.Drawing.Size(1276, 855);
            this.InventoryPanelFLP.TabIndex = 2;
            // 
            // Inventory_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 859);
            this.Controls.Add(this.InventorySC);
            this.Name = "Inventory_Panel";
            this.Text = "Inventory_Panel";
            this.InventorySC.Panel1.ResumeLayout(false);
            this.InventorySC.Panel1.PerformLayout();
            this.InventorySC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventorySC)).EndInit();
            this.InventorySC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isprofPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer InventorySC;
        private System.Windows.Forms.PictureBox isprofPB;
        private System.Windows.Forms.Label InventoryStaffPanel;
        private System.Windows.Forms.Button isprofbtn;
        private System.Windows.Forms.Button isresprodbtn;
        private System.Windows.Forms.Button isinventorybutton;
        private System.Windows.Forms.Button isdbbtn;
        private System.Windows.Forms.Label HiInventoryPanel;
        private System.Windows.Forms.FlowLayoutPanel InventoryPanelFLP;
    }
}