﻿namespace FLOWSHOPINV
{
    partial class Homepage_Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage_Landing));
            this.lpmenupanel = new System.Windows.Forms.Panel();
            this.lpPB = new System.Windows.Forms.PictureBox();
            this.abbtbtn = new System.Windows.Forms.Button();
            this.gstarbtn = new System.Windows.Forms.Button();
            this.admandstaffportalbtn = new System.Windows.Forms.Button();
            this.LPmainPanel = new System.Windows.Forms.Panel();
            this.lpmenupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lpPB)).BeginInit();
            this.SuspendLayout();
            // 
            // lpmenupanel
            // 
            this.lpmenupanel.BackColor = System.Drawing.Color.LightPink;
            this.lpmenupanel.Controls.Add(this.LPmainPanel);
            this.lpmenupanel.Controls.Add(this.admandstaffportalbtn);
            this.lpmenupanel.Controls.Add(this.gstarbtn);
            this.lpmenupanel.Controls.Add(this.abbtbtn);
            this.lpmenupanel.Controls.Add(this.lpPB);
            this.lpmenupanel.Location = new System.Drawing.Point(-2, 1);
            this.lpmenupanel.Margin = new System.Windows.Forms.Padding(2);
            this.lpmenupanel.Name = "lpmenupanel";
            this.lpmenupanel.Size = new System.Drawing.Size(1657, 80);
            this.lpmenupanel.TabIndex = 1;
            // 
            // lpPB
            // 
            this.lpPB.Image = ((System.Drawing.Image)(resources.GetObject("lpPB.Image")));
            this.lpPB.Location = new System.Drawing.Point(72, -28);
            this.lpPB.Margin = new System.Windows.Forms.Padding(2);
            this.lpPB.Name = "lpPB";
            this.lpPB.Size = new System.Drawing.Size(112, 123);
            this.lpPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lpPB.TabIndex = 0;
            this.lpPB.TabStop = false;
            // 
            // abbtbtn
            // 
            this.abbtbtn.BackColor = System.Drawing.Color.Pink;
            this.abbtbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abbtbtn.Location = new System.Drawing.Point(840, 27);
            this.abbtbtn.Name = "abbtbtn";
            this.abbtbtn.Size = new System.Drawing.Size(124, 34);
            this.abbtbtn.TabIndex = 1;
            this.abbtbtn.Text = "About";
            this.abbtbtn.UseVisualStyleBackColor = false;
            // 
            // gstarbtn
            // 
            this.gstarbtn.BackColor = System.Drawing.Color.Pink;
            this.gstarbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstarbtn.Location = new System.Drawing.Point(982, 27);
            this.gstarbtn.Name = "gstarbtn";
            this.gstarbtn.Size = new System.Drawing.Size(124, 34);
            this.gstarbtn.TabIndex = 2;
            this.gstarbtn.Text = "Get Started";
            this.gstarbtn.UseVisualStyleBackColor = false;
            // 
            // admandstaffportalbtn
            // 
            this.admandstaffportalbtn.BackColor = System.Drawing.Color.Pink;
            this.admandstaffportalbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admandstaffportalbtn.Location = new System.Drawing.Point(1125, 27);
            this.admandstaffportalbtn.Name = "admandstaffportalbtn";
            this.admandstaffportalbtn.Size = new System.Drawing.Size(221, 34);
            this.admandstaffportalbtn.TabIndex = 3;
            this.admandstaffportalbtn.Text = "🔒 Admin and Staff Portal";
            this.admandstaffportalbtn.UseVisualStyleBackColor = false;
            // 
            // LPmainPanel
            // 
            this.LPmainPanel.BackColor = System.Drawing.Color.Transparent;
            this.LPmainPanel.Location = new System.Drawing.Point(2, 82);
            this.LPmainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LPmainPanel.Name = "LPmainPanel";
            this.LPmainPanel.Size = new System.Drawing.Size(1615, 779);
            this.LPmainPanel.TabIndex = 4;
            // 
            // Homepage_Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1616, 859);
            this.Controls.Add(this.lpmenupanel);
            this.Name = "Homepage_Landing";
            this.Text = "Homepage_Landing";
            this.lpmenupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lpPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lpmenupanel;
        private System.Windows.Forms.PictureBox lpPB;
        private System.Windows.Forms.Button admandstaffportalbtn;
        private System.Windows.Forms.Button gstarbtn;
        private System.Windows.Forms.Button abbtbtn;
        private System.Windows.Forms.Panel LPmainPanel;
    }
}