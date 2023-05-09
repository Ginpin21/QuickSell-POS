namespace QuickSell_POS.Manager
{
    partial class ViewProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.EditGroupBox = new System.Windows.Forms.GroupBox();
            this.EditBtnGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.SaveEditBtn = new System.Windows.Forms.Button();
            this.ProductStockGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductStockNumBox = new System.Windows.Forms.NumericUpDown();
            this.ProductPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.AED = new System.Windows.Forms.Label();
            this.ProductPriceNumBox = new System.Windows.Forms.NumericUpDown();
            this.ProductNameGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductNameTxtInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.EditGroupBox.SuspendLayout();
            this.EditBtnGroupBox.SuspendLayout();
            this.ProductStockGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStockNumBox)).BeginInit();
            this.ProductPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumBox)).BeginInit();
            this.ProductNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.ProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductGridView.ColumnHeadersHeight = 60;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGridView.GridColor = System.Drawing.Color.BlueViolet;
            this.ProductGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ProductGridView.RowHeadersVisible = false;
            this.ProductGridView.RowHeadersWidth = 10;
            this.ProductGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductGridView.RowTemplate.DividerHeight = 2;
            this.ProductGridView.RowTemplate.Height = 50;
            this.ProductGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGridView.Size = new System.Drawing.Size(1200, 626);
            this.ProductGridView.TabIndex = 1;
            this.ProductGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellDoubleClick);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.EditPanel.Controls.Add(this.EditGroupBox);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditPanel.Location = new System.Drawing.Point(0, 626);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1200, 374);
            this.EditPanel.TabIndex = 2;
            this.EditPanel.Visible = false;
            // 
            // EditGroupBox
            // 
            this.EditGroupBox.Controls.Add(this.EditBtnGroupBox);
            this.EditGroupBox.Controls.Add(this.ProductStockGroupBox);
            this.EditGroupBox.Controls.Add(this.ProductPriceGroupBox);
            this.EditGroupBox.Controls.Add(this.ProductNameGroupBox);
            this.EditGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditGroupBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EditGroupBox.ForeColor = System.Drawing.Color.White;
            this.EditGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EditGroupBox.Name = "EditGroupBox";
            this.EditGroupBox.Size = new System.Drawing.Size(1200, 374);
            this.EditGroupBox.TabIndex = 0;
            this.EditGroupBox.TabStop = false;
            this.EditGroupBox.Text = "Edit/Delete Product";
            // 
            // EditBtnGroupBox
            // 
            this.EditBtnGroupBox.Controls.Add(this.DeleteProductBtn);
            this.EditBtnGroupBox.Controls.Add(this.SaveEditBtn);
            this.EditBtnGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditBtnGroupBox.ForeColor = System.Drawing.Color.White;
            this.EditBtnGroupBox.Location = new System.Drawing.Point(3, 271);
            this.EditBtnGroupBox.Name = "EditBtnGroupBox";
            this.EditBtnGroupBox.Size = new System.Drawing.Size(1194, 100);
            this.EditBtnGroupBox.TabIndex = 6;
            this.EditBtnGroupBox.TabStop = false;
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.DeleteProductBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteProductBtn.FlatAppearance.BorderSize = 0;
            this.DeleteProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductBtn.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.DeleteProductBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteProductBtn.Location = new System.Drawing.Point(641, 21);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(550, 76);
            this.DeleteProductBtn.TabIndex = 6;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // SaveEditBtn
            // 
            this.SaveEditBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.SaveEditBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveEditBtn.FlatAppearance.BorderSize = 0;
            this.SaveEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEditBtn.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SaveEditBtn.ForeColor = System.Drawing.Color.White;
            this.SaveEditBtn.Location = new System.Drawing.Point(3, 21);
            this.SaveEditBtn.Name = "SaveEditBtn";
            this.SaveEditBtn.Size = new System.Drawing.Size(550, 76);
            this.SaveEditBtn.TabIndex = 5;
            this.SaveEditBtn.Text = "Save Edit";
            this.SaveEditBtn.UseVisualStyleBackColor = false;
            this.SaveEditBtn.Click += new System.EventHandler(this.SaveEditBtn_Click);
            // 
            // ProductStockGroupBox
            // 
            this.ProductStockGroupBox.Controls.Add(this.ProductStockNumBox);
            this.ProductStockGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductStockGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductStockGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductStockGroupBox.Location = new System.Drawing.Point(684, 168);
            this.ProductStockGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.ProductStockGroupBox.Name = "ProductStockGroupBox";
            this.ProductStockGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductStockGroupBox.Size = new System.Drawing.Size(450, 86);
            this.ProductStockGroupBox.TabIndex = 3;
            this.ProductStockGroupBox.TabStop = false;
            this.ProductStockGroupBox.Text = "Product Stock";
            // 
            // ProductStockNumBox
            // 
            this.ProductStockNumBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductStockNumBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductStockNumBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ProductStockNumBox.Location = new System.Drawing.Point(5, 32);
            this.ProductStockNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductStockNumBox.Name = "ProductStockNumBox";
            this.ProductStockNumBox.Size = new System.Drawing.Size(440, 43);
            this.ProductStockNumBox.TabIndex = 5;
            this.ProductStockNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductStockNumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductPriceGroupBox
            // 
            this.ProductPriceGroupBox.Controls.Add(this.AED);
            this.ProductPriceGroupBox.Controls.Add(this.ProductPriceNumBox);
            this.ProductPriceGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductPriceGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductPriceGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductPriceGroupBox.Location = new System.Drawing.Point(28, 168);
            this.ProductPriceGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.ProductPriceGroupBox.Name = "ProductPriceGroupBox";
            this.ProductPriceGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductPriceGroupBox.Size = new System.Drawing.Size(450, 86);
            this.ProductPriceGroupBox.TabIndex = 2;
            this.ProductPriceGroupBox.TabStop = false;
            this.ProductPriceGroupBox.Text = "Product Price";
            // 
            // AED
            // 
            this.AED.AutoSize = true;
            this.AED.Dock = System.Windows.Forms.DockStyle.Right;
            this.AED.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.AED.Location = new System.Drawing.Point(372, 32);
            this.AED.Name = "AED";
            this.AED.Size = new System.Drawing.Size(73, 41);
            this.AED.TabIndex = 4;
            this.AED.Text = "AED";
            // 
            // ProductPriceNumBox
            // 
            this.ProductPriceNumBox.AccessibleName = "View Products";
            this.ProductPriceNumBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductPriceNumBox.DecimalPlaces = 2;
            this.ProductPriceNumBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProductPriceNumBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ProductPriceNumBox.Location = new System.Drawing.Point(5, 32);
            this.ProductPriceNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ProductPriceNumBox.Name = "ProductPriceNumBox";
            this.ProductPriceNumBox.Size = new System.Drawing.Size(361, 43);
            this.ProductPriceNumBox.TabIndex = 3;
            this.ProductPriceNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductPriceNumBox.ThousandsSeparator = true;
            this.ProductPriceNumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductNameGroupBox
            // 
            this.ProductNameGroupBox.Controls.Add(this.ProductNameTxtInput);
            this.ProductNameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductNameGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductNameGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductNameGroupBox.Location = new System.Drawing.Point(23, 41);
            this.ProductNameGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.ProductNameGroupBox.Name = "ProductNameGroupBox";
            this.ProductNameGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductNameGroupBox.Size = new System.Drawing.Size(1116, 87);
            this.ProductNameGroupBox.TabIndex = 1;
            this.ProductNameGroupBox.TabStop = false;
            this.ProductNameGroupBox.Text = "Product Name";
            // 
            // ProductNameTxtInput
            // 
            this.ProductNameTxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductNameTxtInput.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ProductNameTxtInput.ForeColor = System.Drawing.Color.DarkViolet;
            this.ProductNameTxtInput.Location = new System.Drawing.Point(5, 32);
            this.ProductNameTxtInput.MaxLength = 30;
            this.ProductNameTxtInput.Name = "ProductNameTxtInput";
            this.ProductNameTxtInput.Size = new System.Drawing.Size(1106, 47);
            this.ProductNameTxtInput.TabIndex = 0;
            // 
            // ViewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.EditPanel);
            this.Name = "ViewProductForm";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.ViewProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditGroupBox.ResumeLayout(false);
            this.EditBtnGroupBox.ResumeLayout(false);
            this.ProductStockGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductStockNumBox)).EndInit();
            this.ProductPriceGroupBox.ResumeLayout(false);
            this.ProductPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumBox)).EndInit();
            this.ProductNameGroupBox.ResumeLayout(false);
            this.ProductNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.GroupBox EditGroupBox;
        private System.Windows.Forms.GroupBox ProductNameGroupBox;
        private System.Windows.Forms.TextBox ProductNameTxtInput;
        private System.Windows.Forms.GroupBox ProductPriceGroupBox;
        private System.Windows.Forms.Label AED;
        private System.Windows.Forms.NumericUpDown ProductPriceNumBox;
        private System.Windows.Forms.GroupBox ProductStockGroupBox;
        private System.Windows.Forms.NumericUpDown ProductStockNumBox;
        private System.Windows.Forms.GroupBox EditBtnGroupBox;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button SaveEditBtn;
    }
}
