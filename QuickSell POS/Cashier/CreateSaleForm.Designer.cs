namespace QuickSell_POS.Cashier
{
    partial class CreateSaleForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToSaleBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductGridGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterProductsBtn = new System.Windows.Forms.Button();
            this.ProductCategoryDropDown = new System.Windows.Forms.ComboBox();
            this.SaleItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.SaleItemsGridView = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CompleteSaleBtn = new System.Windows.Forms.Button();
            this.GrandTotalGroupBox = new System.Windows.Forms.GroupBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.ProductGridGroupBox.SuspendLayout();
            this.SaleItemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsGridView)).BeginInit();
            this.GrandTotalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.ProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProductGridView.ColumnHeadersHeight = 60;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qty,
            this.AddToSaleBtn});
            this.ProductGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.ProductGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGridView.GridColor = System.Drawing.Color.BlueViolet;
            this.ProductGridView.Location = new System.Drawing.Point(5, 134);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ProductGridView.RowHeadersVisible = false;
            this.ProductGridView.RowHeadersWidth = 10;
            this.ProductGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductGridView.RowTemplate.DividerHeight = 2;
            this.ProductGridView.RowTemplate.Height = 50;
            this.ProductGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGridView.Size = new System.Drawing.Size(1190, 411);
            this.ProductGridView.TabIndex = 2;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            this.ProductGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellDoubleClick);
            this.ProductGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ProductGridView_EditingControlShowing);
            // 
            // Qty
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.BlueViolet;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle9;
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Qty.Width = 125;
            // 
            // AddToSaleBtn
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.AddToSaleBtn.DefaultCellStyle = dataGridViewCellStyle10;
            this.AddToSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToSaleBtn.HeaderText = "Add";
            this.AddToSaleBtn.MinimumWidth = 6;
            this.AddToSaleBtn.Name = "AddToSaleBtn";
            this.AddToSaleBtn.Text = "Add";
            this.AddToSaleBtn.UseColumnTextForButtonValue = true;
            this.AddToSaleBtn.Width = 125;
            // 
            // ProductGridGroupBox
            // 
            this.ProductGridGroupBox.Controls.Add(this.ProductGridView);
            this.ProductGridGroupBox.Controls.Add(this.FilterProductsBtn);
            this.ProductGridGroupBox.Controls.Add(this.ProductCategoryDropDown);
            this.ProductGridGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGridGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductGridGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductGridGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductGridGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ProductGridGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.ProductGridGroupBox.Name = "ProductGridGroupBox";
            this.ProductGridGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductGridGroupBox.Size = new System.Drawing.Size(1200, 550);
            this.ProductGridGroupBox.TabIndex = 3;
            this.ProductGridGroupBox.TabStop = false;
            this.ProductGridGroupBox.Text = "Select the Products";
            // 
            // FilterProductsBtn
            // 
            this.FilterProductsBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.FilterProductsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterProductsBtn.FlatAppearance.BorderSize = 0;
            this.FilterProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterProductsBtn.Location = new System.Drawing.Point(5, 81);
            this.FilterProductsBtn.Name = "FilterProductsBtn";
            this.FilterProductsBtn.Size = new System.Drawing.Size(1190, 53);
            this.FilterProductsBtn.TabIndex = 4;
            this.FilterProductsBtn.Text = "Filter Products";
            this.FilterProductsBtn.UseVisualStyleBackColor = false;
            this.FilterProductsBtn.Click += new System.EventHandler(this.FilterProductsBtn_Click);
            // 
            // ProductCategoryDropDown
            // 
            this.ProductCategoryDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductCategoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategoryDropDown.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ProductCategoryDropDown.FormattingEnabled = true;
            this.ProductCategoryDropDown.ItemHeight = 41;
            this.ProductCategoryDropDown.Location = new System.Drawing.Point(5, 32);
            this.ProductCategoryDropDown.Name = "ProductCategoryDropDown";
            this.ProductCategoryDropDown.Size = new System.Drawing.Size(1190, 49);
            this.ProductCategoryDropDown.TabIndex = 3;
            // 
            // SaleItemsGroupBox
            // 
            this.SaleItemsGroupBox.Controls.Add(this.SaleItemsGridView);
            this.SaleItemsGroupBox.Controls.Add(this.GrandTotalGroupBox);
            this.SaleItemsGroupBox.Controls.Add(this.CompleteSaleBtn);
            this.SaleItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaleItemsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SaleItemsGroupBox.ForeColor = System.Drawing.Color.White;
            this.SaleItemsGroupBox.Location = new System.Drawing.Point(0, 550);
            this.SaleItemsGroupBox.Name = "SaleItemsGroupBox";
            this.SaleItemsGroupBox.Size = new System.Drawing.Size(1200, 450);
            this.SaleItemsGroupBox.TabIndex = 6;
            this.SaleItemsGroupBox.TabStop = false;
            this.SaleItemsGroupBox.Text = "Sale Products";
            // 
            // SaleItemsGridView
            // 
            this.SaleItemsGridView.AllowUserToDeleteRows = false;
            this.SaleItemsGridView.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.SaleItemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleItemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.SaleItemsGridView.ColumnHeadersHeight = 60;
            this.SaleItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SaleItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity,
            this.SubTotal,
            this.RemoveBtn});
            this.SaleItemsGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleItemsGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.SaleItemsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleItemsGridView.GridColor = System.Drawing.Color.BlueViolet;
            this.SaleItemsGridView.Location = new System.Drawing.Point(3, 30);
            this.SaleItemsGridView.MultiSelect = false;
            this.SaleItemsGridView.Name = "SaleItemsGridView";
            this.SaleItemsGridView.ReadOnly = true;
            this.SaleItemsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SaleItemsGridView.RowHeadersVisible = false;
            this.SaleItemsGridView.RowHeadersWidth = 300;
            this.SaleItemsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SaleItemsGridView.RowTemplate.DividerHeight = 2;
            this.SaleItemsGridView.RowTemplate.Height = 50;
            this.SaleItemsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleItemsGridView.Size = new System.Drawing.Size(1194, 276);
            this.SaleItemsGridView.TabIndex = 2;
            this.SaleItemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleItemsGridView_CellContentClick);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 300;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 200;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.MinimumWidth = 6;
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            this.ProductQuantity.Width = 200;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 200;
            // 
            // RemoveBtn
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.DefaultCellStyle = dataGridViewCellStyle13;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.HeaderText = "Remove";
            this.RemoveBtn.MinimumWidth = 6;
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.ReadOnly = true;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseColumnTextForButtonValue = true;
            this.RemoveBtn.Width = 125;
            // 
            // CompleteSaleBtn
            // 
            this.CompleteSaleBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.CompleteSaleBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CompleteSaleBtn.FlatAppearance.BorderSize = 0;
            this.CompleteSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompleteSaleBtn.Location = new System.Drawing.Point(3, 394);
            this.CompleteSaleBtn.Name = "CompleteSaleBtn";
            this.CompleteSaleBtn.Size = new System.Drawing.Size(1194, 53);
            this.CompleteSaleBtn.TabIndex = 5;
            this.CompleteSaleBtn.Text = "Complete Sale";
            this.CompleteSaleBtn.UseVisualStyleBackColor = false;
            this.CompleteSaleBtn.Click += new System.EventHandler(this.CompleteSaleBtn_Click);
            // 
            // GrandTotalGroupBox
            // 
            this.GrandTotalGroupBox.Controls.Add(this.label1);
            this.GrandTotalGroupBox.Controls.Add(this.GrandTotalLabel);
            this.GrandTotalGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrandTotalGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GrandTotalGroupBox.ForeColor = System.Drawing.Color.White;
            this.GrandTotalGroupBox.Location = new System.Drawing.Point(3, 306);
            this.GrandTotalGroupBox.Name = "GrandTotalGroupBox";
            this.GrandTotalGroupBox.Size = new System.Drawing.Size(1194, 88);
            this.GrandTotalGroupBox.TabIndex = 7;
            this.GrandTotalGroupBox.TabStop = false;
            this.GrandTotalGroupBox.Text = "Grand Total";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GrandTotalLabel.Location = new System.Drawing.Point(3, 30);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(23, 28);
            this.GrandTotalLabel.TabIndex = 1;
            this.GrandTotalLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "AED";
            // 
            // CreateSaleForm
            // 
            this.AccessibleName = "Start a Sale";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ProductGridGroupBox);
            this.Controls.Add(this.SaleItemsGroupBox);
            this.DoubleBuffered = true;
            this.Name = "CreateSaleForm";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.CreateSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ProductGridGroupBox.ResumeLayout(false);
            this.SaleItemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsGridView)).EndInit();
            this.GrandTotalGroupBox.ResumeLayout(false);
            this.GrandTotalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Button FilterProductsBtn;
        private System.Windows.Forms.ComboBox ProductCategoryDropDown;
        private System.Windows.Forms.GroupBox ProductGridGroupBox;
        private System.Windows.Forms.GroupBox SaleItemsGroupBox;
        private System.Windows.Forms.DataGridView SaleItemsGridView;
        private System.Windows.Forms.Button CompleteSaleBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewButtonColumn AddToSaleBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveBtn;
        private System.Windows.Forms.GroupBox GrandTotalGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GrandTotalLabel;
    }
}
