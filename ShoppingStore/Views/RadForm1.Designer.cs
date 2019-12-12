namespace ShoppingStore
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode7 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode8 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode9 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode10 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radgrpbxMenu = new Telerik.WinControls.UI.RadGroupBox();
            this.radlblMenu = new Telerik.WinControls.UI.RadLabel();
            this.radtrvwMenu = new Telerik.WinControls.UI.RadTreeView();
            this.radgrpbxProductInformation = new Telerik.WinControls.UI.RadGroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.radtxtbxProductName = new Telerik.WinControls.UI.RadTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbbxCategory = new System.Windows.Forms.ComboBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.nmrcupdwnProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.radbtnProductAdd = new Telerik.WinControls.UI.RadButton();
            this.radbtnProductEdit = new Telerik.WinControls.UI.RadButton();
            this.radbtnProductRemove = new Telerik.WinControls.UI.RadButton();
            this.radgrpbxProducts = new Telerik.WinControls.UI.RadGroupBox();
            this.radgvProducts = new Telerik.WinControls.UI.RadGridView();
            this.radbtnProductClose = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxMenu)).BeginInit();
            this.radgrpbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radlblMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtrvwMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxProductInformation)).BeginInit();
            this.radgrpbxProductInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radtxtbxProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcupdwnProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnProductAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnProductEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnProductRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxProducts)).BeginInit();
            this.radgrpbxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgvProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnProductClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radgrpbxMenu
            // 
            this.radgrpbxMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxMenu.Controls.Add(this.radbtnProductClose);
            this.radgrpbxMenu.Controls.Add(this.radgrpbxProducts);
            this.radgrpbxMenu.Controls.Add(this.radbtnProductRemove);
            this.radgrpbxMenu.Controls.Add(this.radbtnProductEdit);
            this.radgrpbxMenu.Controls.Add(this.radbtnProductAdd);
            this.radgrpbxMenu.Controls.Add(this.radlblMenu);
            this.radgrpbxMenu.Controls.Add(this.radgrpbxProductInformation);
            this.radgrpbxMenu.HeaderText = "";
            this.radgrpbxMenu.Location = new System.Drawing.Point(202, 12);
            this.radgrpbxMenu.Name = "radgrpbxMenu";
            this.radgrpbxMenu.Size = new System.Drawing.Size(426, 453);
            this.radgrpbxMenu.TabIndex = 3;
            this.radgrpbxMenu.ThemeName = "ControlDefault";
            // 
            // radlblMenu
            // 
            this.radlblMenu.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radlblMenu.Location = new System.Drawing.Point(117, 206);
            this.radlblMenu.Name = "radlblMenu";
            this.radlblMenu.Size = new System.Drawing.Size(195, 19);
            this.radlblMenu.TabIndex = 1;
            this.radlblMenu.Text = "--  Choose an option to continue --";
            this.radlblMenu.ThemeName = "Material";
            // 
            // radtrvwMenu
            // 
            this.radtrvwMenu.BackColor = System.Drawing.Color.White;
            this.radtrvwMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.radtrvwMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radtrvwMenu.ForeColor = System.Drawing.Color.Black;
            this.radtrvwMenu.ItemHeight = 40;
            this.radtrvwMenu.LineColor = System.Drawing.Color.White;
            this.radtrvwMenu.LineStyle = Telerik.WinControls.UI.TreeLineStyle.DashDotDot;
            this.radtrvwMenu.Location = new System.Drawing.Point(12, 12);
            this.radtrvwMenu.Name = "radtrvwMenu";
            radTreeNode6.BackColor = System.Drawing.Color.LightSkyBlue;
            radTreeNode6.BackColor2 = System.Drawing.Color.White;
            radTreeNode6.Expanded = true;
            radTreeNode6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode6.Name = "Node1";
            radTreeNode7.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode7.Name = "Node2";
            radTreeNode7.Text = "Define Product(s)";
            radTreeNode8.Expanded = true;
            radTreeNode8.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode8.Name = "Node3";
            radTreeNode8.Text = "Define People";
            radTreeNode6.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode7,
            radTreeNode8});
            radTreeNode6.Text = "Basic Definitions";
            radTreeNode9.BackColor = System.Drawing.Color.LightSkyBlue;
            radTreeNode9.BackColor2 = System.Drawing.Color.White;
            radTreeNode9.Expanded = true;
            radTreeNode9.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode9.Name = "Node4";
            radTreeNode10.Expanded = true;
            radTreeNode10.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode10.Name = "Node5";
            radTreeNode10.Text = "Submit Order";
            radTreeNode9.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode10});
            radTreeNode9.Text = "Transactions";
            this.radtrvwMenu.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode6,
            radTreeNode9});
            this.radtrvwMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radtrvwMenu.Size = new System.Drawing.Size(184, 453);
            this.radtrvwMenu.SpacingBetweenNodes = -1;
            this.radtrvwMenu.TabIndex = 2;
            this.radtrvwMenu.ThemeName = "ControlDefault";
            this.radtrvwMenu.NodeMouseClick += new Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.RadtrvwMenu_NodeMouseClick);
            // 
            // radgrpbxProductInformation
            // 
            this.radgrpbxProductInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxProductInformation.Controls.Add(this.nmrcupdwnProductQuantity);
            this.radgrpbxProductInformation.Controls.Add(this.lblProductQuantity);
            this.radgrpbxProductInformation.Controls.Add(this.radTextBox1);
            this.radgrpbxProductInformation.Controls.Add(this.lblProductPrice);
            this.radgrpbxProductInformation.Controls.Add(this.cmbbxCategory);
            this.radgrpbxProductInformation.Controls.Add(this.lblCategory);
            this.radgrpbxProductInformation.Controls.Add(this.radtxtbxProductName);
            this.radgrpbxProductInformation.Controls.Add(this.lblProductName);
            this.radgrpbxProductInformation.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgrpbxProductInformation.ForeColor = System.Drawing.Color.DimGray;
            this.radgrpbxProductInformation.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxProductInformation.HeaderText = "Information";
            this.radgrpbxProductInformation.Location = new System.Drawing.Point(14, 11);
            this.radgrpbxProductInformation.Name = "radgrpbxProductInformation";
            this.radgrpbxProductInformation.Size = new System.Drawing.Size(396, 126);
            this.radgrpbxProductInformation.TabIndex = 4;
            this.radgrpbxProductInformation.Text = "Information";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxProductInformation.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Empty;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxProductInformation.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(13, 45);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name : ";
            // 
            // radtxtbxProductName
            // 
            this.radtxtbxProductName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtxtbxProductName.Location = new System.Drawing.Point(73, 43);
            this.radtxtbxProductName.Name = "radtxtbxProductName";
            this.radtxtbxProductName.Size = new System.Drawing.Size(100, 21);
            this.radtxtbxProductName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(220, 44);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 15);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category : ";
            // 
            // cmbbxCategory
            // 
            this.cmbbxCategory.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCategory.FormattingEnabled = true;
            this.cmbbxCategory.Location = new System.Drawing.Point(291, 41);
            this.cmbbxCategory.Name = "cmbbxCategory";
            this.cmbbxCategory.Size = new System.Drawing.Size(91, 23);
            this.cmbbxCategory.TabIndex = 5;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(73, 87);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(100, 21);
            this.radTextBox1.TabIndex = 7;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.Black;
            this.lblProductPrice.Location = new System.Drawing.Point(19, 89);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(42, 15);
            this.lblProductPrice.TabIndex = 6;
            this.lblProductPrice.Text = "Price : ";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblProductQuantity.Location = new System.Drawing.Point(220, 87);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(65, 15);
            this.lblProductQuantity.TabIndex = 8;
            this.lblProductQuantity.Text = "Quantity : ";
            // 
            // nmrcupdwnProductQuantity
            // 
            this.nmrcupdwnProductQuantity.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcupdwnProductQuantity.Location = new System.Drawing.Point(314, 83);
            this.nmrcupdwnProductQuantity.Name = "nmrcupdwnProductQuantity";
            this.nmrcupdwnProductQuantity.Size = new System.Drawing.Size(48, 25);
            this.nmrcupdwnProductQuantity.TabIndex = 9;
            // 
            // radbtnProductAdd
            // 
            this.radbtnProductAdd.Location = new System.Drawing.Point(36, 143);
            this.radbtnProductAdd.Name = "radbtnProductAdd";
            this.radbtnProductAdd.Size = new System.Drawing.Size(85, 21);
            this.radbtnProductAdd.TabIndex = 10;
            this.radbtnProductAdd.Text = "Add";
            this.radbtnProductAdd.ThemeName = "Office2013Light";
            // 
            // radbtnProductEdit
            // 
            this.radbtnProductEdit.Location = new System.Drawing.Point(174, 143);
            this.radbtnProductEdit.Name = "radbtnProductEdit";
            this.radbtnProductEdit.Size = new System.Drawing.Size(85, 21);
            this.radbtnProductEdit.TabIndex = 11;
            this.radbtnProductEdit.Text = "Edit";
            this.radbtnProductEdit.ThemeName = "Office2013Light";
            // 
            // radbtnProductRemove
            // 
            this.radbtnProductRemove.Location = new System.Drawing.Point(311, 143);
            this.radbtnProductRemove.Name = "radbtnProductRemove";
            this.radbtnProductRemove.Size = new System.Drawing.Size(85, 21);
            this.radbtnProductRemove.TabIndex = 11;
            this.radbtnProductRemove.Text = "Remove";
            this.radbtnProductRemove.ThemeName = "Office2013Light";
            // 
            // radgrpbxProducts
            // 
            this.radgrpbxProducts.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxProducts.Controls.Add(this.radgvProducts);
            this.radgrpbxProducts.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgrpbxProducts.ForeColor = System.Drawing.Color.DimGray;
            this.radgrpbxProducts.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxProducts.HeaderText = "Products";
            this.radgrpbxProducts.Location = new System.Drawing.Point(14, 178);
            this.radgrpbxProducts.Name = "radgrpbxProducts";
            this.radgrpbxProducts.Size = new System.Drawing.Size(396, 237);
            this.radgrpbxProducts.TabIndex = 4;
            this.radgrpbxProducts.Text = "Products";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxProducts.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Empty;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxProducts.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radgvProducts
            // 
            this.radgvProducts.Location = new System.Drawing.Point(5, 31);
            // 
            // 
            // 
            this.radgvProducts.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.radgvProducts.Name = "radgvProducts";
            this.radgvProducts.Size = new System.Drawing.Size(386, 201);
            this.radgvProducts.TabIndex = 0;
            // 
            // radbtnProductClose
            // 
            this.radbtnProductClose.Location = new System.Drawing.Point(174, 421);
            this.radbtnProductClose.Name = "radbtnProductClose";
            this.radbtnProductClose.Size = new System.Drawing.Size(85, 21);
            this.radbtnProductClose.TabIndex = 12;
            this.radbtnProductClose.Text = "X  Close";
            this.radbtnProductClose.ThemeName = "Office2013Light";
            this.radbtnProductClose.Click += new System.EventHandler(this.RadbtnProductClose_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 476);
            this.Controls.Add(this.radgrpbxMenu);
            this.Controls.Add(this.radtrvwMenu);
            this.Name = "MainFrm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Main Form";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxMenu)).EndInit();
            this.radgrpbxMenu.ResumeLayout(false);
            this.radgrpbxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radlblMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtrvwMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxProductInformation)).EndInit();
            this.radgrpbxProductInformation.ResumeLayout(false);
            this.radgrpbxProductInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radtxtbxProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcupdwnProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnProductAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnProductEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnProductRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxProducts)).EndInit();
            this.radgrpbxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radgvProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnProductClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxMenu;
        private Telerik.WinControls.UI.RadLabel radlblMenu;
        private Telerik.WinControls.UI.RadTreeView radtrvwMenu;
        private Telerik.WinControls.UI.RadButton radbtnProductRemove;
        private Telerik.WinControls.UI.RadButton radbtnProductEdit;
        private Telerik.WinControls.UI.RadButton radbtnProductAdd;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxProductInformation;
        private System.Windows.Forms.NumericUpDown nmrcupdwnProductQuantity;
        private System.Windows.Forms.Label lblProductQuantity;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.ComboBox cmbbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private Telerik.WinControls.UI.RadTextBox radtxtbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private Telerik.WinControls.UI.RadButton radbtnProductClose;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxProducts;
        private Telerik.WinControls.UI.RadGridView radgvProducts;
    }
}