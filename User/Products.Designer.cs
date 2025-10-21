namespace FLOWSHOPINV
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.ProdFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.sitembutton = new System.Windows.Forms.Button();
            this.sitemsTB = new System.Windows.Forms.TextBox();
            this.filterpanel = new System.Windows.Forms.Panel();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.searchpanel.SuspendLayout();
            this.filterpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProdFLP
            // 
            this.ProdFLP.AutoScroll = true;
            this.ProdFLP.BackColor = System.Drawing.Color.Transparent;
            this.ProdFLP.Location = new System.Drawing.Point(-10, 72);
            this.ProdFLP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProdFLP.Name = "ProdFLP";
            this.ProdFLP.Size = new System.Drawing.Size(1469, 641);
            this.ProdFLP.TabIndex = 1;
            this.ProdFLP.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // searchpanel
            // 
            this.searchpanel.BackColor = System.Drawing.Color.LightPink;
            this.searchpanel.Controls.Add(this.filterpanel);
            this.searchpanel.Controls.Add(this.sitembutton);
            this.searchpanel.Controls.Add(this.sitemsTB);
            this.searchpanel.Location = new System.Drawing.Point(-10, 1);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(1495, 66);
            this.searchpanel.TabIndex = 2;
            // 
            // sitembutton
            // 
            this.sitembutton.BackColor = System.Drawing.Color.Crimson;
            this.sitembutton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitembutton.ForeColor = System.Drawing.Color.White;
            this.sitembutton.Location = new System.Drawing.Point(635, 21);
            this.sitembutton.Name = "sitembutton";
            this.sitembutton.Size = new System.Drawing.Size(124, 33);
            this.sitembutton.TabIndex = 1;
            this.sitembutton.Text = "⌕ Search";
            this.sitembutton.UseVisualStyleBackColor = false;
            // 
            // sitemsTB
            // 
            this.sitemsTB.Location = new System.Drawing.Point(44, 21);
            this.sitemsTB.Multiline = true;
            this.sitemsTB.Name = "sitemsTB";
            this.sitemsTB.Size = new System.Drawing.Size(582, 33);
            this.sitemsTB.TabIndex = 0;
            // 
            // filterpanel
            // 
            this.filterpanel.BackColor = System.Drawing.SystemColors.Window;
            this.filterpanel.Controls.Add(this.filterCB);
            this.filterpanel.Location = new System.Drawing.Point(828, 21);
            this.filterpanel.Name = "filterpanel";
            this.filterpanel.Size = new System.Drawing.Size(582, 33);
            this.filterpanel.TabIndex = 2;
            // 
            // filterCB
            // 
            this.filterCB.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Items.AddRange(new object[] {
            "Anniversary Collection",
            "Wedding Collection",
            "Birthday  Collection",
            "Christmas Collection",
            "New Baby Collection",
            "Congratulatory Collection",
            "Bundle Packages"});
            this.filterCB.Location = new System.Drawing.Point(1, 3);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(579, 28);
            this.filterCB.TabIndex = 0;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 705);
            this.Controls.Add(this.searchpanel);
            this.Controls.Add(this.ProdFLP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            this.filterpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ProdFLP;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.Button sitembutton;
        private System.Windows.Forms.TextBox sitemsTB;
        private System.Windows.Forms.Panel filterpanel;
        private System.Windows.Forms.ComboBox filterCB;
    }
}