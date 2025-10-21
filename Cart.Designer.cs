namespace FLOWSHOPINV
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.atcpanel = new System.Windows.Forms.Panel();
            this.sclbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemnamelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.qtylbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.actionlbl = new System.Windows.Forms.Label();
            this.contshopbutton = new System.Windows.Forms.Button();
            this.cobutton = new System.Windows.Forms.Button();
            this.atcpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atcpanel
            // 
            this.atcpanel.BackColor = System.Drawing.Color.Transparent;
            this.atcpanel.Controls.Add(this.cobutton);
            this.atcpanel.Controls.Add(this.contshopbutton);
            this.atcpanel.Controls.Add(this.panel1);
            this.atcpanel.Controls.Add(this.pictureBox1);
            this.atcpanel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atcpanel.Location = new System.Drawing.Point(-1, 2);
            this.atcpanel.Name = "atcpanel";
            this.atcpanel.Size = new System.Drawing.Size(1462, 705);
            this.atcpanel.TabIndex = 0;
            // 
            // sclbl
            // 
            this.sclbl.AutoSize = true;
            this.sclbl.BackColor = System.Drawing.Color.Transparent;
            this.sclbl.Font = new System.Drawing.Font("Palatino Linotype", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sclbl.ForeColor = System.Drawing.Color.Crimson;
            this.sclbl.Location = new System.Drawing.Point(565, 4);
            this.sclbl.Name = "sclbl";
            this.sclbl.Size = new System.Drawing.Size(239, 45);
            this.sclbl.TabIndex = 1;
            this.sclbl.Text = "Shopping Cart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.actionlbl);
            this.panel1.Controls.Add(this.totallbl);
            this.panel1.Controls.Add(this.qtylbl);
            this.panel1.Controls.Add(this.pricelbl);
            this.panel1.Controls.Add(this.itemnamelbl);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1462, 60);
            this.panel1.TabIndex = 1;
            // 
            // itemnamelbl
            // 
            this.itemnamelbl.AutoSize = true;
            this.itemnamelbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnamelbl.Location = new System.Drawing.Point(140, 22);
            this.itemnamelbl.Name = "itemnamelbl";
            this.itemnamelbl.Size = new System.Drawing.Size(45, 22);
            this.itemnamelbl.TabIndex = 2;
            this.itemnamelbl.Text = "Item";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(409, 22);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(47, 22);
            this.pricelbl.TabIndex = 3;
            this.pricelbl.Text = "Price";
            // 
            // qtylbl
            // 
            this.qtylbl.AutoSize = true;
            this.qtylbl.Location = new System.Drawing.Point(651, 22);
            this.qtylbl.Name = "qtylbl";
            this.qtylbl.Size = new System.Drawing.Size(77, 22);
            this.qtylbl.TabIndex = 4;
            this.qtylbl.Text = "Quantity";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(894, 22);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(49, 22);
            this.totallbl.TabIndex = 5;
            this.totallbl.Text = "Total";
            // 
            // actionlbl
            // 
            this.actionlbl.AutoSize = true;
            this.actionlbl.Location = new System.Drawing.Point(1162, 22);
            this.actionlbl.Name = "actionlbl";
            this.actionlbl.Size = new System.Drawing.Size(59, 22);
            this.actionlbl.TabIndex = 6;
            this.actionlbl.Text = "Action";
            // 
            // contshopbutton
            // 
            this.contshopbutton.BackColor = System.Drawing.Color.LightPink;
            this.contshopbutton.Location = new System.Drawing.Point(125, 597);
            this.contshopbutton.Name = "contshopbutton";
            this.contshopbutton.Size = new System.Drawing.Size(508, 36);
            this.contshopbutton.TabIndex = 2;
            this.contshopbutton.Text = "← Continue Shopping";
            this.contshopbutton.UseVisualStyleBackColor = false;
            // 
            // cobutton
            // 
            this.cobutton.BackColor = System.Drawing.Color.Crimson;
            this.cobutton.Location = new System.Drawing.Point(832, 588);
            this.cobutton.Name = "cobutton";
            this.cobutton.Size = new System.Drawing.Size(454, 36);
            this.cobutton.TabIndex = 3;
            this.cobutton.Text = "Proceed to Check out →";
            this.cobutton.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 699);
            this.Controls.Add(this.sclbl);
            this.Controls.Add(this.atcpanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cart";
            this.Text = "Cart";
            this.atcpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel atcpanel;
        private System.Windows.Forms.Label sclbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label actionlbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label qtylbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label itemnamelbl;
        private System.Windows.Forms.Button cobutton;
        private System.Windows.Forms.Button contshopbutton;
    }
}