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
        #region [- ctors -]
        public OrderManageFrm()
        {
            InitializeComponent();
            Ref_OrderViewModel = new Models.ViewModels.OrderViewModel();
            Ref_OrderMasterRemoveHelper = new Models.Helper.Order.OrderMasterRemoveHelper();
            OrderMasterRemoveHelperList = new List<Models.Helper.Order.OrderMasterRemoveHelper>();
            Ref_OrderDetailRemoveHelper = new Models.Helper.Order.OrderDetailRemoveHelper();
            OrderDetailRemoveHelperList = new List<Models.Helper.Order.OrderDetailRemoveHelper>();
        }
        #endregion

        #region [- props -]
        public Models.ViewModels.OrderViewModel Ref_OrderViewModel { get; set; }
        public Models.Helper.Order.OrderMasterRemoveHelper Ref_OrderMasterRemoveHelper { get; set; }
        public List<Models.Helper.Order.OrderMasterRemoveHelper> OrderMasterRemoveHelperList { get; set; }
        public Models.Helper.Order.OrderDetailRemoveHelper Ref_OrderDetailRemoveHelper { get; set; }
        public List<Models.Helper.Order.OrderDetailRemoveHelper> OrderDetailRemoveHelperList { get; set; }
        #endregion

        #region [- OrderManageFrm_Load -]
        private void OrderManageFrm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        #endregion

        #region [- RadbtnNew_Click -]
        private void RadbtnNew_Click(object sender, EventArgs e)
        {
            OrderDetailFrm Ref_OrderDetailFrm = new OrderDetailFrm();
            Ref_OrderDetailFrm.Show();
            Ref_OrderDetailFrm.AddColumns();
        }
        #endregion

        #region [- RadbtnEdit_Click -]
        private void RadbtnEdit_Click(object sender, EventArgs e)
        {
            OrderDetailFrm Ref_OrderDetailFrm = new OrderDetailFrm();
            Ref_OrderDetailFrm.Show();
        }
        #endregion

        #region [- FillGrid() -]
        public void FillGrid()
        {
            radgvOrders.DataSource = Ref_OrderViewModel.RefreshMaster();
        }
        #endregion

        #region [- RadbtnRemove_Click -]
        private void RadbtnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblOrderId.Text))
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("Choose a record to remove.");
            }
            else
            {
                Ref_OrderMasterRemoveHelper.orderId = Convert.ToInt16(lblOrderId.Text);
                Ref_OrderDetailRemoveHelper.OrderId = Convert.ToInt16(lblOrderId.Text);
                OrderMasterRemoveHelperList.Add(Ref_OrderMasterRemoveHelper);
                OrderDetailRemoveHelperList.Add(Ref_OrderDetailRemoveHelper);
                Ref_OrderViewModel.Remove(OrderMasterRemoveHelperList, OrderDetailRemoveHelperList);
            }
        }
        #endregion

        #region [- RadgvOrders_CellClick -]
        private void RadgvOrders_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            lblOrderId.Text = radgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
        } 
        #endregion
    }
}
