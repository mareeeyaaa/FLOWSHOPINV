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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dbbutton = new System.Windows.Forms.Button();
            this.AdminPanel = new System.Windows.Forms.Label();
            this.adminordersbutton = new System.Windows.Forms.Button();
            this.prodadminpanel = new System.Windows.Forms.Button();
            this.staffadminpanel = new System.Windows.Forms.Button();
            this.ALbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminPanelFLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightPink;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.logoutbutton);
            this.splitContainer1.Panel1.Controls.Add(this.ALbutton);
            this.splitContainer1.Panel1.Controls.Add(this.staffadminpanel);
            this.splitContainer1.Panel1.Controls.Add(this.prodadminpanel);
            this.splitContainer1.Panel1.Controls.Add(this.adminordersbutton);
            this.splitContainer1.Panel1.Controls.Add(this.dbbutton);
            this.splitContainer1.Panel1.Controls.Add(this.AdminPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.AdminPanelFLP);
            this.splitContainer1.Size = new System.Drawing.Size(1616, 859);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 0;
            // 
            // dbbutton
            // 
            this.dbbutton.BackColor = System.Drawing.Color.Transparent;
            this.dbbutton.FlatAppearance.BorderSize = 0;
            this.dbbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbbutton.Location = new System.Drawing.Point(59, 154);
            this.dbbutton.Name = "dbbutton";
            this.dbbutton.Size = new System.Drawing.Size(185, 38);
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
            // adminordersbutton
            // 
            this.adminordersbutton.BackColor = System.Drawing.Color.Transparent;
            this.adminordersbutton.FlatAppearance.BorderSize = 0;
            this.adminordersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminordersbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminordersbutton.Location = new System.Drawing.Point(19, 221);
            this.adminordersbutton.Name = "adminordersbutton";
            this.adminordersbutton.Size = new System.Drawing.Size(223, 55);
            this.adminordersbutton.TabIndex = 2;
            this.adminordersbutton.Text = "🛒  Orders";
            this.adminordersbutton.UseVisualStyleBackColor = false;
            this.adminordersbutton.Click += new System.EventHandler(this.adminordersbutton_Click);
            // 
            // prodadminpanel
            // 
            this.prodadminpanel.BackColor = System.Drawing.Color.Transparent;
            this.prodadminpanel.FlatAppearance.BorderSize = 0;
            this.prodadminpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodadminpanel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodadminpanel.Location = new System.Drawing.Point(30, 314);
            this.prodadminpanel.Name = "prodadminpanel";
            this.prodadminpanel.Size = new System.Drawing.Size(223, 55);
            this.prodadminpanel.TabIndex = 3;
            this.prodadminpanel.Text = "📦  Products";
            this.prodadminpanel.UseVisualStyleBackColor = false;
            // 
            // staffadminpanel
            // 
            this.staffadminpanel.BackColor = System.Drawing.Color.Transparent;
            this.staffadminpanel.FlatAppearance.BorderSize = 0;
            this.staffadminpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffadminpanel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffadminpanel.Location = new System.Drawing.Point(6, 404);
            this.staffadminpanel.Name = "staffadminpanel";
            this.staffadminpanel.Size = new System.Drawing.Size(223, 55);
            this.staffadminpanel.TabIndex = 4;
            this.staffadminpanel.Text = "🎭  Staff";
            this.staffadminpanel.UseVisualStyleBackColor = false;
            // 
            // ALbutton
            // 
            this.ALbutton.BackColor = System.Drawing.Color.Transparent;
            this.ALbutton.FlatAppearance.BorderSize = 0;
            this.ALbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALbutton.Location = new System.Drawing.Point(40, 491);
            this.ALbutton.Name = "ALbutton";
            this.ALbutton.Size = new System.Drawing.Size(223, 55);
            this.ALbutton.TabIndex = 5;
            this.ALbutton.Text = " ⏱ Activity Log";
            this.ALbutton.UseVisualStyleBackColor = false;
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.Transparent;
            this.logoutbutton.FlatAppearance.BorderSize = 0;
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(26, 568);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(240, 72);
            this.logoutbutton.TabIndex = 6;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 593);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPanelFLP
            // 
            this.AdminPanelFLP.AutoScroll = true;
            this.AdminPanelFLP.BackColor = System.Drawing.Color.Transparent;
            this.AdminPanelFLP.Location = new System.Drawing.Point(2, 2);
            this.AdminPanelFLP.Margin = new System.Windows.Forms.Padding(2);
            this.AdminPanelFLP.Name = "AdminPanelFLP";
            this.AdminPanelFLP.Size = new System.Drawing.Size(1276, 855);
            this.AdminPanelFLP.TabIndex = 2;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 859);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label AdminPanel;
        private System.Windows.Forms.Button dbbutton;
        private System.Windows.Forms.Button adminordersbutton;
        private System.Windows.Forms.Button prodadminpanel;
        private System.Windows.Forms.Button staffadminpanel;
        private System.Windows.Forms.Button ALbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.FlowLayoutPanel AdminPanelFLP;
    }
}