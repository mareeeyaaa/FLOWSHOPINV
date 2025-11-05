using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FLOWSHOPINV.Sales
{
    public partial class Sales_Panel : Form
    {
        private readonly Sales_Dashboard _Dashboard = new Sales_Dashboard();
        private readonly Sales_Products _Products= new Sales_Products();
        private readonly Sales_Order _Order= new Sales_Order();
        private readonly Sales_Cashier _Cashier= new Sales_Cashier();
        private readonly Sales_Profile _Profile= new Sales_Profile();

        public Sales_Panel()
        {
            InitializeComponent();

            // resize current child when the container resizes
            SalesPanelFLP.Resize += (s, e) =>
            {
                if (SalesPanelFLP.Controls.Count > 0)
                {
                    var child = SalesPanelFLP.Controls[0];
                    child.Size = SalesPanelFLP.ClientSize;
                }
            };

            ssdbbtn.Click += (s, e) => ShowControl(_Dashboard);       
            ssordersbutton.Click += (s, e) => ShowControl(_Order);   
            ssprodbtn.Click += (s, e) => ShowControl(_Products);   
            sscsbtn.Click += (s, e) => ShowControl(_Cashier);         
            ssprofbtn.Click += (s, e) => ShowControl(_Profile);
             
            // show default
            ShowControl(_Dashboard);
        }

        private void ShowControl(UserControl uc)
        {
            if (uc == null) return;

            SalesPanelFLP.SuspendLayout();

            // remove previous child
            SalesPanelFLP.Controls.Clear();

            // ensure clean sizing inside FlowLayoutPanel
            uc.Margin = Padding.Empty;
            uc.Visible = true;
            uc.Dock = DockStyle.None; // FlowLayoutPanel ignores Dock.Fill; use Size + Anchor
            uc.Size = SalesPanelFLP.ClientSize;
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            SalesPanelFLP.Controls.Add(uc);
            uc.BringToFront();

            SalesPanelFLP.ResumeLayout();
        }   

        private void ssprodbtn_Click(object sender, EventArgs e)
        {
            ShowControl(_Products);
        }

        private void HiSalesPanel_Click(object sender, EventArgs e)
        {

        }

        private void SalesSC_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
