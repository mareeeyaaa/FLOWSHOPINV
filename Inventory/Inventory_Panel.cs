using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLOWSHOPINV.Inventory
{
    public partial class Inventory_Panel : Form
    {

        private readonly Inventory_Dashboard _Dashboard = new Inventory_Dashboard();
        private readonly Inventory_Restock_Products _Products= new Inventory_Restock_Products();
        private readonly Inventory_Archive _Archive = new Inventory_Archive();
        private readonly Inventory_Invpanel _Invpanel = new Inventory_Invpanel();
        private readonly Inventory_Profile _Profile = new Inventory_Profile();


        public Inventory_Panel()
        {
            InitializeComponent();

            isdbbtn.Click += (s, e) => ShowControl(_Dashboard);
            isinventorybutton.Click += (s, e) => ShowControl(_Archive);
            isresprodbtn.Click += (s, e) => ShowControl(_Products);
            isarchbtn.Click += (s, e) => ShowControl(_Archive);
            isprofbtn.Click += (s, e) => ShowControl(_Profile);

            ShowControl (_Dashboard);
        }

        private void ShowControl(UserControl uc)
        {
            if (uc == null) return;
            InventoryPanelFLP.SuspendLayout();
            // remove previous child
            InventoryPanelFLP.Controls.Clear();
            // ensure clean sizing inside FlowLayoutPanel
            uc.Margin = Padding.Empty;
            uc.Visible = true;
            uc.Dock = DockStyle.None; // FlowLayoutPanel ignores Dock.Fill; use Size + Anchor
            uc.Size = InventoryPanelFLP.ClientSize;
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InventoryPanelFLP.Controls.Add(uc);
            uc.BringToFront();
            InventoryPanelFLP.ResumeLayout();
        }
    }
}
