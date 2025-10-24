namespace FLOWSHOPINV.Admin
{
    partial class Update_Order_Status
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Order_Status));
            this.updordstatpanel = new System.Windows.Forms.Panel();
            this.btobutton = new System.Windows.Forms.Button();
            this.updordstatpanellbl = new System.Windows.Forms.Label();
            this.orderdeetsprodpanel = new System.Windows.Forms.Panel();
            this.orderproddeetspanel = new System.Windows.Forms.Panel();
            this.orderidpanel = new System.Windows.Forms.Panel();
            this.customerpanel = new System.Windows.Forms.Panel();
            this.emailpanel = new System.Windows.Forms.Panel();
            this.currentstatpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderidTB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customerTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.currentstatTB = new System.Windows.Forms.TextBox();
            this.adminnorderidbl = new System.Windows.Forms.Label();
            this.admincustomerlbl = new System.Windows.Forms.Label();
            this.adminemaillbl = new System.Windows.Forms.Label();
            this.currentstatuslbl = new System.Windows.Forms.Label();
            this.ordid = new System.Windows.Forms.Label();
            this.custname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.statbutton = new System.Windows.Forms.Button();
            this.newstatTB = new System.Windows.Forms.TextBox();
            this.Orderinfolbl = new System.Windows.Forms.Label();
            this.updatestatlbl = new System.Windows.Forms.Label();
            this.newstatlbl = new System.Windows.Forms.Label();
            this.notesTB = new System.Windows.Forms.TextBox();
            this.noteslbl = new System.Windows.Forms.Label();
            this.updatestatbutton = new System.Windows.Forms.Button();
            this.updordstatpanel.SuspendLayout();
            this.orderdeetsprodpanel.SuspendLayout();
            this.orderproddeetspanel.SuspendLayout();
            this.customerpanel.SuspendLayout();
            this.emailpanel.SuspendLayout();
            this.currentstatpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updordstatpanel
            // 
            this.updordstatpanel.BackColor = System.Drawing.SystemColors.Control;
            this.updordstatpanel.Controls.Add(this.btobutton);
            this.updordstatpanel.Controls.Add(this.updordstatpanellbl);
            this.updordstatpanel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updordstatpanel.Location = new System.Drawing.Point(48, 46);
            this.updordstatpanel.Name = "updordstatpanel";
            this.updordstatpanel.Size = new System.Drawing.Size(1186, 57);
            this.updordstatpanel.TabIndex = 1;
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
            // updordstatpanellbl
            // 
            this.updordstatpanellbl.AutoSize = true;
            this.updordstatpanellbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updordstatpanellbl.ForeColor = System.Drawing.Color.Crimson;
            this.updordstatpanellbl.Location = new System.Drawing.Point(43, 13);
            this.updordstatpanellbl.Name = "updordstatpanellbl";
            this.updordstatpanellbl.Size = new System.Drawing.Size(212, 28);
            this.updordstatpanellbl.TabIndex = 0;
            this.updordstatpanellbl.Text = "Update Order Status";
            // 
            // orderdeetsprodpanel
            // 
            this.orderdeetsprodpanel.BackColor = System.Drawing.SystemColors.Control;
            this.orderdeetsprodpanel.Controls.Add(this.updatestatbutton);
            this.orderdeetsprodpanel.Controls.Add(this.noteslbl);
            this.orderdeetsprodpanel.Controls.Add(this.notesTB);
            this.orderdeetsprodpanel.Controls.Add(this.newstatlbl);
            this.orderdeetsprodpanel.Controls.Add(this.updatestatlbl);
            this.orderdeetsprodpanel.Controls.Add(this.Orderinfolbl);
            this.orderdeetsprodpanel.Controls.Add(this.newstatTB);
            this.orderdeetsprodpanel.Controls.Add(this.panel1);
            this.orderdeetsprodpanel.Controls.Add(this.customerpanel);
            this.orderdeetsprodpanel.Controls.Add(this.orderproddeetspanel);
            this.orderdeetsprodpanel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdeetsprodpanel.Location = new System.Drawing.Point(48, 140);
            this.orderdeetsprodpanel.Name = "orderdeetsprodpanel";
            this.orderdeetsprodpanel.Size = new System.Drawing.Size(1186, 365);
            this.orderdeetsprodpanel.TabIndex = 3;
            // 
            // orderproddeetspanel
            // 
            this.orderproddeetspanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderproddeetspanel.Controls.Add(this.statbutton);
            this.orderproddeetspanel.Controls.Add(this.email);
            this.orderproddeetspanel.Controls.Add(this.custname);
            this.orderproddeetspanel.Controls.Add(this.ordid);
            this.orderproddeetspanel.Controls.Add(this.currentstatTB);
            this.orderproddeetspanel.Controls.Add(this.emailTB);
            this.orderproddeetspanel.Controls.Add(this.customerTB);
            this.orderproddeetspanel.Controls.Add(this.orderidTB);
            this.orderproddeetspanel.Controls.Add(this.currentstatpanel);
            this.orderproddeetspanel.Controls.Add(this.emailpanel);
            this.orderproddeetspanel.Controls.Add(this.orderidpanel);
            this.orderproddeetspanel.Location = new System.Drawing.Point(32, 59);
            this.orderproddeetspanel.Name = "orderproddeetspanel";
            this.orderproddeetspanel.Size = new System.Drawing.Size(550, 271);
            this.orderproddeetspanel.TabIndex = 9;
            // 
            // orderidpanel
            // 
            this.orderidpanel.Location = new System.Drawing.Point(-4, -1);
            this.orderidpanel.Name = "orderidpanel";
            this.orderidpanel.Size = new System.Drawing.Size(248, 67);
            this.orderidpanel.TabIndex = 0;
            // 
            // customerpanel
            // 
            this.customerpanel.BackColor = System.Drawing.Color.LightPink;
            this.customerpanel.Controls.Add(this.admincustomerlbl);
            this.customerpanel.Location = new System.Drawing.Point(32, 127);
            this.customerpanel.Name = "customerpanel";
            this.customerpanel.Size = new System.Drawing.Size(245, 67);
            this.customerpanel.TabIndex = 1;
            // 
            // emailpanel
            // 
            this.emailpanel.BackColor = System.Drawing.Color.LightPink;
            this.emailpanel.Controls.Add(this.adminemaillbl);
            this.emailpanel.Location = new System.Drawing.Point(-2, 133);
            this.emailpanel.Name = "emailpanel";
            this.emailpanel.Size = new System.Drawing.Size(245, 67);
            this.emailpanel.TabIndex = 1;
            // 
            // currentstatpanel
            // 
            this.currentstatpanel.BackColor = System.Drawing.Color.LightPink;
            this.currentstatpanel.Controls.Add(this.currentstatuslbl);
            this.currentstatpanel.Location = new System.Drawing.Point(-2, 200);
            this.currentstatpanel.Name = "currentstatpanel";
            this.currentstatpanel.Size = new System.Drawing.Size(246, 67);
            this.currentstatpanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.adminnorderidbl);
            this.panel1.Location = new System.Drawing.Point(32, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 67);
            this.panel1.TabIndex = 1;
            // 
            // orderidTB
            // 
            this.orderidTB.BackColor = System.Drawing.SystemColors.Control;
            this.orderidTB.Location = new System.Drawing.Point(243, -1);
            this.orderidTB.Multiline = true;
            this.orderidTB.Name = "orderidTB";
            this.orderidTB.Size = new System.Drawing.Size(302, 67);
            this.orderidTB.TabIndex = 2;
            this.orderidTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // customerTB
            // 
            this.customerTB.BackColor = System.Drawing.SystemColors.Control;
            this.customerTB.Location = new System.Drawing.Point(242, 66);
            this.customerTB.Multiline = true;
            this.customerTB.Name = "customerTB";
            this.customerTB.Size = new System.Drawing.Size(303, 67);
            this.customerTB.TabIndex = 3;
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.SystemColors.Control;
            this.emailTB.Location = new System.Drawing.Point(243, 133);
            this.emailTB.Multiline = true;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(302, 67);
            this.emailTB.TabIndex = 4;
            // 
            // currentstatTB
            // 
            this.currentstatTB.BackColor = System.Drawing.SystemColors.Control;
            this.currentstatTB.Location = new System.Drawing.Point(243, 200);
            this.currentstatTB.Multiline = true;
            this.currentstatTB.Name = "currentstatTB";
            this.currentstatTB.Size = new System.Drawing.Size(302, 67);
            this.currentstatTB.TabIndex = 5;
            // 
            // adminnorderidbl
            // 
            this.adminnorderidbl.AutoSize = true;
            this.adminnorderidbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnorderidbl.Location = new System.Drawing.Point(23, 22);
            this.adminnorderidbl.Name = "adminnorderidbl";
            this.adminnorderidbl.Size = new System.Drawing.Size(82, 22);
            this.adminnorderidbl.TabIndex = 10;
            this.adminnorderidbl.Text = "Order ID:";
            // 
            // admincustomerlbl
            // 
            this.admincustomerlbl.AutoSize = true;
            this.admincustomerlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admincustomerlbl.Location = new System.Drawing.Point(23, 26);
            this.admincustomerlbl.Name = "admincustomerlbl";
            this.admincustomerlbl.Size = new System.Drawing.Size(88, 22);
            this.admincustomerlbl.TabIndex = 11;
            this.admincustomerlbl.Text = "Customer:";
            // 
            // adminemaillbl
            // 
            this.adminemaillbl.AutoSize = true;
            this.adminemaillbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminemaillbl.Location = new System.Drawing.Point(23, 24);
            this.adminemaillbl.Name = "adminemaillbl";
            this.adminemaillbl.Size = new System.Drawing.Size(57, 22);
            this.adminemaillbl.TabIndex = 12;
            this.adminemaillbl.Text = "Email:";
            // 
            // currentstatuslbl
            // 
            this.currentstatuslbl.AutoSize = true;
            this.currentstatuslbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentstatuslbl.Location = new System.Drawing.Point(23, 19);
            this.currentstatuslbl.Name = "currentstatuslbl";
            this.currentstatuslbl.Size = new System.Drawing.Size(125, 22);
            this.currentstatuslbl.TabIndex = 13;
            this.currentstatuslbl.Text = "Current Status:";
            // 
            // ordid
            // 
            this.ordid.AutoSize = true;
            this.ordid.BackColor = System.Drawing.SystemColors.Control;
            this.ordid.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordid.Location = new System.Drawing.Point(280, 26);
            this.ordid.Name = "ordid";
            this.ordid.Size = new System.Drawing.Size(89, 16);
            this.ordid.TabIndex = 6;
            this.ordid.Text = "SPR4K9T82L";
            // 
            // custname
            // 
            this.custname.AutoSize = true;
            this.custname.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custname.Location = new System.Drawing.Point(280, 98);
            this.custname.Name = "custname";
            this.custname.Size = new System.Drawing.Size(62, 16);
            this.custname.TabIndex = 16;
            this.custname.Text = "John Doe";
            this.custname.Click += new System.EventHandler(this.custname_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(280, 157);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(124, 16);
            this.email.TabIndex = 17;
            this.email.Text = "doejohn@gmail.com";
            // 
            // statbutton
            // 
            this.statbutton.BackColor = System.Drawing.Color.Gold;
            this.statbutton.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statbutton.Location = new System.Drawing.Point(283, 218);
            this.statbutton.Name = "statbutton";
            this.statbutton.Size = new System.Drawing.Size(75, 23);
            this.statbutton.TabIndex = 19;
            this.statbutton.Text = "Done";
            this.statbutton.UseVisualStyleBackColor = false;
            // 
            // newstatTB
            // 
            this.newstatTB.BackColor = System.Drawing.SystemColors.Control;
            this.newstatTB.Location = new System.Drawing.Point(628, 89);
            this.newstatTB.Multiline = true;
            this.newstatTB.Name = "newstatTB";
            this.newstatTB.Size = new System.Drawing.Size(512, 50);
            this.newstatTB.TabIndex = 20;
            // 
            // Orderinfolbl
            // 
            this.Orderinfolbl.AutoSize = true;
            this.Orderinfolbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderinfolbl.Location = new System.Drawing.Point(44, 20);
            this.Orderinfolbl.Name = "Orderinfolbl";
            this.Orderinfolbl.Size = new System.Drawing.Size(150, 22);
            this.Orderinfolbl.TabIndex = 11;
            this.Orderinfolbl.Text = "Order Information";
            // 
            // updatestatlbl
            // 
            this.updatestatlbl.AutoSize = true;
            this.updatestatlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestatlbl.Location = new System.Drawing.Point(624, 20);
            this.updatestatlbl.Name = "updatestatlbl";
            this.updatestatlbl.Size = new System.Drawing.Size(115, 22);
            this.updatestatlbl.TabIndex = 21;
            this.updatestatlbl.Text = "Update Status";
            // 
            // newstatlbl
            // 
            this.newstatlbl.AutoSize = true;
            this.newstatlbl.BackColor = System.Drawing.SystemColors.Control;
            this.newstatlbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newstatlbl.Location = new System.Drawing.Point(625, 62);
            this.newstatlbl.Name = "newstatlbl";
            this.newstatlbl.Size = new System.Drawing.Size(77, 18);
            this.newstatlbl.TabIndex = 20;
            this.newstatlbl.Text = "New Status";
            // 
            // notesTB
            // 
            this.notesTB.BackColor = System.Drawing.SystemColors.Control;
            this.notesTB.Location = new System.Drawing.Point(628, 183);
            this.notesTB.Multiline = true;
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(512, 96);
            this.notesTB.TabIndex = 22;
            // 
            // noteslbl
            // 
            this.noteslbl.AutoSize = true;
            this.noteslbl.BackColor = System.Drawing.SystemColors.Control;
            this.noteslbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteslbl.Location = new System.Drawing.Point(625, 155);
            this.noteslbl.Name = "noteslbl";
            this.noteslbl.Size = new System.Drawing.Size(115, 18);
            this.noteslbl.TabIndex = 23;
            this.noteslbl.Text = "Notes ( Optional )";
            // 
            // updatestatbutton
            // 
            this.updatestatbutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.updatestatbutton.Location = new System.Drawing.Point(628, 300);
            this.updatestatbutton.Name = "updatestatbutton";
            this.updatestatbutton.Size = new System.Drawing.Size(133, 30);
            this.updatestatbutton.TabIndex = 2;
            this.updatestatbutton.Text = "Update Status";
            this.updatestatbutton.UseVisualStyleBackColor = false;
            // 
            // Update_Order_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.orderdeetsprodpanel);
            this.Controls.Add(this.updordstatpanel);
            this.Name = "Update_Order_Status";
            this.Size = new System.Drawing.Size(1276, 855);
            this.updordstatpanel.ResumeLayout(false);
            this.updordstatpanel.PerformLayout();
            this.orderdeetsprodpanel.ResumeLayout(false);
            this.orderdeetsprodpanel.PerformLayout();
            this.orderproddeetspanel.ResumeLayout(false);
            this.orderproddeetspanel.PerformLayout();
            this.customerpanel.ResumeLayout(false);
            this.customerpanel.PerformLayout();
            this.emailpanel.ResumeLayout(false);
            this.emailpanel.PerformLayout();
            this.currentstatpanel.ResumeLayout(false);
            this.currentstatpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updordstatpanel;
        private System.Windows.Forms.Button btobutton;
        private System.Windows.Forms.Label updordstatpanellbl;
        private System.Windows.Forms.Panel orderdeetsprodpanel;
        private System.Windows.Forms.Panel orderproddeetspanel;
        private System.Windows.Forms.Panel orderidpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel customerpanel;
        private System.Windows.Forms.TextBox orderidTB;
        private System.Windows.Forms.Panel currentstatpanel;
        private System.Windows.Forms.Panel emailpanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox currentstatTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox customerTB;
        private System.Windows.Forms.Label adminnorderidbl;
        private System.Windows.Forms.Label admincustomerlbl;
        private System.Windows.Forms.Label currentstatuslbl;
        private System.Windows.Forms.Label adminemaillbl;
        private System.Windows.Forms.Label ordid;
        private System.Windows.Forms.Label custname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label noteslbl;
        private System.Windows.Forms.TextBox notesTB;
        private System.Windows.Forms.Label newstatlbl;
        private System.Windows.Forms.Label updatestatlbl;
        private System.Windows.Forms.Label Orderinfolbl;
        private System.Windows.Forms.TextBox newstatTB;
        private System.Windows.Forms.Button statbutton;
        private System.Windows.Forms.Button updatestatbutton;
    }
}
