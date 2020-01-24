namespace ShoppingStore.Views
{
    partial class CategoryFrm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryFrm));
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.radBtnRemove = new Telerik.WinControls.UI.RadButton();
            this.radBtnEdit = new Telerik.WinControls.UI.RadButton();
            this.radBtnAdd = new Telerik.WinControls.UI.RadButton();
            this.radgvCategories = new Telerik.WinControls.UI.RadGridView();
            this.radtxtbxCategoryName = new Telerik.WinControls.UI.RadTextBox();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgvCategories.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtxtbxCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(21, 23);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(48, 15);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Name : ";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblCategoryId);
            this.radGroupBox1.Controls.Add(this.radBtnRemove);
            this.radGroupBox1.Controls.Add(this.radBtnEdit);
            this.radGroupBox1.Controls.Add(this.radBtnAdd);
            this.radGroupBox1.Controls.Add(this.radgvCategories);
            this.radGroupBox1.Controls.Add(this.radtxtbxCategoryName);
            this.radGroupBox1.Controls.Add(this.lblCategoryName);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(294, 259);
            this.radGroupBox1.TabIndex = 1;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Empty;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(6, 7);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(0, 13);
            this.lblCategoryId.TabIndex = 6;
            this.lblCategoryId.Visible = false;
            // 
            // radBtnRemove
            // 
            this.radBtnRemove.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnRemove.Location = new System.Drawing.Point(210, 59);
            this.radBtnRemove.Name = "radBtnRemove";
            this.radBtnRemove.Size = new System.Drawing.Size(79, 24);
            this.radBtnRemove.TabIndex = 5;
            this.radBtnRemove.Text = "Remove";
            this.radBtnRemove.ThemeName = "Office2013Light";
            this.radBtnRemove.Click += new System.EventHandler(this.RadBtnRemove_Click);
            // 
            // radBtnEdit
            // 
            this.radBtnEdit.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnEdit.Location = new System.Drawing.Point(110, 59);
            this.radBtnEdit.Name = "radBtnEdit";
            this.radBtnEdit.Size = new System.Drawing.Size(79, 24);
            this.radBtnEdit.TabIndex = 4;
            this.radBtnEdit.Text = "Edit";
            this.radBtnEdit.ThemeName = "Office2013Light";
            this.radBtnEdit.Click += new System.EventHandler(this.RadBtnEdit_Click);
            // 
            // radBtnAdd
            // 
            this.radBtnAdd.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnAdd.Location = new System.Drawing.Point(5, 59);
            this.radBtnAdd.Name = "radBtnAdd";
            this.radBtnAdd.Size = new System.Drawing.Size(79, 24);
            this.radBtnAdd.TabIndex = 3;
            this.radBtnAdd.Text = "Add";
            this.radBtnAdd.ThemeName = "Office2013Light";
            this.radBtnAdd.Click += new System.EventHandler(this.RadBtnAdd_Click);
            // 
            // radgvCategories
            // 
            this.radgvCategories.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgvCategories.Location = new System.Drawing.Point(5, 89);
            // 
            // 
            // 
            this.radgvCategories.MasterTemplate.AllowAddNewRow = false;
            this.radgvCategories.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radgvCategories.Name = "radgvCategories";
            this.radgvCategories.ReadOnly = true;
            this.radgvCategories.Size = new System.Drawing.Size(284, 165);
            this.radgvCategories.TabIndex = 2;
            this.radgvCategories.ThemeName = "Office2013Light";
            this.radgvCategories.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.RadgvCategories_CellClick);
            // 
            // radtxtbxCategoryName
            // 
            this.radtxtbxCategoryName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtxtbxCategoryName.Location = new System.Drawing.Point(81, 21);
            this.radtxtbxCategoryName.Name = "radtxtbxCategoryName";
            this.radtxtbxCategoryName.Size = new System.Drawing.Size(186, 21);
            this.radtxtbxCategoryName.TabIndex = 1;
            // 
            // CategoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 283);
            this.Controls.Add(this.radGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoryFrm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Define Categories";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.CategoryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgvCategories.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtxtbxCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radBtnRemove;
        private Telerik.WinControls.UI.RadButton radBtnEdit;
        private Telerik.WinControls.UI.RadButton radBtnAdd;
        private Telerik.WinControls.UI.RadGridView radgvCategories;
        private Telerik.WinControls.UI.RadTextBox radtxtbxCategoryName;
        private System.Windows.Forms.Label lblCategoryId;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}
