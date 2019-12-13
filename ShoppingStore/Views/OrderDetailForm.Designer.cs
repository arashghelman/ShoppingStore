﻿namespace ShoppingStore.Views
{
    partial class OrderDetailFrm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailFrm));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radgrpbxSummary = new Telerik.WinControls.UI.RadGroupBox();
            this.radgrpbxPrice = new Telerik.WinControls.UI.RadGroupBox();
            this.lblOrderFinalPrice = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblOrderTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.radbtnClearAll = new Telerik.WinControls.UI.RadButton();
            this.radbtnSubmit = new Telerik.WinControls.UI.RadButton();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.radgrpbxOrderedProducts = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radbtnOrderRemove = new Telerik.WinControls.UI.RadButton();
            this.radgrpbxContactInfo = new Telerik.WinControls.UI.RadGroupBox();
            this.radgrpbxDetail = new Telerik.WinControls.UI.RadGroupBox();
            this.nmrcupdwnQuantity = new System.Windows.Forms.NumericUpDown();
            this.radmlticlmncmbbxCustomer = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radmlticlmncmbbxSalesperson = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.radbtnAdd = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radCheckedListBox1 = new Telerik.WinControls.UI.RadCheckedListBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblSalesperson = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxSummary)).BeginInit();
            this.radgrpbxSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxPrice)).BeginInit();
            this.radgrpbxPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnClearAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxOrderedProducts)).BeginInit();
            this.radgrpbxOrderedProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnOrderRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxContactInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxDetail)).BeginInit();
            this.radgrpbxDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcupdwnQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxCustomer.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxCustomer.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxSalesperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxSalesperson.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxSalesperson.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radgrpbxSummary
            // 
            this.radgrpbxSummary.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxSummary.Controls.Add(this.radgrpbxPrice);
            this.radgrpbxSummary.Controls.Add(this.radbtnClearAll);
            this.radgrpbxSummary.Controls.Add(this.radbtnSubmit);
            this.radgrpbxSummary.Controls.Add(this.lblOrderCode);
            this.radgrpbxSummary.Controls.Add(this.lblCode);
            this.radgrpbxSummary.Controls.Add(this.lblOrderDate);
            this.radgrpbxSummary.Controls.Add(this.lblDate);
            this.radgrpbxSummary.Controls.Add(this.radgrpbxOrderedProducts);
            this.radgrpbxSummary.Controls.Add(this.radgrpbxContactInfo);
            this.radgrpbxSummary.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgrpbxSummary.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxSummary.HeaderText = "Summary";
            this.radgrpbxSummary.Location = new System.Drawing.Point(351, 12);
            this.radgrpbxSummary.Name = "radgrpbxSummary";
            this.radgrpbxSummary.Size = new System.Drawing.Size(459, 589);
            this.radgrpbxSummary.TabIndex = 3;
            this.radgrpbxSummary.Text = "Summary";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radgrpbxSummary.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radgrpbxSummary.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxSummary.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Empty;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxSummary.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radgrpbxPrice
            // 
            this.radgrpbxPrice.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxPrice.Controls.Add(this.lblOrderFinalPrice);
            this.radgrpbxPrice.Controls.Add(this.lblFinalPrice);
            this.radgrpbxPrice.Controls.Add(this.lblOrderTotalPrice);
            this.radgrpbxPrice.Controls.Add(this.lblTotalPrice);
            this.radgrpbxPrice.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxPrice.HeaderText = "";
            this.radgrpbxPrice.Location = new System.Drawing.Point(16, 439);
            this.radgrpbxPrice.Name = "radgrpbxPrice";
            this.radgrpbxPrice.Size = new System.Drawing.Size(427, 67);
            this.radgrpbxPrice.TabIndex = 4;
            // 
            // lblOrderFinalPrice
            // 
            this.lblOrderFinalPrice.AutoSize = true;
            this.lblOrderFinalPrice.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderFinalPrice.Location = new System.Drawing.Point(318, 9);
            this.lblOrderFinalPrice.Name = "lblOrderFinalPrice";
            this.lblOrderFinalPrice.Size = new System.Drawing.Size(104, 18);
            this.lblOrderFinalPrice.TabIndex = 3;
            this.lblOrderFinalPrice.Text = "OrderFinalPrice";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblFinalPrice.Location = new System.Drawing.Point(242, 9);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(78, 18);
            this.lblFinalPrice.TabIndex = 2;
            this.lblFinalPrice.Text = "Final Price :";
            // 
            // lblOrderTotalPrice
            // 
            this.lblOrderTotalPrice.AutoSize = true;
            this.lblOrderTotalPrice.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalPrice.Location = new System.Drawing.Point(87, 9);
            this.lblOrderTotalPrice.Name = "lblOrderTotalPrice";
            this.lblOrderTotalPrice.Size = new System.Drawing.Size(105, 18);
            this.lblOrderTotalPrice.TabIndex = 1;
            this.lblOrderTotalPrice.Text = "OrderTotalPrice";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalPrice.Location = new System.Drawing.Point(11, 9);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(79, 18);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // radbtnClearAll
            // 
            this.radbtnClearAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnClearAll.Location = new System.Drawing.Point(333, 531);
            this.radbtnClearAll.Name = "radbtnClearAll";
            this.radbtnClearAll.Size = new System.Drawing.Size(110, 32);
            this.radbtnClearAll.TabIndex = 9;
            this.radbtnClearAll.Text = "Clear All";
            this.radbtnClearAll.ThemeName = "Office2013Light";
            // 
            // radbtnSubmit
            // 
            this.radbtnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnSubmit.Location = new System.Drawing.Point(16, 527);
            this.radbtnSubmit.Name = "radbtnSubmit";
            this.radbtnSubmit.Size = new System.Drawing.Size(110, 32);
            this.radbtnSubmit.TabIndex = 8;
            this.radbtnSubmit.Text = "Submit";
            this.radbtnSubmit.ThemeName = "Office2013Light";
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.AutoSize = true;
            this.lblOrderCode.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCode.Location = new System.Drawing.Point(358, 52);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(85, 21);
            this.lblOrderCode.TabIndex = 7;
            this.lblOrderCode.Text = "OrderCode";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.DimGray;
            this.lblCode.Location = new System.Drawing.Point(308, 52);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(54, 21);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Code :";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(59, 52);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(81, 21);
            this.lblOrderDate.TabIndex = 5;
            this.lblOrderDate.Text = "OrderDate";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(12, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 21);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date :";
            // 
            // radgrpbxOrderedProducts
            // 
            this.radgrpbxOrderedProducts.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxOrderedProducts.Controls.Add(this.radGridView1);
            this.radgrpbxOrderedProducts.Controls.Add(this.radbtnOrderRemove);
            this.radgrpbxOrderedProducts.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgrpbxOrderedProducts.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxOrderedProducts.HeaderText = "Ordered Products";
            this.radgrpbxOrderedProducts.Location = new System.Drawing.Point(16, 194);
            this.radgrpbxOrderedProducts.Name = "radgrpbxOrderedProducts";
            this.radgrpbxOrderedProducts.Size = new System.Drawing.Size(427, 239);
            this.radgrpbxOrderedProducts.TabIndex = 3;
            this.radgrpbxOrderedProducts.Text = "Ordered Products";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radgrpbxOrderedProducts.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxOrderedProducts.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Empty;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxOrderedProducts.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(15, 30);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(397, 160);
            this.radGridView1.TabIndex = 9;
            // 
            // radbtnOrderRemove
            // 
            this.radbtnOrderRemove.Location = new System.Drawing.Point(328, 206);
            this.radbtnOrderRemove.Name = "radbtnOrderRemove";
            this.radbtnOrderRemove.Size = new System.Drawing.Size(84, 22);
            this.radbtnOrderRemove.TabIndex = 8;
            this.radbtnOrderRemove.Text = "Remove";
            this.radbtnOrderRemove.ThemeName = "Office2013Light";
            // 
            // radgrpbxContactInfo
            // 
            this.radgrpbxContactInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxContactInfo.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgrpbxContactInfo.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxContactInfo.HeaderText = "Contact Info";
            this.radgrpbxContactInfo.Location = new System.Drawing.Point(16, 85);
            this.radgrpbxContactInfo.Name = "radgrpbxContactInfo";
            this.radgrpbxContactInfo.Size = new System.Drawing.Size(427, 103);
            this.radgrpbxContactInfo.TabIndex = 2;
            this.radgrpbxContactInfo.Text = "Contact Info";
            ((Telerik.WinControls.UI.RadGroupBoxElement)(this.radgrpbxContactInfo.GetChildAt(0))).InvalidateMeasureInMainLayout = 3;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radgrpbxContactInfo.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxContactInfo.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Empty;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxContactInfo.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radgrpbxDetail
            // 
            this.radgrpbxDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxDetail.Controls.Add(this.nmrcupdwnQuantity);
            this.radgrpbxDetail.Controls.Add(this.radmlticlmncmbbxCustomer);
            this.radgrpbxDetail.Controls.Add(this.radmlticlmncmbbxSalesperson);
            this.radgrpbxDetail.Controls.Add(this.lblQuantity);
            this.radgrpbxDetail.Controls.Add(this.radbtnAdd);
            this.radgrpbxDetail.Controls.Add(this.label1);
            this.radgrpbxDetail.Controls.Add(this.radCheckedListBox1);
            this.radgrpbxDetail.Controls.Add(this.lblCustomer);
            this.radgrpbxDetail.Controls.Add(this.lblSalesperson);
            this.radgrpbxDetail.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgrpbxDetail.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxDetail.HeaderText = "Order Details";
            this.radgrpbxDetail.HeaderTextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radgrpbxDetail.Location = new System.Drawing.Point(12, 12);
            this.radgrpbxDetail.Name = "radgrpbxDetail";
            this.radgrpbxDetail.Size = new System.Drawing.Size(333, 589);
            this.radgrpbxDetail.TabIndex = 2;
            this.radgrpbxDetail.Text = "Order Details";
            this.radgrpbxDetail.ThemeName = "ControlDefault";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1))).BorderHighlightColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Empty;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSize = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1).GetChildAt(1))).TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(203)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1).GetChildAt(1))).TopShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(203)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radgrpbxDetail.GetChildAt(0).GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // nmrcupdwnQuantity
            // 
            this.nmrcupdwnQuantity.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcupdwnQuantity.Location = new System.Drawing.Point(259, 502);
            this.nmrcupdwnQuantity.Name = "nmrcupdwnQuantity";
            this.nmrcupdwnQuantity.Size = new System.Drawing.Size(48, 23);
            this.nmrcupdwnQuantity.TabIndex = 12;
            // 
            // radmlticlmncmbbxCustomer
            // 
            // 
            // radmlticlmncmbbxCustomer.NestedRadGridView
            // 
            this.radmlticlmncmbbxCustomer.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radmlticlmncmbbxCustomer.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmlticlmncmbbxCustomer.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radmlticlmncmbbxCustomer.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radmlticlmncmbbxCustomer.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radmlticlmncmbbxCustomer.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radmlticlmncmbbxCustomer.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radmlticlmncmbbxCustomer.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radmlticlmncmbbxCustomer.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radmlticlmncmbbxCustomer.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radmlticlmncmbbxCustomer.EditorControl.Name = "NestedRadGridView";
            this.radmlticlmncmbbxCustomer.EditorControl.ReadOnly = true;
            this.radmlticlmncmbbxCustomer.EditorControl.ShowGroupPanel = false;
            this.radmlticlmncmbbxCustomer.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radmlticlmncmbbxCustomer.EditorControl.TabIndex = 0;
            this.radmlticlmncmbbxCustomer.ForeColor = System.Drawing.Color.Gray;
            this.radmlticlmncmbbxCustomer.Location = new System.Drawing.Point(25, 165);
            this.radmlticlmncmbbxCustomer.Name = "radmlticlmncmbbxCustomer";
            this.radmlticlmncmbbxCustomer.Size = new System.Drawing.Size(283, 21);
            this.radmlticlmncmbbxCustomer.TabIndex = 11;
            this.radmlticlmncmbbxCustomer.TabStop = false;
            this.radmlticlmncmbbxCustomer.Text = "Select a customer for this order...";
            this.radmlticlmncmbbxCustomer.ThemeName = "Office2013Light";
            // 
            // radmlticlmncmbbxSalesperson
            // 
            // 
            // radmlticlmncmbbxSalesperson.NestedRadGridView
            // 
            this.radmlticlmncmbbxSalesperson.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radmlticlmncmbbxSalesperson.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmlticlmncmbbxSalesperson.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radmlticlmncmbbxSalesperson.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radmlticlmncmbbxSalesperson.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radmlticlmncmbbxSalesperson.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radmlticlmncmbbxSalesperson.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radmlticlmncmbbxSalesperson.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radmlticlmncmbbxSalesperson.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radmlticlmncmbbxSalesperson.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radmlticlmncmbbxSalesperson.EditorControl.Name = "NestedRadGridView";
            this.radmlticlmncmbbxSalesperson.EditorControl.ReadOnly = true;
            this.radmlticlmncmbbxSalesperson.EditorControl.ShowGroupPanel = false;
            this.radmlticlmncmbbxSalesperson.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radmlticlmncmbbxSalesperson.EditorControl.TabIndex = 0;
            this.radmlticlmncmbbxSalesperson.ForeColor = System.Drawing.Color.Gray;
            this.radmlticlmncmbbxSalesperson.Location = new System.Drawing.Point(25, 85);
            this.radmlticlmncmbbxSalesperson.Name = "radmlticlmncmbbxSalesperson";
            this.radmlticlmncmbbxSalesperson.Size = new System.Drawing.Size(283, 21);
            this.radmlticlmncmbbxSalesperson.TabIndex = 10;
            this.radmlticlmncmbbxSalesperson.TabStop = false;
            this.radmlticlmncmbbxSalesperson.Text = "Select a salesperson for this order...";
            this.radmlticlmncmbbxSalesperson.ThemeName = "Office2013Light";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(22, 502);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 15);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity :";
            // 
            // radbtnAdd
            // 
            this.radbtnAdd.Location = new System.Drawing.Point(25, 537);
            this.radbtnAdd.Name = "radbtnAdd";
            this.radbtnAdd.Size = new System.Drawing.Size(84, 22);
            this.radbtnAdd.TabIndex = 7;
            this.radbtnAdd.Text = "Add";
            this.radbtnAdd.ThemeName = "Office2013Light";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DengXian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "What would you like to order?";
            // 
            // radCheckedListBox1
            // 
            this.radCheckedListBox1.Location = new System.Drawing.Point(25, 261);
            this.radCheckedListBox1.Name = "radCheckedListBox1";
            this.radCheckedListBox1.Size = new System.Drawing.Size(282, 235);
            this.radCheckedListBox1.TabIndex = 4;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(21, 135);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(75, 18);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer :";
            // 
            // lblSalesperson
            // 
            this.lblSalesperson.AutoSize = true;
            this.lblSalesperson.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesperson.Location = new System.Drawing.Point(21, 55);
            this.lblSalesperson.Name = "lblSalesperson";
            this.lblSalesperson.Size = new System.Drawing.Size(88, 18);
            this.lblSalesperson.TabIndex = 1;
            this.lblSalesperson.Text = "Salesperson :";
            // 
            // OrderDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 613);
            this.Controls.Add(this.radgrpbxSummary);
            this.Controls.Add(this.radgrpbxDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderDetailFrm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Create a New Order";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxSummary)).EndInit();
            this.radgrpbxSummary.ResumeLayout(false);
            this.radgrpbxSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxPrice)).EndInit();
            this.radgrpbxPrice.ResumeLayout(false);
            this.radgrpbxPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnClearAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxOrderedProducts)).EndInit();
            this.radgrpbxOrderedProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnOrderRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxContactInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxDetail)).EndInit();
            this.radgrpbxDetail.ResumeLayout(false);
            this.radgrpbxDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcupdwnQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxCustomer.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxCustomer.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxSalesperson.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxSalesperson.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmlticlmncmbbxSalesperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxSummary;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxPrice;
        private System.Windows.Forms.Label lblOrderFinalPrice;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblOrderTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private Telerik.WinControls.UI.RadButton radbtnClearAll;
        private Telerik.WinControls.UI.RadButton radbtnSubmit;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblDate;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxOrderedProducts;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radbtnOrderRemove;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxContactInfo;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxDetail;
        private System.Windows.Forms.NumericUpDown nmrcupdwnQuantity;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radmlticlmncmbbxCustomer;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radmlticlmncmbbxSalesperson;
        private System.Windows.Forms.Label lblQuantity;
        private Telerik.WinControls.UI.RadButton radbtnAdd;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadCheckedListBox radCheckedListBox1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblSalesperson;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}
