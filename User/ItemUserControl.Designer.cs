namespace FLOWSHOPINV
{
    partial class ItemUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.itemName = new System.Windows.Forms.Label();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.Price = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.Label();
            this.prodpanel = new System.Windows.Forms.Panel();
            this.atcbutton = new System.Windows.Forms.Button();
            this.deetsbutton = new System.Windows.Forms.Button();
            this.stckbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.prodpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(87, 25);
            this.itemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(114, 23);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "Eternal Roses";
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("itemPictureBox.Image")));
            this.itemPictureBox.Location = new System.Drawing.Point(0, 2);
            this.itemPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(308, 182);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPictureBox.TabIndex = 1;
            this.itemPictureBox.TabStop = false;
            this.itemPictureBox.Click += new System.EventHandler(this.itemPictureBox_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.White;
            this.Price.Location = new System.Drawing.Point(246, 131);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(53, 18);
            this.Price.TabIndex = 3;
            this.Price.Text = "₱ 2,500";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // itemID
            // 
            this.itemID.AutoSize = true;
            this.itemID.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemID.Location = new System.Drawing.Point(106, 53);
            this.itemID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(78, 18);
            this.itemID.TabIndex = 4;
            this.itemID.Text = "Item ID: 001";
            // 
            // prodpanel
            // 
            this.prodpanel.BackColor = System.Drawing.Color.LightPink;
            this.prodpanel.Controls.Add(this.atcbutton);
            this.prodpanel.Controls.Add(this.deetsbutton);
            this.prodpanel.Controls.Add(this.itemName);
            this.prodpanel.Controls.Add(this.itemID);
            this.prodpanel.Location = new System.Drawing.Point(0, 170);
            this.prodpanel.Name = "prodpanel";
            this.prodpanel.Size = new System.Drawing.Size(320, 176);
            this.prodpanel.TabIndex = 5;
            this.prodpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.prodpanel_Paint);
            // 
            // atcbutton
            // 
            this.atcbutton.BackColor = System.Drawing.Color.Crimson;
            this.atcbutton.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atcbutton.Location = new System.Drawing.Point(24, 111);
            this.atcbutton.Name = "atcbutton";
            this.atcbutton.Size = new System.Drawing.Size(260, 27);
            this.atcbutton.TabIndex = 7;
            this.atcbutton.Text = "🛒 Add to Cart";
            this.atcbutton.UseVisualStyleBackColor = false;
            // 
            // deetsbutton
            // 
            this.deetsbutton.BackColor = System.Drawing.Color.SeaShell;
            this.deetsbutton.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deetsbutton.Location = new System.Drawing.Point(24, 78);
            this.deetsbutton.Name = "deetsbutton";
            this.deetsbutton.Size = new System.Drawing.Size(260, 27);
            this.deetsbutton.TabIndex = 6;
            this.deetsbutton.Text = "View Details";
            this.deetsbutton.UseVisualStyleBackColor = false;
            // 
            // stckbutton
            // 
            this.stckbutton.BackColor = System.Drawing.Color.PaleGreen;
            this.stckbutton.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stckbutton.Location = new System.Drawing.Point(16, 12);
            this.stckbutton.Name = "stckbutton";
            this.stckbutton.Size = new System.Drawing.Size(75, 23);
            this.stckbutton.TabIndex = 5;
            this.stckbutton.Text = "In Stock";
            this.stckbutton.UseVisualStyleBackColor = false;
            // 
            // ItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Price);
            this.Controls.Add(this.stckbutton);
            this.Controls.Add(this.prodpanel);
            this.Controls.Add(this.itemPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemUserControl";
            this.Size = new System.Drawing.Size(305, 346);
            this.Load += new System.EventHandler(this.ItemUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.prodpanel.ResumeLayout(false);
            this.prodpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.PictureBox itemPictureBox;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label itemID;
        private System.Windows.Forms.Panel prodpanel;
        private System.Windows.Forms.Button stckbutton;
        private System.Windows.Forms.Button deetsbutton;
        private System.Windows.Forms.Button atcbutton;
    }
}
