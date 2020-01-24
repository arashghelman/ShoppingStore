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
    public partial class CategoryFrm : Telerik.WinControls.UI.RadForm
    {
        public CategoryFrm()
        {
            InitializeComponent();
            Ref_CategoryViewModel = new Models.ViewModels.CategoryViewModel();
            CategorySaveHelperList = new List<Models.Helper.Category.CategorySaveHelper>();
            Ref_CategorySaveHelper = new Models.Helper.Category.CategorySaveHelper();
            CategoryEditHelperList = new List<Models.Helper.Category.CategoryEditHelper>();
            Ref_CategoryEditHelper = new Models.Helper.Category.CategoryEditHelper();
            Ref_CategoryRemoveHelper = new Models.Helper.Category.CategoryRemoveHelper();
            CategoryRemoveHelperList = new List<Models.Helper.Category.CategoryRemoveHelper>();
        }

        public Models.ViewModels.CategoryViewModel Ref_CategoryViewModel { get; set; }
        public Models.Helper.Category.CategorySaveHelper Ref_CategorySaveHelper { get; set; }
        public List<Models.Helper.Category.CategorySaveHelper> CategorySaveHelperList { get; set; }
        public Models.Helper.Category.CategoryEditHelper Ref_CategoryEditHelper { get; set; }
        public List<Models.Helper.Category.CategoryEditHelper> CategoryEditHelperList { get; set; }
        public Models.Helper.Category.CategoryRemoveHelper Ref_CategoryRemoveHelper { get; set; }
        public List<Models.Helper.Category.CategoryRemoveHelper> CategoryRemoveHelperList { get; set; }

        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            FillCategoryGrid();
            radgvCategories.Columns[0].IsVisible = false;
            radgvCategories.Columns[1].Width = 100;
            radgvCategories.Columns[2].Width = 120;
        }

        private void FillCategoryGrid()
        {
            radgvCategories.DataSource = Ref_CategoryViewModel.Refresh();
        }

        private void RadBtnAdd_Click(object sender, EventArgs e)
        {
            Ref_CategorySaveHelper.CategoryName = radtxtbxCategoryName.Text;
            CategorySaveHelperList.Add(Ref_CategorySaveHelper);
            Ref_CategoryViewModel.Save(CategorySaveHelperList);
        }

        private void RadgvCategories_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            lblCategoryId.Text = radgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
            radtxtbxCategoryName.Text = radgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void RadBtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCategoryId.Text))
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("Choose a record to edit.");
            }
            else
            {
                Ref_CategoryEditHelper.CategoryId = Convert.ToInt16(lblCategoryId.Text);
                Ref_CategoryEditHelper.CategoryName = radtxtbxCategoryName.Text;
                CategoryEditHelperList.Add(Ref_CategoryEditHelper);
                Ref_CategoryViewModel.Edit(CategoryEditHelperList);
                FillCategoryGrid();
            }
        }

        private void RadBtnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCategoryId.Text))
            {
                RadMessageBox.ThemeName = "Office2013Light";
                RadMessageBox.Show("Choose a record to remove.");
            }
            else
            {
                Ref_CategoryRemoveHelper.CategoryId = Convert.ToInt16(lblCategoryId.Text);
                CategoryRemoveHelperList.Add(Ref_CategoryRemoveHelper);
                Ref_CategoryViewModel.Remove(CategoryRemoveHelperList);
                FillCategoryGrid();
            }
        }
    }
}
