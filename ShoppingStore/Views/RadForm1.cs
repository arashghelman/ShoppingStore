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

        private void MainFrm_Load(object sender, EventArgs e)
        {
            HideProductControls();
        }

        private void RadtrvwMenu_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            if(radtrvwMenu.SelectedNode.Text == "Submit Order")
            {
                Views.OrderDetailFrm Ref_OrderDetailFrm = new Views.OrderDetailFrm();
                Ref_OrderDetailFrm.Show();
            }

            if(radtrvwMenu.SelectedNode.Text == "Define Product(s)")
            {
                radlblMenu.Hide();
                ShowProductControls();
            }
        }
        private void ShowProductControls()
        {
            radgrpbxProductInformation.Show();
            radgrpbxProducts.Show();
            radbtnProductAdd.Show();
            radbtnProductEdit.Show();
            radbtnProductRemove.Show();
            radbtnProductClose.Show();
        }

        private void HideProductControls()
        {
            radgrpbxProductInformation.Hide();
            radgrpbxProducts.Hide();
            radbtnProductAdd.Hide();
            radbtnProductEdit.Hide();
            radbtnProductRemove.Hide();
            radbtnProductClose.Hide();
        }

        private void RadbtnProductClose_Click(object sender, EventArgs e)
        {
            HideProductControls();
            radlblMenu.Show();
        }
    }
}
