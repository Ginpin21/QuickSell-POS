namespace QuickSell_POS.Manager
{
    partial class AddProductForm
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
            this.ProductGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductCategoryDropDown = new System.Windows.Forms.ComboBox();
            this.ProductStockGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductStockNumBox = new System.Windows.Forms.NumericUpDown();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.AED = new System.Windows.Forms.Label();
            this.ProductPriceNumBox = new System.Windows.Forms.NumericUpDown();
            this.ProductNameGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductNameTxtInput = new System.Windows.Forms.TextBox();
            this.ProductGroupBox.SuspendLayout();
            this.ProductCategoryGroupBox.SuspendLayout();
            this.ProductStockGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStockNumBox)).BeginInit();
            this.ProductPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumBox)).BeginInit();
            this.ProductNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGroupBox
            // 
            this.ProductGroupBox.AccessibleName = "Add Product";
            this.ProductGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductGroupBox.Controls.Add(this.ProductCategoryGroupBox);
            this.ProductGroupBox.Controls.Add(this.ProductStockGroupBox);
            this.ProductGroupBox.Controls.Add(this.AddProductBtn);
            this.ProductGroupBox.Controls.Add(this.ProductPriceGroupBox);
            this.ProductGroupBox.Controls.Add(this.ProductNameGroupBox);
            this.ProductGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductGroupBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductGroupBox.Size = new System.Drawing.Size(1045, 602);
            this.ProductGroupBox.TabIndex = 2;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Add Product";
            // 
            // ProductCategoryGroupBox
            // 
            this.ProductCategoryGroupBox.Controls.Add(this.ProductCategoryDropDown);
            this.ProductCategoryGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductCategoryGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductCategoryGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductCategoryGroupBox.Location = new System.Drawing.Point(23, 370);
            this.ProductCategoryGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.ProductCategoryGroupBox.Name = "ProductCategoryGroupBox";
            this.ProductCategoryGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductCategoryGroupBox.Size = new System.Drawing.Size(1002, 90);
            this.ProductCategoryGroupBox.TabIndex = 2;
            this.ProductCategoryGroupBox.TabStop = false;
            this.ProductCategoryGroupBox.Text = "Product Category";
            // 
            // ProductCategoryDropDown
            // 
            this.ProductCategoryDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductCategoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategoryDropDown.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ProductCategoryDropDown.FormattingEnabled = true;
            this.ProductCategoryDropDown.ItemHeight = 41;
            this.ProductCategoryDropDown.Location = new System.Drawing.Point(5, 32);
            this.ProductCategoryDropDown.Name = "ProductCategoryDropDown";
            this.ProductCategoryDropDown.Size = new System.Drawing.Size(992, 49);
            this.ProductCategoryDropDown.TabIndex = 3;
            // 
            // ProductStockGroupBox
            // 
            this.ProductStockGroupBox.Controls.Add(this.ProductStockNumBox);
            this.ProductStockGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductStockGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductStockGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductStockGroupBox.Location = new System.Drawing.Point(570, 217);
            this.ProductStockGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.ProductStockGroupBox.Name = "ProductStockGroupBox";
            this.ProductStockGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductStockGroupBox.Size = new System.Drawing.Size(450, 86);
            this.ProductStockGroupBox.TabIndex = 2;
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
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.AddProductBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddProductBtn.FlatAppearance.BorderSize = 0;
            this.AddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductBtn.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.AddProductBtn.ForeColor = System.Drawing.Color.White;
            this.AddProductBtn.Location = new System.Drawing.Point(3, 519);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(1039, 80);
            this.AddProductBtn.TabIndex = 2;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductPriceGroupBox
            // 
            this.ProductPriceGroupBox.Controls.Add(this.AED);
            this.ProductPriceGroupBox.Controls.Add(this.ProductPriceNumBox);
            this.ProductPriceGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductPriceGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductPriceGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductPriceGroupBox.Location = new System.Drawing.Point(23, 217);
            this.ProductPriceGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.ProductPriceGroupBox.Name = "ProductPriceGroupBox";
            this.ProductPriceGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductPriceGroupBox.Size = new System.Drawing.Size(450, 86);
            this.ProductPriceGroupBox.TabIndex = 1;
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
            this.ProductNameGroupBox.Location = new System.Drawing.Point(23, 90);
            this.ProductNameGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.ProductNameGroupBox.Name = "ProductNameGroupBox";
            this.ProductNameGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductNameGroupBox.Size = new System.Drawing.Size(1002, 87);
            this.ProductNameGroupBox.TabIndex = 0;
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
            this.ProductNameTxtInput.Size = new System.Drawing.Size(992, 47);
            this.ProductNameTxtInput.TabIndex = 0;
            // 
            // AddProductForm
            // 
            this.AccessibleName = "Add Product";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ProductGroupBox);
            this.Name = "AddProductForm";
            this.Size = new System.Drawing.Size(1045, 602);
            this.ProductGroupBox.ResumeLayout(false);
            this.ProductCategoryGroupBox.ResumeLayout(false);
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

        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.GroupBox ProductPriceGroupBox;
        private System.Windows.Forms.GroupBox ProductNameGroupBox;
        private System.Windows.Forms.TextBox ProductNameTxtInput;
        private System.Windows.Forms.GroupBox ProductStockGroupBox;
        private System.Windows.Forms.GroupBox ProductCategoryGroupBox;
        private System.Windows.Forms.ComboBox ProductCategoryDropDown;
        private System.Windows.Forms.Label AED;
        private System.Windows.Forms.NumericUpDown ProductPriceNumBox;
        private System.Windows.Forms.NumericUpDown ProductStockNumBox;
    }
}
