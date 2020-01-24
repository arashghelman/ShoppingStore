using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ShoppingStore
{
    public partial class MainFrm : Telerik.WinControls.UI.RadForm
    {
        #region [- ctors -]
        public MainFrm()
        {
            InitializeComponent();
            ProductSaveHelperList = new List<Models.Helper.Product.ProductSaveHelper>();
            Ref_ProductSaveHelper = new Models.Helper.Product.ProductSaveHelper();
            PersonSaveHelperList = new List<Models.Helper.Person.PersonSaveHelper>();
            Ref_PersonSaveHelper = new Models.Helper.Person.PersonSaveHelper();
            Ref_PersonViewModel = new Models.ViewModels.PersonViewModel();
            Ref_CategoryViewModel = new Models.ViewModels.CategoryViewModel();
            Ref_ProductViewModel = new Models.ViewModels.ProductViewModel();
            Ref_PersonEditHelper = new Models.Helper.Person.PersonEditHelper();
            PersonEditHelperList = new List<Models.Helper.Person.PersonEditHelper>();
            PersonRemoveHelperList = new List<Models.Helper.Person.PersonRemoveHelper>();
            Ref_PersonRemoveHelper = new Models.Helper.Person.PersonRemoveHelper();
            Ref_ProductEditHelper = new Models.Helper.Product.ProductEditHelper();
            ProductEditHelperList = new List<Models.Helper.Product.ProductEditHelper>();
            Ref_ProductRemoveHelper = new Models.Helper.Product.ProductRemoveHelper();
            ProductRemoveHelperList = new List<Models.Helper.Product.ProductRemoveHelper>();
        }
        #endregion

        #region [- props -]
        public List<Models.Helper.Product.ProductSaveHelper> ProductSaveHelperList { get; set; }
        public Models.Helper.Product.ProductSaveHelper Ref_ProductSaveHelper { get; set; }
        public List<Models.Helper.Person.PersonSaveHelper> PersonSaveHelperList { get; set; }
        public Models.Helper.Person.PersonSaveHelper Ref_PersonSaveHelper { get; set; }
        public Models.ViewModels.PersonViewModel Ref_PersonViewModel { get; set; }
        public Models.ViewModels.CategoryViewModel Ref_CategoryViewModel { get; set; }
        public Models.ViewModels.ProductViewModel Ref_ProductViewModel { get; set; }
        public Models.Helper.Person.PersonEditHelper Ref_PersonEditHelper { get; set; }
        public List<Models.Helper.Person.PersonEditHelper> PersonEditHelperList { get; set; }
        public List<Models.Helper.Person.PersonRemoveHelper> PersonRemoveHelperList { get; set; }
        public Models.Helper.Person.PersonRemoveHelper Ref_PersonRemoveHelper { get; set; }
        public Models.Helper.Product.ProductEditHelper Ref_ProductEditHelper { get; set; }
        public List<Models.Helper.Product.ProductEditHelper> ProductEditHelperList { get; set; }
        public Models.Helper.Product.ProductRemoveHelper Ref_ProductRemoveHelper { get; set; }
        public List<Models.Helper.Product.ProductRemoveHelper> ProductRemoveHelperList { get; set; }
        public object ImageValue { get; set; } 
        #endregion

        #region [- MainFrm_Load -]
        private void MainFrm_Load(object sender, EventArgs e)
        {
            radgrpbxProduct.Hide();
            radgrpbxPerson.Hide();
            FillPeopleGrid();
            FillProductsGrid();
            FillMultiColumnComboBoxCategory();
            HideColumns();
            SetColumnSize();
            lblProductId.Text = null;
        }
        #endregion

        #region [- RadtrvwMenu_NodeMouseClick -]
        private void RadtrvwMenu_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            if (radtrvwMenu.SelectedNode.Text == "Submit Order")
            {
                Views.OrderDetailFrm Ref_OrderDetailFrm = new Views.OrderDetailFrm();
                Ref_OrderDetailFrm.Show();
                radgrpbxProduct.Hide();
                radgrpbxPerson.Hide();               
            }

            if (radtrvwMenu.SelectedNode.Text == "Define Product(s)")
            {
                radgrpbxProduct.Show();
                radgrpbxPerson.Hide();
            }

            if(radtrvwMenu.SelectedNode.Text == "Define People")
            {
                radgrpbxPerson.Show();
                radgrpbxProduct.Hide();
            }

            if(radtrvwMenu.SelectedNode.Text == "Manage Orders")
            {
                Views.OrderManageFrm Ref_OrderManageFrm = new Views.OrderManageFrm();
                Ref_OrderManageFrm.Show();
                radgrpbxProduct.Hide();
                radgrpbxPerson.Hide();
            }
            if (radtrvwMenu.SelectedNode.Text == "Define Categories")
            {
                Views.CategoryFrm Ref_CategoryFrm = new Views.CategoryFrm();
                Ref_CategoryFrm.Show();
                radgrpbxPerson.Hide();
                radgrpbxProduct.Hide();
            }
        }
        #endregion
       

        #region [- RadbtnProductClose_Click -]
        private void RadbtnProductClose_Click(object sender, EventArgs e)
        {
            radgrpbxProduct.Hide();
        }
        #endregion       

        #region [- RadbtnPersonClose_Click -]
        private void RadbtnPersonClose_Click(object sender, EventArgs e)
        {
            radgrpbxPerson.Hide();
        } 
        #endregion

        #region [- AddImage() -]
        private byte[] AddImage()
        {
            FileStream Ref_FileStream = new FileStream(lblProductFileName.Text, FileMode.Open, FileAccess.Read);
            BinaryReader Ref_BinaryReader = new BinaryReader(Ref_FileStream);
            byte[] imageByte = Ref_BinaryReader.ReadBytes((int)Ref_FileStream.Length);
            return imageByte;
        }
        #endregion

        #region [- RadbtnProductImage_Click -]
        private void RadbtnProductImage_Click(object sender, EventArgs e)
        {
            uploadFileDialog.ShowDialog();
            lblProductFileName.Text = uploadFileDialog.FileName;
        }
        #endregion

        private void RadbtnProductAdd_Click(object sender, EventArgs e)
        {
            Ref_ProductSaveHelper.ProductName = radtxtbxProductName.Text;
            Ref_ProductSaveHelper.UnitPrice = Convert.ToDecimal(radtxtbxProductUnitPrice.Text);
            Ref_ProductSaveHelper.Discount = Convert.ToDecimal(radtxtbxProductDiscount.Text);
            Ref_ProductSaveHelper.CategoryId = Convert.ToInt16(radmlticlmncmbbxCategory.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCategory.MultiColumnComboBoxElement.SelectedIndex].Cells["CategoryId"].Value);
            Ref_ProductSaveHelper.ProductPhoto = AddImage();
            ProductSaveHelperList.Add(Ref_ProductSaveHelper);
            Ref_ProductViewModel.Save(ProductSaveHelperList);
            FillProductsGrid();
        }

        private void RadbtnPersonAdd_Click(object sender, EventArgs e)
        {
            Ref_PersonSaveHelper.FirstName = radtxtbxPersonFirstName.Text;
            Ref_PersonSaveHelper.LastName = radtxtbxPersonLastName.Text;
            Ref_PersonSaveHelper.Phone = radtxtbxPersonPhone.Text;
            Ref_PersonSaveHelper.Email = radtxtbxPersonEmail.Text;
            Ref_PersonSaveHelper.PersonAddress = radtxtbxPersonAddress.Text;
            Ref_PersonSaveHelper.City = radtxtbxPersonCity.Text;
            Ref_PersonSaveHelper.Country = radtxtbxPersonCity.Text;
            Ref_PersonSaveHelper.Company = radtxtbxPersonCompany.Text;
            PersonSaveHelperList.Add(Ref_PersonSaveHelper);
            Ref_PersonViewModel.Save(PersonSaveHelperList);
            FillPeopleGrid();
            EmptyPersonFields();
        }

        #region [- FillPeopleGrid() -]
        private void FillPeopleGrid()
        {
            radgvPeople.DataSource = Ref_PersonViewModel.Refresh();
        }
        #endregion

        #region [- FillProductsGrid() -]
        private void FillProductsGrid()
        {
           radgvProducts.DataSource = Ref_ProductViewModel.Refresh();
        } 
        #endregion

        #region [- FillMultiColumnComboBoxCategory() -]
        private void FillMultiColumnComboBoxCategory()
        {
            radmlticlmncmbbxCategory.DataSource = Ref_CategoryViewModel.Refresh();
        }
        #endregion

        private void RadgvPeople_CellClick(object sender, GridViewCellEventArgs e)
        {
            label1.Text = radgvPeople.Rows[e.RowIndex].Cells[0].Value.ToString();
            radtxtbxPersonFirstName.Text = radgvPeople.Rows[e.RowIndex].Cells[2].Value.ToString();
            radtxtbxPersonLastName.Text = radgvPeople.Rows[e.RowIndex].Cells[3].Value.ToString();
            radtxtbxPersonPhone.Text = radgvPeople.Rows[e.RowIndex].Cells[4].Value.ToString();
            radtxtbxPersonEmail.Text = radgvPeople.Rows[e.RowIndex].Cells[5].Value.ToString();
            radtxtbxPersonAddress.Text = radgvPeople.Rows[e.RowIndex].Cells[6].Value.ToString();
            radtxtbxPersonCity.Text = radgvPeople.Rows[e.RowIndex].Cells[7].Value.ToString();
            radtxtbxPersonCountry.Text = radgvPeople.Rows[e.RowIndex].Cells[8].Value.ToString();
            radtxtbxPersonCompany.Text = radgvPeople.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void RadbtnPersonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label1.Text))
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("Choose a record to edit");
            }
            else
            {
                Ref_PersonEditHelper.Id = Convert.ToInt16(label1.Text);
                Ref_PersonEditHelper.FirstName = radtxtbxPersonFirstName.Text;
                Ref_PersonEditHelper.LastName = radtxtbxPersonLastName.Text;
                Ref_PersonEditHelper.Phone = radtxtbxPersonPhone.Text;
                Ref_PersonEditHelper.Email = radtxtbxPersonEmail.Text;
                Ref_PersonEditHelper.City = radtxtbxPersonCity.Text;
                Ref_PersonEditHelper.Country = radtxtbxPersonCountry.Text;
                Ref_PersonEditHelper.Company = radtxtbxPersonCompany.Text;
                Ref_PersonEditHelper.PersonAddress = radtxtbxPersonAddress.Text;
                PersonEditHelperList.Add(Ref_PersonEditHelper);
                Ref_PersonViewModel.Edit(PersonEditHelperList);
                FillPeopleGrid();
            }
        }

        #region [- HideColumn() -]
        private void HideColumns()
        {
            radgvPeople.Columns["PersonId"].IsVisible = false;
            radmlticlmncmbbxCategory.Columns["CategoryId"].IsVisible = false;
            radmlticlmncmbbxCategory.Columns["NumberOfProducts"].IsVisible = false;
            radgvProducts.Columns["ProductId"].IsVisible = false;
        }
        #endregion

        private void RadbtnPersonRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label1.Text))
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("Choose a record to remove");
            }
            else
            {
                Ref_PersonRemoveHelper.Id = Convert.ToInt16(label1.Text);
                PersonRemoveHelperList.Add(Ref_PersonRemoveHelper);
                Ref_PersonViewModel.Remove(PersonRemoveHelperList);
                FillPeopleGrid();
                EmptyPersonFields();
            }
        }

        private void RadbtnPersonClearAll_Click(object sender, EventArgs e)
        {
            EmptyPersonFields();
        }

        #region [- EmptyPersonFields() -]
        private void EmptyPersonFields()
        {
            label1.Text = string.Empty;
            radtxtbxPersonCity.Text = string.Empty;
            radtxtbxPersonAddress.Text = string.Empty;
            radtxtbxPersonCompany.Text = string.Empty;
            radtxtbxPersonFirstName.Text = string.Empty;
            radtxtbxPersonLastName.Text = string.Empty;
            radtxtbxPersonPhone.Text = string.Empty;
            radtxtbxPersonCountry.Text = string.Empty;
            radtxtbxPersonEmail.Text = string.Empty;
        }
        #endregion

        private void EmptyProductFields()
        {
            label2.Text = string.Empty;
            radtxtbxProductName.Text = string.Empty;
            radtxtbxProductUnitPrice.Text = string.Empty;
            radtxtbxProductDiscount.Text = string.Empty;
            lblProductFileName.Text = string.Empty;
            radmlticlmncmbbxCategory.Text = string.Empty;
        }

        #region [- UpdateImage(object image) -]
        private byte[] UpdateImage(object image)
        {
            byte[] data = (byte[])image;
            return data;
        }
        #endregion

        private void RadgvProducts_CellClick(object sender, GridViewCellEventArgs e)
        {
            lblProductId.Text = radgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            radtxtbxProductName.Text = radgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            radmlticlmncmbbxCategory.Text = radgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            radtxtbxProductUnitPrice.Text = radgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
            radtxtbxProductDiscount.Text = radgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
            ImageValue = radgvProducts.Rows[e.RowIndex].Cells[7].Value;
        }

        private void RadbtnProductEdit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblProductId.Text))
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("Choose a record to edit");
            }
            else
            {
                if (lblProductFileName.Text != "")
                {
                    Ref_ProductEditHelper.Id = int.Parse(lblProductId.Text);
                    Ref_ProductEditHelper.CategoryId = Convert.ToInt16(radmlticlmncmbbxCategory.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCategory.MultiColumnComboBoxElement.SelectedIndex].Cells["CategoryId"].Value);
                    Ref_ProductEditHelper.UnitPrice = Convert.ToDecimal(radtxtbxProductUnitPrice.Text);
                    Ref_ProductEditHelper.Discount = Convert.ToDecimal(radtxtbxProductDiscount.Text);
                    Ref_ProductEditHelper.ProductName = radtxtbxProductName.Text;
                    Ref_ProductEditHelper.ProductPhoto = AddImage();
                    ProductEditHelperList.Add(Ref_ProductEditHelper);
                    Ref_ProductViewModel.Edit(ProductEditHelperList);
                    EmptyProductFields();
                }
                else
                {
                    Ref_ProductEditHelper.Id = int.Parse(lblProductId.Text);
                    Ref_ProductEditHelper.CategoryId = Convert.ToInt16(radmlticlmncmbbxCategory.MultiColumnComboBoxElement.EditorControl.Rows[radmlticlmncmbbxCategory.MultiColumnComboBoxElement.SelectedIndex].Cells["CategoryId"].Value);
                    Ref_ProductEditHelper.UnitPrice = Convert.ToDecimal(radtxtbxProductUnitPrice.Text);
                    Ref_ProductEditHelper.Discount = Convert.ToDecimal(radtxtbxProductDiscount.Text);
                    Ref_ProductEditHelper.ProductName = radtxtbxProductName.Text;
                    Ref_ProductEditHelper.ProductPhoto = UpdateImage(ImageValue);
                    ProductEditHelperList.Add(Ref_ProductEditHelper);
                    Ref_ProductViewModel.Edit(ProductEditHelperList);
                }
                FillProductsGrid();
            }
        }

        private void RadbtnProductRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblProductId.Text))
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("Choose a record to remove");
            }
            else
            {
                Ref_ProductRemoveHelper.Id = int.Parse(lblProductId.Text);
                ProductRemoveHelperList.Add(Ref_ProductRemoveHelper);
                Ref_ProductViewModel.Remove(ProductRemoveHelperList);
                FillProductsGrid();
            }
        }

        #region [- SetColumnSize() -]
        private void SetColumnSize()
        {
            radgvProducts.TableElement.RowHeight = 200;
            radgvProducts.Columns[1].Width = 100;
            radgvProducts.Columns[2].Width = 100;
            radgvProducts.Columns[3].Width = 100;
            radgvProducts.Columns[4].Width = 100;
            radgvProducts.Columns[5].Width = 100;
            radgvProducts.Columns[6].Width = 100;
            radgvProducts.Columns[7].Width = 230;
        } 
        #endregion
    }
}
