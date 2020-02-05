using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace ShoppingStore.Views
{
    public partial class OrderDetailFrm : Telerik.WinControls.UI.RadForm
    {
        public OrderDetailFrm()
        {
            InitializeComponent();
            Ref_PersonViewModel = new Models.ViewModels.PersonViewModel();
            Ref_ProductViewModel = new Models.ViewModels.ProductViewModel();
            OrderMasterSaveHelperList = new List<Models.Helper.Order.OrderMasterSaveHelper>();
            Ref_OrderMasterSaveHelper = new Models.Helper.Order.OrderMasterSaveHelper();
            OrderDetailSaveHelperList = new List<Models.Helper.Order.OrderDetailSaveHelper>();
            Ref_OrderDetailSaveHelper = new Models.Helper.Order.OrderDetailSaveHelper();
            Ref_OrderViewModel = new Models.ViewModels.OrderViewModel();
            Ref_OrderMasterSelectHelper = new Models.Helper.Order.OrderMasterSelectHelper();
            Ref_OrderManageFrm = new OrderManageFrm();
        }
        public Models.ViewModels.PersonViewModel Ref_PersonViewModel { get; set; }
        public Models.ViewModels.ProductViewModel Ref_ProductViewModel { get; set; }
        public List<Models.Helper.Order.OrderMasterSaveHelper> OrderMasterSaveHelperList { get; set; }
        public Models.Helper.Order.OrderMasterSaveHelper Ref_OrderMasterSaveHelper { get; set; }
        public List<Models.Helper.Order.OrderDetailSaveHelper> OrderDetailSaveHelperList { get; set; }
        public Models.Helper.Order.OrderDetailSaveHelper Ref_OrderDetailSaveHelper { get; set; }
        public Models.ViewModels.OrderViewModel Ref_OrderViewModel { get; set; }
        public Models.Helper.Order.OrderMasterSelectHelper Ref_OrderMasterSelectHelper { get; set; }
        public Views.OrderManageFrm Ref_OrderManageFrm { get; set; }

        private void OrderDetailFrm_Load(object sender, EventArgs e)
        {
            FillradmlticlmncmbbxSalesperson();
            FillradmlticlmncmbbxCustomer();
            FillradgvProducts();
            FillOrderDate();
            FillOrderCode();
            Initializeradmlticlmncmbbx();
            radgvOrderedProducts.Hide();
            HideColumns();
            AdjustColumnOrder();
            AdjustColumnSize();
            lblOrderTotalPrice.Text = "0";
            lblOrderFinalPrice.Text = "0";
            lblOrderDiscount.Text = "0";
        }

        private void FillradmlticlmncmbbxSalesperson()
        {
            radmlticlmncmbbxSalesperson.DataSource = Ref_PersonViewModel.Refresh();
        }
        private void FillradmlticlmncmbbxCustomer()
        {
            radmlticlmncmbbxCustomer.DataSource = Ref_PersonViewModel.Refresh();
        }

        private void FillradgvProducts()
        {
            radgvProducts.DataSource = Ref_ProductViewModel.Refresh();
        }
        private void FillOrderDate()
        {
            lblOrderDate.Text = Convert.ToString(DateTime.Now);
        }

        public void FillOrderCode()
        {
            Ref_OrderManageFrm.FillGrid();
            lblOrderCode.Text = (Convert.ToInt16(Ref_OrderManageFrm.radgvOrders.Rows[Ref_OrderManageFrm.radgvOrders.Rows.Count - 1].Cells[0].Value)+1).ToString();
        }

        private void Initializeradmlticlmncmbbx()
        {
            radmlticlmncmbbxSalesperson.Text = "Select a salesperson for this order...";
            radmlticlmncmbbxCustomer.Text = "Select a customer for this order...";
        }

        private void AdjustColumnOrder()
        {
            radgvProducts.Columns.Move(7, 0);
            radgvProducts.Columns.Move(2, 1);
            radgvProducts.Columns.Move(6, 2);
        }

        private void AdjustColumnSize()
        {
            radgvProducts.Columns[0].ImageLayout = ImageLayout.Stretch;
            radgvProducts.Columns[0].Width = 160;
            radgvProducts.TableElement.RowHeight = 130;            
        }

        public void AddColumns()
        {
            radgvOrderedProducts.Columns.Add("Product Id");
            radgvOrderedProducts.Columns["Product Id"].IsVisible = false;
            radgvOrderedProducts.Columns.Add("Product Code");
            radgvOrderedProducts.Columns.Add("Product Name");
            radgvOrderedProducts.Columns.Add("Category");
            radgvOrderedProducts.Columns.Add("Quantity");
            radgvOrderedProducts.Columns.Add("Price");
            radgvOrderedProducts.Columns[1].Width = 90;
            radgvOrderedProducts.Columns[2].Width = 90;
            radgvOrderedProducts.Columns[3].Width = 100;
            radgvOrderedProducts.Columns[5].Width = 70;
            radgvOrderedProducts.TableElement.RowHeight = 50;
        }

        private void HideColumns()
        {           
            radgvProducts.Columns[0].IsVisible = false;
            radgvProducts.Columns[1].IsVisible = false;
            radgvProducts.Columns[3].IsVisible = false;
            radgvProducts.Columns[4].IsVisible = false;
            radgvProducts.Columns[5].IsVisible = false;
            radmlticlmncmbbxSalesperson.Columns["PersonId"].IsVisible = false;
            radmlticlmncmbbxCustomer.Columns["PersonId"].IsVisible = false;
        }

        

        private void RadbtnSubmit_Click(object sender, EventArgs e)
        {
            if (lblSalespersonId.Text == lblCustomerId.Text)
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("Salesperson and customer should not be the same");
            }
            else
            {
                int count = radgvOrderedProducts.Rows.Count - 1;
                for (int i = 0; i < count; i++)
                {
                    //foreach (GridViewRowInfo row in radgvOrderedProducts.Rows)
                    //{
                    Ref_OrderDetailSaveHelper.ProductId = Convert.ToInt16(radgvOrderedProducts.Rows[i].Cells[0].Value);
                    Ref_OrderDetailSaveHelper.Quantity = Convert.ToInt16(radgvOrderedProducts.Rows[i].Cells[4].Value);
                    OrderDetailSaveHelperList.Add(Ref_OrderDetailSaveHelper);
                    //}
                }
                Ref_OrderMasterSaveHelper.SalespersonId = Convert.ToInt16(lblSalespersonId.Text);
                Ref_OrderMasterSaveHelper.CustomerId = Convert.ToInt16(lblCustomerId.Text);
                OrderMasterSaveHelperList.Add(Ref_OrderMasterSaveHelper);
                Ref_OrderViewModel.Save(OrderMasterSaveHelperList,OrderDetailSaveHelperList);
            }
        }

        private void RadmlticlmncmbbxSalesperson_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSalespersonId.Text = radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.SelectedIndex].Cells["PersonId"].Value.ToString();
            lblSalespersonName.Text = radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.SelectedIndex].Cells["FirstName"].Value.ToString()+" "+
                radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.SelectedIndex].Cells["LastName"].Value.ToString();
            lblSalespersonAddress.Text = radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.SelectedIndex].Cells["PersonAddress"].Value.ToString()+", "+
                radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.SelectedIndex].Cells["City"].Value.ToString()+", "+
                radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxSalesperson.MultiColumnComboBoxElement.SelectedIndex].Cells["Country"].Value.ToString();
        }

        private void RadmlticlmncmbbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCustomerId.Text = radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.SelectedIndex].Cells["PersonId"].Value.ToString();
            lblCustomerName.Text = radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.SelectedIndex].Cells["FirstName"].Value.ToString() + " " +
                radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.SelectedIndex].Cells["LastName"].Value.ToString();
            lblCustomerAddress.Text = radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.SelectedIndex].Cells["PersonAddress"].Value.ToString() + ", " +
                radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.SelectedIndex].Cells["City"].Value.ToString() + ", " +
                radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCustomer.MultiColumnComboBoxElement.SelectedIndex].Cells["Country"].Value.ToString();


        }

        private void RadbtnAdd_Click(object sender, EventArgs e)
        {
            radgvOrderedProducts.Show();
            if (nmrcupdwnQuantity.Value == 0)
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("You should choose product's quantity");
            }
            if (nmrcupdwnQuantity.Value > 0) 
            {                                
                decimal totalPrice = 0;
                totalPrice += Convert.ToDecimal(label7.Text) * nmrcupdwnQuantity.Value;
                decimal profit = 0;
                profit += Convert.ToDecimal(label4.Text) * nmrcupdwnQuantity.Value;
                decimal finalPrice = totalPrice - profit;
                lblOrderTotalPrice.Text = totalPrice.ToString();
                lblOrderFinalPrice.Text = finalPrice.ToString();
                lblOrderDiscount.Text = profit.ToString();               
                radgvOrderedProducts.Rows.Add(label2.Text, label3.Text, label5.Text, label6.Text, nmrcupdwnQuantity.Value, Convert.ToDecimal(label8.Text) * nmrcupdwnQuantity.Value);               
            }          
        }

        private void RadgvProducts_CellClick(object sender, GridViewCellEventArgs e)
        {
            label2.Text = radgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            label3.Text = radgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            label4.Text = radgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            label5.Text = radgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
            label6.Text = radgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
            label7.Text = radgvProducts.Rows[e.RowIndex].Cells[6].Value.ToString();
            label8.Text = radgvProducts.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void RadbtnOrderRemove_Click(object sender, EventArgs e)
        {
            int row = radgvOrderedProducts.CurrentCell.RowIndex;
            radgvOrderedProducts.Rows.RemoveAt(row);
        }
    }
}
