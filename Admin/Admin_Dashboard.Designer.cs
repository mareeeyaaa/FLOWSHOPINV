namespace FLOWSHOPINV.Admin
{
    partial class Admin_Dashboard
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
            this.AdminPanelFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AdminPanelFLP
            // 
            this.AdminPanelFLP.AutoScroll = true;
            this.AdminPanelFLP.BackColor = System.Drawing.Color.Transparent;
            this.AdminPanelFLP.Location = new System.Drawing.Point(-8, -19);
            this.AdminPanelFLP.Margin = new System.Windows.Forms.Padding(2);
            this.AdminPanelFLP.Name = "AdminPanelFLP";
            this.AdminPanelFLP.Size = new System.Drawing.Size(1271, 855);
            this.AdminPanelFLP.TabIndex = 3;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 816);
            this.Controls.Add(this.AdminPanelFLP);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin_Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AdminPanelFLP;
    }
}