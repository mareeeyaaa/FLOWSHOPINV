namespace FLOWSHOPINV.Inventory
{
    partial class Inventory_View_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_View_Products));
            this.isinvsc = new System.Windows.Forms.Splitter();
            this.isinvpb = new System.Windows.Forms.PictureBox();
            this.isctglbl = new System.Windows.Forms.Label();
            this.isprodnamelbl = new System.Windows.Forms.Label();
            this.issttlbl = new System.Windows.Forms.Label();
            this.isdcrplbl = new System.Windows.Forms.Label();
            this.isquanlbl = new System.Windows.Forms.Label();
            this.isinprc1lbl = new System.Windows.Forms.Label();
            this.isinvcateg1lbl = new System.Windows.Forms.Label();
            this.isiinvtem1lbl = new System.Windows.Forms.Label();
            this.isinvstat1btn = new System.Windows.Forms.Button();
            this.qtynumlbl = new System.Windows.Forms.Label();
            this.isinvdesclbl = new System.Windows.Forms.Label();
            this.isinvclosebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.isinvpb)).BeginInit();
            this.SuspendLayout();
            // 
            // isinvsc
            // 
            this.isinvsc.BackColor = System.Drawing.Color.PaleVioletRed;
            this.isinvsc.Location = new System.Drawing.Point(0, 0);
            this.isinvsc.Name = "isinvsc";
            this.isinvsc.Size = new System.Drawing.Size(294, 414);
            this.isinvsc.TabIndex = 0;
            this.isinvsc.TabStop = false;
            this.isinvsc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.isinvsc_SplitterMoved);
            // 
            // isinvpb
            // 
            this.isinvpb.BackColor = System.Drawing.Color.PaleVioletRed;
            this.isinvpb.Image = ((System.Drawing.Image)(resources.GetObject("isinvpb.Image")));
            this.isinvpb.Location = new System.Drawing.Point(15, 34);
            this.isinvpb.Name = "isinvpb";
            this.isinvpb.Size = new System.Drawing.Size(264, 313);
            this.isinvpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.isinvpb.TabIndex = 1;
            this.isinvpb.TabStop = false;
            this.isinvpb.Click += new System.EventHandler(this.isinvpb_Click);
            // 
            // isctglbl
            // 
            this.isctglbl.AutoSize = true;
            this.isctglbl.BackColor = System.Drawing.Color.Pink;
            this.isctglbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isctglbl.Location = new System.Drawing.Point(306, 34);
            this.isctglbl.Name = "isctglbl";
            this.isctglbl.Size = new System.Drawing.Size(82, 22);
            this.isctglbl.TabIndex = 33;
            this.isctglbl.Text = "Category:";
            this.isctglbl.Click += new System.EventHandler(this.isctglbl_Click);
            // 
            // isprodnamelbl
            // 
            this.isprodnamelbl.AutoSize = true;
            this.isprodnamelbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.isprodnamelbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isprodnamelbl.Location = new System.Drawing.Point(12, 361);
            this.isprodnamelbl.Name = "isprodnamelbl";
            this.isprodnamelbl.Size = new System.Drawing.Size(146, 26);
            this.isprodnamelbl.TabIndex = 28;
            this.isprodnamelbl.Text = "Product Name:";
            this.isprodnamelbl.Click += new System.EventHandler(this.isprodnamelbl_Click);
            // 
            // issttlbl
            // 
            this.issttlbl.AutoSize = true;
            this.issttlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issttlbl.Location = new System.Drawing.Point(306, 263);
            this.issttlbl.Name = "issttlbl";
            this.issttlbl.Size = new System.Drawing.Size(61, 22);
            this.issttlbl.TabIndex = 38;
            this.issttlbl.Text = "Status:";
            this.issttlbl.Click += new System.EventHandler(this.issttlbl_Click);
            // 
            // isdcrplbl
            // 
            this.isdcrplbl.AutoSize = true;
            this.isdcrplbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isdcrplbl.Location = new System.Drawing.Point(306, 140);
            this.isdcrplbl.Name = "isdcrplbl";
            this.isdcrplbl.Size = new System.Drawing.Size(101, 22);
            this.isdcrplbl.TabIndex = 37;
            this.isdcrplbl.Text = "Description:";
            this.isdcrplbl.Click += new System.EventHandler(this.isdcrplbl_Click);
            // 
            // isquanlbl
            // 
            this.isquanlbl.AutoSize = true;
            this.isquanlbl.BackColor = System.Drawing.Color.Pink;
            this.isquanlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isquanlbl.Location = new System.Drawing.Point(306, 103);
            this.isquanlbl.Name = "isquanlbl";
            this.isquanlbl.Size = new System.Drawing.Size(81, 22);
            this.isquanlbl.TabIndex = 34;
            this.isquanlbl.Text = "Quantity:";
            this.isquanlbl.Click += new System.EventHandler(this.isquanlbl_Click);
            // 
            // isinprc1lbl
            // 
            this.isinprc1lbl.AutoSize = true;
            this.isinprc1lbl.BackColor = System.Drawing.Color.White;
            this.isinprc1lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isinprc1lbl.Location = new System.Drawing.Point(207, 316);
            this.isinprc1lbl.Name = "isinprc1lbl";
            this.isinprc1lbl.Size = new System.Drawing.Size(59, 18);
            this.isinprc1lbl.TabIndex = 41;
            this.isinprc1lbl.Text = "₱ 2,500";
            this.isinprc1lbl.Click += new System.EventHandler(this.isinprc1lbl_Click);
            // 
            // isinvcateg1lbl
            // 
            this.isinvcateg1lbl.AutoSize = true;
            this.isinvcateg1lbl.BackColor = System.Drawing.Color.Pink;
            this.isinvcateg1lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isinvcateg1lbl.Location = new System.Drawing.Point(306, 69);
            this.isinvcateg1lbl.Name = "isinvcateg1lbl";
            this.isinvcateg1lbl.Size = new System.Drawing.Size(174, 20);
            this.isinvcateg1lbl.TabIndex = 40;
            this.isinvcateg1lbl.Text = "Anniversary Collection";
            this.isinvcateg1lbl.Click += new System.EventHandler(this.isinvcateg1lbl_Click);
            // 
            // isiinvtem1lbl
            // 
            this.isiinvtem1lbl.AutoSize = true;
            this.isiinvtem1lbl.BackColor = System.Drawing.Color.PaleVioletRed;
            this.isiinvtem1lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isiinvtem1lbl.Location = new System.Drawing.Point(164, 363);
            this.isiinvtem1lbl.Name = "isiinvtem1lbl";
            this.isiinvtem1lbl.Size = new System.Drawing.Size(98, 20);
            this.isiinvtem1lbl.TabIndex = 39;
            this.isiinvtem1lbl.Text = "Eternal Rose";
            this.isiinvtem1lbl.Click += new System.EventHandler(this.isiinvtem1lbl_Click);
            // 
            // isinvstat1btn
            // 
            this.isinvstat1btn.BackColor = System.Drawing.Color.Lime;
            this.isinvstat1btn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isinvstat1btn.Location = new System.Drawing.Point(373, 265);
            this.isinvstat1btn.Name = "isinvstat1btn";
            this.isinvstat1btn.Size = new System.Drawing.Size(75, 23);
            this.isinvstat1btn.TabIndex = 43;
            this.isinvstat1btn.Text = "Active";
            this.isinvstat1btn.UseVisualStyleBackColor = false;
            this.isinvstat1btn.Click += new System.EventHandler(this.isinvstat1btn_Click);
            // 
            // qtynumlbl
            // 
            this.qtynumlbl.AutoSize = true;
            this.qtynumlbl.BackColor = System.Drawing.Color.Pink;
            this.qtynumlbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtynumlbl.Location = new System.Drawing.Point(393, 105);
            this.qtynumlbl.Name = "qtynumlbl";
            this.qtynumlbl.Size = new System.Drawing.Size(33, 20);
            this.qtynumlbl.TabIndex = 42;
            this.qtynumlbl.Text = "200";
            this.qtynumlbl.Click += new System.EventHandler(this.qtynumlbl_Click);
            // 
            // isinvdesclbl
            // 
            this.isinvdesclbl.AutoSize = true;
            this.isinvdesclbl.BackColor = System.Drawing.Color.Pink;
            this.isinvdesclbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isinvdesclbl.Location = new System.Drawing.Point(316, 171);
            this.isinvdesclbl.Name = "isinvdesclbl";
            this.isinvdesclbl.Size = new System.Drawing.Size(144, 80);
            this.isinvdesclbl.TabIndex = 44;
            this.isinvdesclbl.Text = "A dozen red roses \r\nwrapped in black \r\nmatte paper with  \r\n   a satin ribbon.";
            this.isinvdesclbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // isinvclosebtn
            // 
            this.isinvclosebtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.isinvclosebtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isinvclosebtn.Location = new System.Drawing.Point(320, 350);
            this.isinvclosebtn.Name = "isinvclosebtn";
            this.isinvclosebtn.Size = new System.Drawing.Size(158, 39);
            this.isinvclosebtn.TabIndex = 45;
            this.isinvclosebtn.Text = "Close";
            this.isinvclosebtn.UseVisualStyleBackColor = false;
            this.isinvclosebtn.Click += new System.EventHandler(this.isinvclosebtn_Click);
            // 
            // Inventory_View_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(490, 414);
            this.Controls.Add(this.isinvclosebtn);
            this.Controls.Add(this.isinvdesclbl);
            this.Controls.Add(this.isinvstat1btn);
            this.Controls.Add(this.qtynumlbl);
            this.Controls.Add(this.isinprc1lbl);
            this.Controls.Add(this.isinvcateg1lbl);
            this.Controls.Add(this.isiinvtem1lbl);
            this.Controls.Add(this.issttlbl);
            this.Controls.Add(this.isdcrplbl);
            this.Controls.Add(this.isquanlbl);
            this.Controls.Add(this.isctglbl);
            this.Controls.Add(this.isprodnamelbl);
            this.Controls.Add(this.isinvpb);
            this.Controls.Add(this.isinvsc);
            this.Name = "Inventory_View_Products";
            this.Text = "Inventory_View_Products";
            this.Load += new System.EventHandler(this.Inventory_View_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.isinvpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter isinvsc;
        private System.Windows.Forms.PictureBox isinvpb;
        private System.Windows.Forms.Label isctglbl;
        private System.Windows.Forms.Label isprodnamelbl;
        private System.Windows.Forms.Label issttlbl;
        private System.Windows.Forms.Label isdcrplbl;
        private System.Windows.Forms.Label isquanlbl;
        private System.Windows.Forms.Label isinprc1lbl;
        private System.Windows.Forms.Label isinvcateg1lbl;
        private System.Windows.Forms.Label isiinvtem1lbl;
        private System.Windows.Forms.Button isinvstat1btn;
        private System.Windows.Forms.Label qtynumlbl;
        private System.Windows.Forms.Label isinvdesclbl;
        private System.Windows.Forms.Button isinvclosebtn;
    }
}