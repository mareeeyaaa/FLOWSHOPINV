namespace FLOWSHOPINV.User
{
    partial class Items
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
            this.itemob = new System.Windows.Forms.PictureBox();
            this.itemnlbl = new System.Windows.Forms.Label();
            this.itidlbl = new System.Windows.Forms.Label();
            this.vwbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statbtn = new System.Windows.Forms.Button();
            this.prclbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemob)).BeginInit();
            this.SuspendLayout();
            // 
            // itemob
            // 
            this.itemob.Location = new System.Drawing.Point(3, 3);
            this.itemob.Name = "itemob";
            this.itemob.Size = new System.Drawing.Size(367, 208);
            this.itemob.TabIndex = 0;
            this.itemob.TabStop = false;
            // 
            // itemnlbl
            // 
            this.itemnlbl.AutoSize = true;
            this.itemnlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnlbl.Location = new System.Drawing.Point(117, 234);
            this.itemnlbl.Name = "itemnlbl";
            this.itemnlbl.Size = new System.Drawing.Size(133, 26);
            this.itemnlbl.TabIndex = 1;
            this.itemnlbl.Text = "Eternal Roses";
            // 
            // itidlbl
            // 
            this.itidlbl.AutoSize = true;
            this.itidlbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itidlbl.Location = new System.Drawing.Point(138, 274);
            this.itidlbl.Name = "itidlbl";
            this.itidlbl.Size = new System.Drawing.Size(78, 18);
            this.itidlbl.TabIndex = 2;
            this.itidlbl.Text = "Item ID: 001";
            // 
            // vwbtn
            // 
            this.vwbtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vwbtn.Location = new System.Drawing.Point(31, 303);
            this.vwbtn.Name = "vwbtn";
            this.vwbtn.Size = new System.Drawing.Size(320, 34);
            this.vwbtn.TabIndex = 3;
            this.vwbtn.Text = "View Details";
            this.vwbtn.UseVisualStyleBackColor = true;
            this.vwbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "🛒 Add to Cart";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // statbtn
            // 
            this.statbtn.BackColor = System.Drawing.Color.PaleGreen;
            this.statbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statbtn.Location = new System.Drawing.Point(31, 17);
            this.statbtn.Name = "statbtn";
            this.statbtn.Size = new System.Drawing.Size(101, 31);
            this.statbtn.TabIndex = 5;
            this.statbtn.Text = "In Stock";
            this.statbtn.UseVisualStyleBackColor = false;
            // 
            // prclbl
            // 
            this.prclbl.AutoSize = true;
            this.prclbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prclbl.ForeColor = System.Drawing.Color.White;
            this.prclbl.Location = new System.Drawing.Point(275, 170);
            this.prclbl.Name = "prclbl";
            this.prclbl.Size = new System.Drawing.Size(76, 26);
            this.prclbl.TabIndex = 6;
            this.prclbl.Text = "₱ 2,500";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.Controls.Add(this.prclbl);
            this.Controls.Add(this.statbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vwbtn);
            this.Controls.Add(this.itidlbl);
            this.Controls.Add(this.itemnlbl);
            this.Controls.Add(this.itemob);
            this.Name = "Items";
            this.Size = new System.Drawing.Size(370, 426);
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemob;
        private System.Windows.Forms.Label itemnlbl;
        private System.Windows.Forms.Label itidlbl;
        private System.Windows.Forms.Button vwbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button statbtn;
        private System.Windows.Forms.Label prclbl;
    }
}
