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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radgrpbxMenu = new Telerik.WinControls.UI.RadGroupBox();
            this.radlblMenu = new Telerik.WinControls.UI.RadLabel();
            this.radtrvwMenu = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxMenu)).BeginInit();
            this.radgrpbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radlblMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtrvwMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radgrpbxMenu
            // 
            this.radgrpbxMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radgrpbxMenu.Controls.Add(this.radlblMenu);
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
            this.radlblMenu.Location = new System.Drawing.Point(114, 201);
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
            radTreeNode1.BackColor = System.Drawing.Color.LightSkyBlue;
            radTreeNode1.BackColor2 = System.Drawing.Color.White;
            radTreeNode1.Expanded = true;
            radTreeNode1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode1.Name = "Node1";
            radTreeNode2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode2.Name = "Node2";
            radTreeNode2.Text = "Define Product(s)";
            radTreeNode3.Expanded = true;
            radTreeNode3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode3.Name = "Node3";
            radTreeNode3.Text = "Define People";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode3});
            radTreeNode1.Text = "Basic Definitions";
            radTreeNode4.BackColor = System.Drawing.Color.LightSkyBlue;
            radTreeNode4.BackColor2 = System.Drawing.Color.White;
            radTreeNode4.Expanded = true;
            radTreeNode4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode4.Name = "Node4";
            radTreeNode5.Expanded = true;
            radTreeNode5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radTreeNode5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            radTreeNode5.Name = "Node5";
            radTreeNode5.Text = "Submit Order";
            radTreeNode4.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode5});
            radTreeNode4.Text = "Transactions";
            this.radtrvwMenu.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode4});
            this.radtrvwMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radtrvwMenu.Size = new System.Drawing.Size(184, 453);
            this.radtrvwMenu.SpacingBetweenNodes = -1;
            this.radtrvwMenu.TabIndex = 2;
            this.radtrvwMenu.ThemeName = "ControlDefault";
            this.radtrvwMenu.NodeMouseClick += new Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.RadtrvwMenu_NodeMouseClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.radgrpbxMenu)).EndInit();
            this.radgrpbxMenu.ResumeLayout(false);
            this.radgrpbxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radlblMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtrvwMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadGroupBox radgrpbxMenu;
        private Telerik.WinControls.UI.RadLabel radlblMenu;
        private Telerik.WinControls.UI.RadTreeView radtrvwMenu;
    }
}