namespace FLOWSHOPINV.Admin
{
    partial class Admin_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Orders));
            this.orderdeetspanel = new System.Windows.Forms.Panel();
            this.btobutton = new System.Windows.Forms.Button();
            this.adorderdlbl = new System.Windows.Forms.Label();
            this.messlbl = new System.Windows.Forms.Label();
            this.orderdeetspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderdeetspanel
            // 
            this.orderdeetspanel.BackColor = System.Drawing.SystemColors.Control;
            this.orderdeetspanel.Controls.Add(this.messlbl);
            this.orderdeetspanel.Controls.Add(this.btobutton);
            this.orderdeetspanel.Controls.Add(this.adorderdlbl);
            this.orderdeetspanel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdeetspanel.Location = new System.Drawing.Point(40, 28);
            this.orderdeetspanel.Name = "orderdeetspanel";
            this.orderdeetspanel.Size = new System.Drawing.Size(1186, 82);
            this.orderdeetspanel.TabIndex = 1;
            // 
            // btobutton
            // 
            this.btobutton.BackColor = System.Drawing.Color.LightPink;
            this.btobutton.Location = new System.Drawing.Point(1031, 14);
            this.btobutton.Name = "btobutton";
            this.btobutton.Size = new System.Drawing.Size(133, 30);
            this.btobutton.TabIndex = 1;
            this.btobutton.Text = "Back to Orders";
            this.btobutton.UseVisualStyleBackColor = false;
            // 
            // adorderdlbl
            // 
            this.adorderdlbl.AutoSize = true;
            this.adorderdlbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adorderdlbl.ForeColor = System.Drawing.Color.Crimson;
            this.adorderdlbl.Location = new System.Drawing.Point(37, 12);
            this.adorderdlbl.Name = "adorderdlbl";
            this.adorderdlbl.Size = new System.Drawing.Size(79, 28);
            this.adorderdlbl.TabIndex = 0;
            this.adorderdlbl.Text = "Orders";
            // 
            // messlbl
            // 
            this.messlbl.AutoSize = true;
            this.messlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messlbl.ForeColor = System.Drawing.Color.Black;
            this.messlbl.Location = new System.Drawing.Point(38, 41);
            this.messlbl.Name = "messlbl";
            this.messlbl.Size = new System.Drawing.Size(256, 22);
            this.messlbl.TabIndex = 2;
            this.messlbl.Text = "Manage and Track customer Orders";
            // 
            // Admin_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.orderdeetspanel);
            this.Name = "Admin_Orders";
            this.Size = new System.Drawing.Size(1276, 855);
            this.orderdeetspanel.ResumeLayout(false);
            this.orderdeetspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel orderdeetspanel;
        private System.Windows.Forms.Button btobutton;
        private System.Windows.Forms.Label adorderdlbl;
        private System.Windows.Forms.Label messlbl;
    }
}
