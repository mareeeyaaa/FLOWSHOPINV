namespace FLOWSHOPINV
{
    partial class Login_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Panel));
            this.loginpanel = new System.Windows.Forms.Panel();
            this.loginsplt = new System.Windows.Forms.SplitContainer();
            this.btpb = new System.Windows.Forms.PictureBox();
            this.bthbutton = new System.Windows.Forms.Button();
            this.logpan = new System.Windows.Forms.Panel();
            this.loginbutton = new System.Windows.Forms.Button();
            this.forgpasslnklbl = new System.Windows.Forms.LinkLabel();
            this.remcb = new System.Windows.Forms.CheckBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.emlbl = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.regbutton = new System.Windows.Forms.Button();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginsplt)).BeginInit();
            this.loginsplt.Panel1.SuspendLayout();
            this.loginsplt.Panel2.SuspendLayout();
            this.loginsplt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btpb)).BeginInit();
            this.logpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.loginsplt);
            this.loginpanel.Location = new System.Drawing.Point(337, 176);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(2);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(1020, 579);
            this.loginpanel.TabIndex = 0;
            // 
            // loginsplt
            // 
            this.loginsplt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginsplt.Location = new System.Drawing.Point(0, 0);
            this.loginsplt.Margin = new System.Windows.Forms.Padding(2);
            this.loginsplt.Name = "loginsplt";
            // 
            // loginsplt.Panel1
            // 
            this.loginsplt.Panel1.BackColor = System.Drawing.Color.LightCoral;
            this.loginsplt.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginsplt.Panel1.BackgroundImage")));
            this.loginsplt.Panel1.Controls.Add(this.btpb);
            this.loginsplt.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // loginsplt.Panel2
            // 
            this.loginsplt.Panel2.BackColor = System.Drawing.Color.Pink;
            this.loginsplt.Panel2.Controls.Add(this.bthbutton);
            this.loginsplt.Panel2.Controls.Add(this.logpan);
            this.loginsplt.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.loginsplt_Panel2_Paint);
            this.loginsplt.Size = new System.Drawing.Size(1020, 579);
            this.loginsplt.SplitterDistance = 374;
            this.loginsplt.SplitterWidth = 3;
            this.loginsplt.TabIndex = 0;
            // 
            // btpb
            // 
            this.btpb.BackColor = System.Drawing.Color.Transparent;
            this.btpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btpb.Image = ((System.Drawing.Image)(resources.GetObject("btpb.Image")));
            this.btpb.Location = new System.Drawing.Point(-35, 47);
            this.btpb.Margin = new System.Windows.Forms.Padding(2);
            this.btpb.Name = "btpb";
            this.btpb.Size = new System.Drawing.Size(429, 437);
            this.btpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btpb.TabIndex = 0;
            this.btpb.TabStop = false;
            // 
            // bthbutton
            // 
            this.bthbutton.BackColor = System.Drawing.Color.LightCoral;
            this.bthbutton.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthbutton.Location = new System.Drawing.Point(43, 442);
            this.bthbutton.Margin = new System.Windows.Forms.Padding(2);
            this.bthbutton.Name = "bthbutton";
            this.bthbutton.Size = new System.Drawing.Size(519, 37);
            this.bthbutton.TabIndex = 1;
            this.bthbutton.Text = "Back to Home";
            this.bthbutton.UseVisualStyleBackColor = false;
            // 
            // logpan
            // 
            this.logpan.BackColor = System.Drawing.Color.Snow;
            this.logpan.Controls.Add(this.loginbutton);
            this.logpan.Controls.Add(this.regbutton);
            this.logpan.Controls.Add(this.forgpasslnklbl);
            this.logpan.Controls.Add(this.remcb);
            this.logpan.Controls.Add(this.passlbl);
            this.logpan.Controls.Add(this.emlbl);
            this.logpan.Controls.Add(this.passTB);
            this.logpan.Controls.Add(this.emailTB);
            this.logpan.Location = new System.Drawing.Point(43, 58);
            this.logpan.Margin = new System.Windows.Forms.Padding(2);
            this.logpan.Name = "logpan";
            this.logpan.Size = new System.Drawing.Size(519, 349);
            this.logpan.TabIndex = 0;
            this.logpan.Paint += new System.Windows.Forms.PaintEventHandler(this.logpan_Paint);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Crimson;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbutton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(23, 268);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(471, 37);
            this.loginbutton.TabIndex = 7;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            // 
            // forgpasslnklbl
            // 
            this.forgpasslnklbl.AutoSize = true;
            this.forgpasslnklbl.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgpasslnklbl.LinkColor = System.Drawing.Color.Red;
            this.forgpasslnklbl.Location = new System.Drawing.Point(350, 165);
            this.forgpasslnklbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgpasslnklbl.Name = "forgpasslnklbl";
            this.forgpasslnklbl.Size = new System.Drawing.Size(108, 17);
            this.forgpasslnklbl.TabIndex = 5;
            this.forgpasslnklbl.TabStop = true;
            this.forgpasslnklbl.Text = "Forgot Password?";
            // 
            // remcb
            // 
            this.remcb.AutoSize = true;
            this.remcb.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remcb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remcb.Location = new System.Drawing.Point(23, 164);
            this.remcb.Margin = new System.Windows.Forms.Padding(2);
            this.remcb.Name = "remcb";
            this.remcb.Size = new System.Drawing.Size(143, 21);
            this.remcb.TabIndex = 4;
            this.remcb.Text = "Remember Password";
            this.remcb.UseVisualStyleBackColor = true;
            this.remcb.CheckedChanged += new System.EventHandler(this.remcb_CheckedChanged);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(19, 89);
            this.passlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(79, 21);
            this.passlbl.TabIndex = 3;
            this.passlbl.Text = "Password";
            this.passlbl.Click += new System.EventHandler(this.passlbl_Click);
            // 
            // emlbl
            // 
            this.emlbl.AutoSize = true;
            this.emlbl.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emlbl.Location = new System.Drawing.Point(19, 12);
            this.emlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emlbl.Name = "emlbl";
            this.emlbl.Size = new System.Drawing.Size(50, 21);
            this.emlbl.TabIndex = 2;
            this.emlbl.Text = "Email";
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passTB.Location = new System.Drawing.Point(22, 119);
            this.passTB.Margin = new System.Windows.Forms.Padding(2);
            this.passTB.Multiline = true;
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(472, 30);
            this.passTB.TabIndex = 1;
            this.passTB.TextChanged += new System.EventHandler(this.passTB_TextChanged);
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.emailTB.Location = new System.Drawing.Point(22, 49);
            this.emailTB.Margin = new System.Windows.Forms.Padding(2);
            this.emailTB.Multiline = true;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(472, 30);
            this.emailTB.TabIndex = 0;
            // 
            // regbutton
            // 
            this.regbutton.BackColor = System.Drawing.Color.LightPink;
            this.regbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regbutton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbutton.Location = new System.Drawing.Point(22, 215);
            this.regbutton.Margin = new System.Windows.Forms.Padding(2);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(472, 37);
            this.regbutton.TabIndex = 6;
            this.regbutton.Text = "Register";
            this.regbutton.UseVisualStyleBackColor = false;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // Login_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1616, 859);
            this.Controls.Add(this.loginpanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Panel_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginsplt.Panel1.ResumeLayout(false);
            this.loginsplt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginsplt)).EndInit();
            this.loginsplt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btpb)).EndInit();
            this.logpan.ResumeLayout(false);
            this.logpan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.SplitContainer loginsplt;
        private System.Windows.Forms.Panel logpan;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label emlbl;
        private System.Windows.Forms.CheckBox remcb;
        private System.Windows.Forms.LinkLabel forgpasslnklbl;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button bthbutton;
        private System.Windows.Forms.PictureBox btpb;
        private System.Windows.Forms.Button regbutton;
    }
}

