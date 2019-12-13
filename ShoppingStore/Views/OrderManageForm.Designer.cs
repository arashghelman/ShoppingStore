namespace ShoppingStore.Views
{
    partial class OrderManageFrm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radgrpbxOrders = new Telerik.WinControls.UI.RadGroupBox();
            this.radgrpbxButtons = new Telerik.WinControls.UI.RadGroupBox();
            this.radgvOrders = new Telerik.WinControls.UI.RadGridView();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radbtnNew = new Telerik.WinControls.UI.RadButton();
            this.radbtnEdit = new Telerik.WinControls.UI.RadButton();
            this.radbtnRemove = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxOrders)).BeginInit();
            this.radgrpbxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxButtons)).BeginInit();
            this.radgrpbxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgvOrders.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radgrpbxOrders
            // 
            this.radgrpbxOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxOrders.Controls.Add(this.radgvOrders);
            this.radgrpbxOrders.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgrpbxOrders.ForeColor = System.Drawing.Color.DimGray;
            this.radgrpbxOrders.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxOrders.HeaderText = "Orders";
            this.radgrpbxOrders.Location = new System.Drawing.Point(12, 76);
            this.radgrpbxOrders.Name = "radgrpbxOrders";
            this.radgrpbxOrders.Size = new System.Drawing.Size(407, 260);
            this.radgrpbxOrders.TabIndex = 0;
            this.radgrpbxOrders.Text = "Orders";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radgrpbxOrders.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxOrders.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Empty;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radgrpbxOrders.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radgrpbxButtons
            // 
            this.radgrpbxButtons.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxButtons.Controls.Add(this.radbtnRemove);
            this.radgrpbxButtons.Controls.Add(this.radbtnEdit);
            this.radgrpbxButtons.Controls.Add(this.radbtnNew);
            this.radgrpbxButtons.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radgrpbxButtons.HeaderText = "";
            this.radgrpbxButtons.Location = new System.Drawing.Point(12, 12);
            this.radgrpbxButtons.Name = "radgrpbxButtons";
            this.radgrpbxButtons.Size = new System.Drawing.Size(407, 45);
            this.radgrpbxButtons.TabIndex = 1;
            // 
            // radgvOrders
            // 
            this.radgvOrders.Location = new System.Drawing.Point(5, 30);
            // 
            // 
            // 
            this.radgvOrders.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radgvOrders.Name = "radgvOrders";
            this.radgvOrders.Size = new System.Drawing.Size(397, 225);
            this.radgvOrders.TabIndex = 0;
            this.radgvOrders.ThemeName = "Office2013Light";
            // 
            // radbtnNew
            // 
            this.radbtnNew.Location = new System.Drawing.Point(14, 12);
            this.radbtnNew.Name = "radbtnNew";
            this.radbtnNew.Size = new System.Drawing.Size(97, 24);
            this.radbtnNew.TabIndex = 0;
            this.radbtnNew.Text = "New";
            this.radbtnNew.ThemeName = "Office2013Light";
            this.radbtnNew.Click += new System.EventHandler(this.RadbtnNew_Click);
            // 
            // radbtnEdit
            // 
            this.radbtnEdit.Location = new System.Drawing.Point(156, 12);
            this.radbtnEdit.Name = "radbtnEdit";
            this.radbtnEdit.Size = new System.Drawing.Size(97, 24);
            this.radbtnEdit.TabIndex = 1;
            this.radbtnEdit.Text = "Edit";
            this.radbtnEdit.ThemeName = "Office2013Light";
            this.radbtnEdit.Click += new System.EventHandler(this.RadbtnEdit_Click);
            // 
            // radbtnRemove
            // 
            this.radbtnRemove.Location = new System.Drawing.Point(296, 12);
            this.radbtnRemove.Name = "radbtnRemove";
            this.radbtnRemove.Size = new System.Drawing.Size(97, 24);
            this.radbtnRemove.TabIndex = 2;
            this.radbtnRemove.Text = "Remove";
            this.radbtnRemove.ThemeName = "Office2013Light";
            // 
            // OrderManageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 349);
            this.Controls.Add(this.radgrpbxButtons);
            this.Controls.Add(this.radgrpbxOrders);
            this.Name = "OrderManageFrm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manage Orders";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxOrders)).EndInit();
            this.radgrpbxOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxButtons)).EndInit();
            this.radgrpbxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radgvOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxOrders;
        private Telerik.WinControls.UI.RadGridView radgvOrders;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxButtons;
        private Telerik.WinControls.UI.RadButton radbtnRemove;
        private Telerik.WinControls.UI.RadButton radbtnEdit;
        private Telerik.WinControls.UI.RadButton radbtnNew;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}
