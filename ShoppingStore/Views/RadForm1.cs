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
        }
        #endregion

        #region [- MainFrm_Load -]
        private void MainFrm_Load(object sender, EventArgs e)
        {
            HideProductControls();
            HidePersonControls();
        }
        #endregion

        #region [- RadtrvwMenu_NodeMouseClick -]
        private void RadtrvwMenu_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            if (radtrvwMenu.SelectedNode.Text == "Submit Order")
            {
                Views.OrderDetailFrm Ref_OrderDetailFrm = new Views.OrderDetailFrm();
                Ref_OrderDetailFrm.Show();
                radgrpbxMenu.Show();
                radlblMenu.Show();
                HidePersonControls();
                HideProductControls();
            }

            if (radtrvwMenu.SelectedNode.Text == "Define Product(s)")
            {
                radlblMenu.Hide();
                ShowProductControls();
                HidePersonControls();
                radgrpbxMenu.Show();
            }

            if(radtrvwMenu.SelectedNode.Text == "Define People")
            {
                radlblMenu.Hide();
                ShowPersonControls();
                HideProductControls();
                radgrpbxMenu.Hide();
            }

            if(radtrvwMenu.SelectedNode.Text == "Manage Orders")
            {
                Views.OrderManageFrm Ref_OrderManageFrm = new Views.OrderManageFrm();
                Ref_OrderManageFrm.Show();
                radgrpbxMenu.Show();
                radlblMenu.Show();
                HidePersonControls();
                HideProductControls();
            }
        }
        #endregion

        #region [- ShowProductControls() -]
        private void ShowProductControls()
        {
            radgrpbxProductInformation.Show();
            radgrpbxProducts.Show();
            radbtnProductAdd.Show();
            radbtnProductEdit.Show();
            radbtnProductRemove.Show();
            radbtnProductClose.Show();
        }
        #endregion

        #region [- HideProductControls() -]
        private void HideProductControls()
        {
            radgrpbxProductInformation.Hide();
            radgrpbxProducts.Hide();
            radbtnProductAdd.Hide();
            radbtnProductEdit.Hide();
            radbtnProductRemove.Hide();
            radbtnProductClose.Hide();
        }
        #endregion

        #region [- RadbtnProductClose_Click -]
        private void RadbtnProductClose_Click(object sender, EventArgs e)
        {
            HideProductControls();
            radlblMenu.Show();
        }
        #endregion

        #region [- ShowPersonControls() -]
        private void ShowPersonControls()
        {
            radgrpbxPerson.Show();
            radgrpbxPersonInfromation.Show();
            radgrpbxPeople.Show();
            radbtnPersonClose.Show();
        }
        #endregion

        #region [- HidePersonControls() -]
        private void HidePersonControls()
        {
            radgrpbxPerson.Hide();
            radgrpbxPersonInfromation.Hide();
            radgrpbxPeople.Hide();
            radbtnPersonClose.Hide();
        }
        #endregion

        #region [- RadbtnPersonClose_Click -]
        private void RadbtnPersonClose_Click(object sender, EventArgs e)
        {
            radlblMenu.Show();
            HidePersonControls();
            radgrpbxMenu.Show();
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
    }
}
