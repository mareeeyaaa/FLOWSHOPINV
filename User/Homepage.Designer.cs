namespace FLOWSHOPINV
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.menupanel = new System.Windows.Forms.Panel();
            this.atcPB = new System.Windows.Forms.PictureBox();
            this.prodPB = new System.Windows.Forms.PictureBox();
            this.homePB = new System.Windows.Forms.PictureBox();
            this.optPB = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atcPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.LightPink;
            this.menupanel.Controls.Add(this.atcPB);
            this.menupanel.Controls.Add(this.prodPB);
            this.menupanel.Controls.Add(this.homePB);
            this.menupanel.Controls.Add(this.optPB);
            this.menupanel.Location = new System.Drawing.Point(1, 0);
            this.menupanel.Margin = new System.Windows.Forms.Padding(2);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(1657, 80);
            this.menupanel.TabIndex = 0;
            // 
            // atcPB
            // 
            this.atcPB.Image = ((System.Drawing.Image)(resources.GetObject("atcPB.Image")));
            this.atcPB.Location = new System.Drawing.Point(1505, 20);
            this.atcPB.Margin = new System.Windows.Forms.Padding(2);
            this.atcPB.Name = "atcPB";
            this.atcPB.Size = new System.Drawing.Size(44, 41);
            this.atcPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atcPB.TabIndex = 3;
            this.atcPB.TabStop = false;
            this.atcPB.Click += new System.EventHandler(this.atcPB_Click);
            // 
            // prodPB
            // 
            this.prodPB.Image = ((System.Drawing.Image)(resources.GetObject("prodPB.Image")));
            this.prodPB.Location = new System.Drawing.Point(1432, 20);
            this.prodPB.Margin = new System.Windows.Forms.Padding(2);
            this.prodPB.Name = "prodPB";
            this.prodPB.Size = new System.Drawing.Size(44, 41);
            this.prodPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodPB.TabIndex = 2;
            this.prodPB.TabStop = false;
            this.prodPB.Click += new System.EventHandler(this.prodPB_Click);
            // 
            // homePB
            // 
            this.homePB.Image = ((System.Drawing.Image)(resources.GetObject("homePB.Image")));
            this.homePB.Location = new System.Drawing.Point(1354, 20);
            this.homePB.Margin = new System.Windows.Forms.Padding(2);
            this.homePB.Name = "homePB";
            this.homePB.Size = new System.Drawing.Size(44, 41);
            this.homePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePB.TabIndex = 1;
            this.homePB.TabStop = false;
            this.homePB.Click += new System.EventHandler(this.homePB_Click_1);
            // 
            // optPB
            // 
            this.optPB.Image = ((System.Drawing.Image)(resources.GetObject("optPB.Image")));
            this.optPB.Location = new System.Drawing.Point(15, -25);
            this.optPB.Margin = new System.Windows.Forms.Padding(2);
            this.optPB.Name = "optPB";
            this.optPB.Size = new System.Drawing.Size(112, 123);
            this.optPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optPB.TabIndex = 0;
            this.optPB.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Location = new System.Drawing.Point(89, 110);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1487, 738);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1616, 859);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menupanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.menupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atcPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox homePB;
        private System.Windows.Forms.PictureBox optPB;
        private System.Windows.Forms.PictureBox atcPB;
        private System.Windows.Forms.PictureBox prodPB;
        private System.Windows.Forms.Panel mainPanel;
    }
}