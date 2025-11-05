namespace FLOWSHOPINV.Admin
{
    partial class Admin_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.AdminSC = new System.Windows.Forms.SplitContainer();
            this.logoutPB = new System.Windows.Forms.PictureBox();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.ALbutton = new System.Windows.Forms.Button();
            this.staffadminpanel = new System.Windows.Forms.Button();
            this.prodadminpanel = new System.Windows.Forms.Button();
            this.adminordersbutton = new System.Windows.Forms.Button();
            this.dbbutton = new System.Windows.Forms.Button();
            this.AdminPanel = new System.Windows.Forms.Label();
            this.AdminPanelFLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSC)).BeginInit();
            this.AdminSC.Panel1.SuspendLayout();
            this.AdminSC.Panel2.SuspendLayout();
            this.AdminSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPB)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminSC
            // 
            this.AdminSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminSC.Location = new System.Drawing.Point(0, 0);
            this.AdminSC.Name = "AdminSC";
            // 
            // AdminSC.Panel1
            // 
            this.AdminSC.Panel1.BackColor = System.Drawing.Color.Pink;
            this.AdminSC.Panel1.Controls.Add(this.logoutPB);
            this.AdminSC.Panel1.Controls.Add(this.logoutbutton);
            this.AdminSC.Panel1.Controls.Add(this.ALbutton);
            this.AdminSC.Panel1.Controls.Add(this.staffadminpanel);
            this.AdminSC.Panel1.Controls.Add(this.prodadminpanel);
            this.AdminSC.Panel1.Controls.Add(this.adminordersbutton);
            this.AdminSC.Panel1.Controls.Add(this.dbbutton);
            this.AdminSC.Panel1.Controls.Add(this.AdminPanel);
            // 
            // AdminSC.Panel2
            // 
            this.AdminSC.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminSC.Panel2.BackgroundImage")));
            this.AdminSC.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminSC.Panel2.Controls.Add(this.AdminPanelFLP);
            this.AdminSC.Size = new System.Drawing.Size(1616, 859);
            this.AdminSC.SplitterDistance = 332;
            this.AdminSC.TabIndex = 0;
            // 
            // logoutPB
            // 
            this.logoutPB.BackColor = System.Drawing.Color.Transparent;
            this.logoutPB.Image = ((System.Drawing.Image)(resources.GetObject("logoutPB.Image")));
            this.logoutPB.Location = new System.Drawing.Point(94, 569);
            this.logoutPB.Name = "logoutPB";
            this.logoutPB.Size = new System.Drawing.Size(26, 25);
            this.logoutPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutPB.TabIndex = 7;
            this.logoutPB.TabStop = false;
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.Transparent;
            this.logoutbutton.FlatAppearance.BorderSize = 0;
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(-8, 543);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(353, 75);
            this.logoutbutton.TabIndex = 6;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = false;
            // 
            // ALbutton
            // 
            this.ALbutton.BackColor = System.Drawing.Color.Transparent;
            this.ALbutton.FlatAppearance.BorderSize = 0;
            this.ALbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALbutton.Location = new System.Drawing.Point(1, 470);
            this.ALbutton.Name = "ALbutton";
            this.ALbutton.Size = new System.Drawing.Size(341, 75);
            this.ALbutton.TabIndex = 5;
            this.ALbutton.Text = " ⏱ Activity Log";
            this.ALbutton.UseVisualStyleBackColor = false;
            // 
            // staffadminpanel
            // 
            this.staffadminpanel.BackColor = System.Drawing.Color.Transparent;
            this.staffadminpanel.FlatAppearance.BorderSize = 0;
            this.staffadminpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffadminpanel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffadminpanel.Location = new System.Drawing.Point(-50, 392);
            this.staffadminpanel.Name = "staffadminpanel";
            this.staffadminpanel.Size = new System.Drawing.Size(383, 82);
            this.staffadminpanel.TabIndex = 4;
            this.staffadminpanel.Text = "🎭  Staff";
            this.staffadminpanel.UseVisualStyleBackColor = false;
            // 
            // prodadminpanel
            // 
            this.prodadminpanel.BackColor = System.Drawing.Color.Transparent;
            this.prodadminpanel.FlatAppearance.BorderSize = 0;
            this.prodadminpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodadminpanel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodadminpanel.Location = new System.Drawing.Point(-22, 313);
            this.prodadminpanel.Name = "prodadminpanel";
            this.prodadminpanel.Size = new System.Drawing.Size(363, 75);
            this.prodadminpanel.TabIndex = 3;
            this.prodadminpanel.Text = "📦  Products";
            this.prodadminpanel.UseVisualStyleBackColor = false;
            // 
            // adminordersbutton
            // 
            this.adminordersbutton.BackColor = System.Drawing.Color.Transparent;
            this.adminordersbutton.FlatAppearance.BorderSize = 0;
            this.adminordersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminordersbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminordersbutton.Location = new System.Drawing.Point(-51, 240);
            this.adminordersbutton.Name = "adminordersbutton";
            this.adminordersbutton.Size = new System.Drawing.Size(393, 75);
            this.adminordersbutton.TabIndex = 2;
            this.adminordersbutton.Text = "🛒  Orders";
            this.adminordersbutton.UseVisualStyleBackColor = false;
            this.adminordersbutton.Click += new System.EventHandler(this.adminordersbutton_Click);
            // 
            // dbbutton
            // 
            this.dbbutton.BackColor = System.Drawing.Color.Transparent;
            this.dbbutton.FlatAppearance.BorderSize = 0;
            this.dbbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbbutton.Location = new System.Drawing.Point(-22, 159);
            this.dbbutton.Name = "dbbutton";
            this.dbbutton.Size = new System.Drawing.Size(379, 75);
            this.dbbutton.TabIndex = 1;
            this.dbbutton.Text = "🗂️  Dashboard";
            this.dbbutton.UseVisualStyleBackColor = false;
            // 
            // AdminPanel
            // 
            this.AdminPanel.AutoSize = true;
            this.AdminPanel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanel.ForeColor = System.Drawing.Color.Black;
            this.AdminPanel.Location = new System.Drawing.Point(73, 51);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(199, 39);
            this.AdminPanel.TabIndex = 0;
            this.AdminPanel.Text = "Admin Panel ";
            this.AdminPanel.Click += new System.EventHandler(this.AdminPanel_Click);
            // 
            // AdminPanelFLP
            // 
            this.AdminPanelFLP.AutoScroll = true;
            this.AdminPanelFLP.BackColor = System.Drawing.Color.Transparent;
            this.AdminPanelFLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanelFLP.Location = new System.Drawing.Point(0, 0);
            this.AdminPanelFLP.Margin = new System.Windows.Forms.Padding(2);
            this.AdminPanelFLP.Name = "AdminPanelFLP";
            this.AdminPanelFLP.Size = new System.Drawing.Size(1280, 859);
            this.AdminPanelFLP.TabIndex = 2;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 859);
            this.Controls.Add(this.AdminSC);
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.AdminSC.Panel1.ResumeLayout(false);
            this.AdminSC.Panel1.PerformLayout();
            this.AdminSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminSC)).EndInit();
            this.AdminSC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoutPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer AdminSC;
        private System.Windows.Forms.Label AdminPanel;
        private System.Windows.Forms.Button dbbutton;
        private System.Windows.Forms.Button adminordersbutton;
        private System.Windows.Forms.Button prodadminpanel;
        private System.Windows.Forms.Button staffadminpanel;
        private System.Windows.Forms.Button ALbutton;
        private System.Windows.Forms.PictureBox logoutPB;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.FlowLayoutPanel AdminPanelFLP;
    }
}