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
    public partial class OrderDetailFrm : Telerik.WinControls.UI.RadForm
    {
        public OrderDetailFrm()
        {
            InitializeComponent();
            Ref_PersonViewModel = new Models.ViewModels.PersonViewModel();
            Ref_ProductViewModel = new Models.ViewModels.ProductViewModel();
        }
        public Models.ViewModels.PersonViewModel Ref_PersonViewModel { get; set; }
        public Models.ViewModels.ProductViewModel Ref_ProductViewModel { get; set; }

        private void OrderDetailFrm_Load(object sender, EventArgs e)
        {
            FillradmlticlmncmbbxSalesperson();
            FillradmlticlmncmbbxCustomer();
            FillOrderDate();
            Initializeradmlticlmncmbbx();
            FillradlstvwProducts();
            HideColumns();
            
        }

        private void FillradmlticlmncmbbxSalesperson()
        {
            radmlticlmncmbbxSalesperson.DataSource = Ref_PersonViewModel.Refresh();
        }
        private void FillradmlticlmncmbbxCustomer()
        {
            radmlticlmncmbbxCustomer.DataSource = Ref_PersonViewModel.Refresh();
        }
        private void FillOrderDate()
        {
            lblOrderDate.Text = Convert.ToString(DateTime.Now);
        }

        private void Initializeradmlticlmncmbbx()
        {
            radmlticlmncmbbxSalesperson.Text = "Select a salesperson for this order...";
            radmlticlmncmbbxCustomer.Text = "Select a customer for this order...";
        }

        private void FillradlstvwProducts()
        {
            radlstvwProducts.DataSource = Ref_ProductViewModel.Refresh();
            radlstvwProducts.DisplayMember = "ProductName";
        }

        private void HideColumns()
        {
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
            if(nmrcupdwnQuantity.Value == 0)
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("You should choose product's quantity");
            }
            if (nmrcupdwnQuantity.Value > 0) 
            {
                radgvOrderedProducts.Columns.Add("Product Code");
                radgvOrderedProducts.Columns.Add("Product Name");
                radgvOrderedProducts.Columns.Add("Category");
                radgvOrderedProducts.Columns.Add("Quantity");
                radgvOrderedProducts.Columns.Add("Price");

                
                radgvOrderedProducts.Rows.Add("","", "", nmrcupdwnQuantity.Value, "");


                

            }
        }
    }
}
