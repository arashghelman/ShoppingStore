using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ShoppingStore.Views
{
    public partial class OrderManageFrm : Telerik.WinControls.UI.RadForm
    {
        public OrderManageFrm()
        {
            InitializeComponent();
        }

        private void RadbtnNew_Click(object sender, EventArgs e)
        {
            OrderDetailFrm Ref_OrderDetailFrm = new OrderDetailFrm();
            Ref_OrderDetailFrm.Show();
        }

        private void RadbtnEdit_Click(object sender, EventArgs e)
        {
            OrderDetailFrm Ref_OrderDetailFrm = new OrderDetailFrm();
            Ref_OrderDetailFrm.Show();
        }
    }
}
