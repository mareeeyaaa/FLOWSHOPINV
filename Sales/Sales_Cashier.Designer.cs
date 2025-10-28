namespace FLOWSHOPINV.Sales
{
    partial class Sales_Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Cashier));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pmpanel = new System.Windows.Forms.Panel();
            this.logoutPB = new System.Windows.Forms.PictureBox();
            this.staffuserlbl = new System.Windows.Forms.Label();
            this.lobtn = new System.Windows.Forms.Button();
            this.ssmyprofpanellbl = new System.Windows.Forms.Label();
            this.pmpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPB)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 114);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 571);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pmpanel
            // 
            this.pmpanel.BackColor = System.Drawing.SystemColors.Window;
            this.pmpanel.Controls.Add(this.logoutPB);
            this.pmpanel.Controls.Add(this.staffuserlbl);
            this.pmpanel.Controls.Add(this.lobtn);
            this.pmpanel.Controls.Add(this.ssmyprofpanellbl);
            this.pmpanel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmpanel.Location = new System.Drawing.Point(41, 34);
            this.pmpanel.Name = "pmpanel";
            this.pmpanel.Size = new System.Drawing.Size(1210, 66);
            this.pmpanel.TabIndex = 14;
            // 
            // logoutPB
            // 
            this.logoutPB.BackColor = System.Drawing.Color.LightPink;
            this.logoutPB.Image = ((System.Drawing.Image)(resources.GetObject("logoutPB.Image")));
            this.logoutPB.Location = new System.Drawing.Point(1053, 22);
            this.logoutPB.Name = "logoutPB";
            this.logoutPB.Size = new System.Drawing.Size(20, 20);
            this.logoutPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutPB.TabIndex = 8;
            this.logoutPB.TabStop = false;
            // 
            // staffuserlbl
            // 
            this.staffuserlbl.AutoSize = true;
            this.staffuserlbl.Location = new System.Drawing.Point(943, 20);
            this.staffuserlbl.Name = "staffuserlbl";
            this.staffuserlbl.Size = new System.Drawing.Size(83, 22);
            this.staffuserlbl.TabIndex = 3;
            this.staffuserlbl.Text = "Staff User";
            // 
            // lobtn
            // 
            this.lobtn.BackColor = System.Drawing.Color.LightPink;
            this.lobtn.Location = new System.Drawing.Point(1032, 12);
            this.lobtn.Name = "lobtn";
            this.lobtn.Size = new System.Drawing.Size(153, 41);
            this.lobtn.TabIndex = 2;
            this.lobtn.Text = "Logout";
            this.lobtn.UseVisualStyleBackColor = false;
            // 
            // ssmyprofpanellbl
            // 
            this.ssmyprofpanellbl.AutoSize = true;
            this.ssmyprofpanellbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssmyprofpanellbl.ForeColor = System.Drawing.Color.Crimson;
            this.ssmyprofpanellbl.Location = new System.Drawing.Point(43, 16);
            this.ssmyprofpanellbl.Name = "ssmyprofpanellbl";
            this.ssmyprofpanellbl.Size = new System.Drawing.Size(154, 28);
            this.ssmyprofpanellbl.TabIndex = 0;
            this.ssmyprofpanellbl.Text = "👤  My Profile";
            // 
            // Sales_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pmpanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Sales_Cashier";
            this.Size = new System.Drawing.Size(1276, 855);
            this.pmpanel.ResumeLayout(false);
            this.pmpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pmpanel;
        private System.Windows.Forms.PictureBox logoutPB;
        private System.Windows.Forms.Label staffuserlbl;
        private System.Windows.Forms.Button lobtn;
        private System.Windows.Forms.Label ssmyprofpanellbl;
    }
}
