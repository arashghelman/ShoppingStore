using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ShoppingStore
{
    public partial class MainFrm : Telerik.WinControls.UI.RadForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void RadtrvwMenu_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            if(radtrvwMenu.SelectedNode.Text == "Submit Order")
            {
                Views.OrderDetailFrm Ref_OrderDetailFrm = new Views.OrderDetailFrm();
                Ref_OrderDetailFrm.Show();
            }
        }
    }
}
