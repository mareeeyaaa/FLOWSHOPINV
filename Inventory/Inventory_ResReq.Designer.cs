namespace FLOWSHOPINV.Inventory
{
    partial class Inventory_ResReq
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
            this.ProdlistCB = new System.Windows.Forms.ComboBox();
            this.resreqcategCB = new System.Windows.Forms.ComboBox();
            this.resprodlbl = new System.Windows.Forms.Label();
            this.resreqprodnamelbl = new System.Windows.Forms.Label();
            this.resreqcateglbl = new System.Windows.Forms.Label();
            this.prcpqtylbl = new System.Windows.Forms.Label();
            this.resreqprclbl = new System.Windows.Forms.Label();
            this.reqqtyTB = new System.Windows.Forms.TextBox();
            this.resprodpanel = new System.Windows.Forms.Panel();
            this.resqtylbl = new System.Windows.Forms.Label();
            this.isresreqcancelbtn = new System.Windows.Forms.Button();
            this.isresreqbtn = new System.Windows.Forms.Button();
            this.resprodpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProdlistCB
            // 
            this.ProdlistCB.AutoCompleteCustomSource.AddRange(new string[] {
            "All Orders",
            "Active ",
            "Inactive"});
            this.ProdlistCB.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdlistCB.FormattingEnabled = true;
            this.ProdlistCB.Items.AddRange(new object[] {
            "Eternal Roses",
            "Blush of Love",
            "Golden Years",
            "Scarlet Passion",
            "Pure Devotion",
            "Romantic Charm",
            "Lavender Dreams",
            "Timeless Romance"});
            this.ProdlistCB.Location = new System.Drawing.Point(12, 99);
            this.ProdlistCB.Name = "ProdlistCB";
            this.ProdlistCB.Size = new System.Drawing.Size(351, 28);
            this.ProdlistCB.TabIndex = 7;
            // 
            // resreqcategCB
            // 
            this.resreqcategCB.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resreqcategCB.FormattingEnabled = true;
            this.resreqcategCB.Items.AddRange(new object[] {
            "Anniversary Collection",
            "Wedding Collection",
            "Birthday  Collection",
            "Christmas Collection",
            "New Baby Collection",
            "Congratulatory Collection",
            "Bundle Packages"});
            this.resreqcategCB.Location = new System.Drawing.Point(12, 167);
            this.resreqcategCB.Name = "resreqcategCB";
            this.resreqcategCB.Size = new System.Drawing.Size(351, 28);
            this.resreqcategCB.TabIndex = 8;
            // 
            // resprodlbl
            // 
            this.resprodlbl.AutoSize = true;
            this.resprodlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resprodlbl.Location = new System.Drawing.Point(100, 16);
            this.resprodlbl.Name = "resprodlbl";
            this.resprodlbl.Size = new System.Drawing.Size(157, 26);
            this.resprodlbl.TabIndex = 9;
            this.resprodlbl.Text = "Restock Product";
            this.resprodlbl.Click += new System.EventHandler(this.resprodlbl_Click);
            // 
            // resreqprodnamelbl
            // 
            this.resreqprodnamelbl.AutoSize = true;
            this.resreqprodnamelbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resreqprodnamelbl.Location = new System.Drawing.Point(12, 74);
            this.resreqprodnamelbl.Name = "resreqprodnamelbl";
            this.resreqprodnamelbl.Size = new System.Drawing.Size(117, 22);
            this.resreqprodnamelbl.TabIndex = 10;
            this.resreqprodnamelbl.Text = "Product Name";
            // 
            // resreqcateglbl
            // 
            this.resreqcateglbl.AutoSize = true;
            this.resreqcateglbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resreqcateglbl.Location = new System.Drawing.Point(12, 142);
            this.resreqcateglbl.Name = "resreqcateglbl";
            this.resreqcateglbl.Size = new System.Drawing.Size(78, 22);
            this.resreqcateglbl.TabIndex = 11;
            this.resreqcateglbl.Text = "Category";
            // 
            // prcpqtylbl
            // 
            this.prcpqtylbl.AutoSize = true;
            this.prcpqtylbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prcpqtylbl.Location = new System.Drawing.Point(12, 214);
            this.prcpqtylbl.Name = "prcpqtylbl";
            this.prcpqtylbl.Size = new System.Drawing.Size(132, 22);
            this.prcpqtylbl.TabIndex = 12;
            this.prcpqtylbl.Text = "Price per Product:";
            this.prcpqtylbl.Click += new System.EventHandler(this.prcpqtylbl_Click);
            // 
            // resreqprclbl
            // 
            this.resreqprclbl.AutoSize = true;
            this.resreqprclbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resreqprclbl.Location = new System.Drawing.Point(143, 218);
            this.resreqprclbl.Name = "resreqprclbl";
            this.resreqprclbl.Size = new System.Drawing.Size(21, 18);
            this.resreqprclbl.TabIndex = 13;
            this.resreqprclbl.Text = " ₱";
            this.resreqprclbl.Click += new System.EventHandler(this.resreqprclbl_Click);
            // 
            // reqqtyTB
            // 
            this.reqqtyTB.Location = new System.Drawing.Point(12, 285);
            this.reqqtyTB.Multiline = true;
            this.reqqtyTB.Name = "reqqtyTB";
            this.reqqtyTB.Size = new System.Drawing.Size(351, 28);
            this.reqqtyTB.TabIndex = 14;
            // 
            // resprodpanel
            // 
            this.resprodpanel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.resprodpanel.Controls.Add(this.resprodlbl);
            this.resprodpanel.Location = new System.Drawing.Point(-1, 1);
            this.resprodpanel.Name = "resprodpanel";
            this.resprodpanel.Size = new System.Drawing.Size(386, 58);
            this.resprodpanel.TabIndex = 15;
            // 
            // resqtylbl
            // 
            this.resqtylbl.AutoSize = true;
            this.resqtylbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resqtylbl.Location = new System.Drawing.Point(8, 258);
            this.resqtylbl.Name = "resqtylbl";
            this.resqtylbl.Size = new System.Drawing.Size(139, 22);
            this.resqtylbl.TabIndex = 16;
            this.resqtylbl.Text = "Restock Quantity";
            // 
            // isresreqcancelbtn
            // 
            this.isresreqcancelbtn.BackColor = System.Drawing.Color.CadetBlue;
            this.isresreqcancelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.isresreqcancelbtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isresreqcancelbtn.Location = new System.Drawing.Point(12, 364);
            this.isresreqcancelbtn.Name = "isresreqcancelbtn";
            this.isresreqcancelbtn.Size = new System.Drawing.Size(164, 39);
            this.isresreqcancelbtn.TabIndex = 36;
            this.isresreqcancelbtn.Text = "Cancel";
            this.isresreqcancelbtn.UseVisualStyleBackColor = false;
            // 
            // isresreqbtn
            // 
            this.isresreqbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.isresreqbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.isresreqbtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isresreqbtn.Location = new System.Drawing.Point(199, 364);
            this.isresreqbtn.Name = "isresreqbtn";
            this.isresreqbtn.Size = new System.Drawing.Size(164, 39);
            this.isresreqbtn.TabIndex = 37;
            this.isresreqbtn.Text = " Request Restock";
            this.isresreqbtn.UseVisualStyleBackColor = false;
            // 
            // Inventory_ResReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(384, 433);
            this.Controls.Add(this.isresreqbtn);
            this.Controls.Add(this.isresreqcancelbtn);
            this.Controls.Add(this.resqtylbl);
            this.Controls.Add(this.resprodpanel);
            this.Controls.Add(this.reqqtyTB);
            this.Controls.Add(this.resreqprclbl);
            this.Controls.Add(this.prcpqtylbl);
            this.Controls.Add(this.resreqcateglbl);
            this.Controls.Add(this.resreqprodnamelbl);
            this.Controls.Add(this.resreqcategCB);
            this.Controls.Add(this.ProdlistCB);
            this.Name = "Inventory_ResReq";
            this.Text = "Inventory_ResReq";
            this.resprodpanel.ResumeLayout(false);
            this.resprodpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProdlistCB;
        private System.Windows.Forms.ComboBox resreqcategCB;
        private System.Windows.Forms.Label resprodlbl;
        private System.Windows.Forms.Label resreqprodnamelbl;
        private System.Windows.Forms.Label resreqcateglbl;
        private System.Windows.Forms.Label prcpqtylbl;
        private System.Windows.Forms.Label resreqprclbl;
        private System.Windows.Forms.TextBox reqqtyTB;
        private System.Windows.Forms.Panel resprodpanel;
        private System.Windows.Forms.Label resqtylbl;
        private System.Windows.Forms.Button isresreqcancelbtn;
        private System.Windows.Forms.Button isresreqbtn;
    }
}