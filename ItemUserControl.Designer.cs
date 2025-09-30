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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemUserControl));
            this.itemName = new System.Windows.Forms.Label();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.Label();
            this.Stocks = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(99, 172);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(53, 40);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "Name\r\n\r\n";
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("itemPictureBox.Image")));
            this.itemPictureBox.Location = new System.Drawing.Point(15, 16);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(227, 153);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPictureBox.TabIndex = 1;
            this.itemPictureBox.TabStop = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(78, 241);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(95, 20);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // Stocks
            // 
            this.Stocks.AutoSize = true;
            this.Stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stocks.Location = new System.Drawing.Point(101, 192);
            this.Stocks.Name = "Stocks";
            this.Stocks.Size = new System.Drawing.Size(51, 20);
            this.Stocks.TabIndex = 3;
            this.Stocks.Text = "Stock";
            // 
            // itemID
            // 
            this.itemID.AutoSize = true;
            this.itemID.Location = new System.Drawing.Point(12, 272);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(48, 16);
            this.itemID.TabIndex = 4;
            this.itemID.Text = "Item ID";
            // 
            // ItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.itemID);
            this.Controls.Add(this.Stocks);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.itemPictureBox);
            this.Controls.Add(this.itemName);
            this.Name = "ItemUserControl";
            this.Size = new System.Drawing.Size(260, 297);
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.PictureBox itemPictureBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Stocks;
        private System.Windows.Forms.Label itemID;
    }
}
