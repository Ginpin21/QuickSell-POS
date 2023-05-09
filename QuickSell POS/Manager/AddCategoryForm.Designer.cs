namespace QuickSell_POS.Manager
{
    partial class AddCategoryForm
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
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.CategoryDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryDescriptionTxtInput = new System.Windows.Forms.TextBox();
            this.CategoryNameGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryNameTxtInput = new System.Windows.Forms.TextBox();
            this.CategoryGroupBox.SuspendLayout();
            this.CategoryDescriptionGroupBox.SuspendLayout();
            this.CategoryNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.AccessibleName = "Add Category";
            this.CategoryGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.CategoryGroupBox.Controls.Add(this.AddCategoryBtn);
            this.CategoryGroupBox.Controls.Add(this.CategoryDescriptionGroupBox);
            this.CategoryGroupBox.Controls.Add(this.CategoryNameGroupBox);
            this.CategoryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryGroupBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryGroupBox.ForeColor = System.Drawing.Color.White;
            this.CategoryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryGroupBox.Size = new System.Drawing.Size(1045, 639);
            this.CategoryGroupBox.TabIndex = 1;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Add Category";
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.AddCategoryBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCategoryBtn.FlatAppearance.BorderSize = 0;
            this.AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.AddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.AddCategoryBtn.Location = new System.Drawing.Point(3, 556);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(1039, 80);
            this.AddCategoryBtn.TabIndex = 2;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // CategoryDescriptionGroupBox
            // 
            this.CategoryDescriptionGroupBox.Controls.Add(this.CategoryDescriptionTxtInput);
            this.CategoryDescriptionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryDescriptionGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CategoryDescriptionGroupBox.ForeColor = System.Drawing.Color.White;
            this.CategoryDescriptionGroupBox.Location = new System.Drawing.Point(23, 250);
            this.CategoryDescriptionGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.CategoryDescriptionGroupBox.Name = "CategoryDescriptionGroupBox";
            this.CategoryDescriptionGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CategoryDescriptionGroupBox.Size = new System.Drawing.Size(997, 256);
            this.CategoryDescriptionGroupBox.TabIndex = 1;
            this.CategoryDescriptionGroupBox.TabStop = false;
            this.CategoryDescriptionGroupBox.Text = "Category Description";
            // 
            // CategoryDescriptionTxtInput
            // 
            this.CategoryDescriptionTxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryDescriptionTxtInput.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.CategoryDescriptionTxtInput.ForeColor = System.Drawing.Color.DarkViolet;
            this.CategoryDescriptionTxtInput.Location = new System.Drawing.Point(5, 32);
            this.CategoryDescriptionTxtInput.MaxLength = 255;
            this.CategoryDescriptionTxtInput.Multiline = true;
            this.CategoryDescriptionTxtInput.Name = "CategoryDescriptionTxtInput";
            this.CategoryDescriptionTxtInput.Size = new System.Drawing.Size(987, 219);
            this.CategoryDescriptionTxtInput.TabIndex = 0;
            // 
            // CategoryNameGroupBox
            // 
            this.CategoryNameGroupBox.Controls.Add(this.CategoryNameTxtInput);
            this.CategoryNameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryNameGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CategoryNameGroupBox.ForeColor = System.Drawing.Color.White;
            this.CategoryNameGroupBox.Location = new System.Drawing.Point(23, 90);
            this.CategoryNameGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.CategoryNameGroupBox.Name = "CategoryNameGroupBox";
            this.CategoryNameGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CategoryNameGroupBox.Size = new System.Drawing.Size(1002, 87);
            this.CategoryNameGroupBox.TabIndex = 0;
            this.CategoryNameGroupBox.TabStop = false;
            this.CategoryNameGroupBox.Text = "Category Name";
            // 
            // CategoryNameTxtInput
            // 
            this.CategoryNameTxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryNameTxtInput.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.CategoryNameTxtInput.ForeColor = System.Drawing.Color.DarkViolet;
            this.CategoryNameTxtInput.Location = new System.Drawing.Point(5, 32);
            this.CategoryNameTxtInput.MaxLength = 30;
            this.CategoryNameTxtInput.Name = "CategoryNameTxtInput";
            this.CategoryNameTxtInput.Size = new System.Drawing.Size(992, 47);
            this.CategoryNameTxtInput.TabIndex = 0;
            // 
            // AddCategoryForm
            // 
            this.AccessibleName = "Add Category";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CategoryGroupBox);
            this.Name = "AddCategoryForm";
            this.Size = new System.Drawing.Size(1045, 639);
            this.CategoryGroupBox.ResumeLayout(false);
            this.CategoryDescriptionGroupBox.ResumeLayout(false);
            this.CategoryDescriptionGroupBox.PerformLayout();
            this.CategoryNameGroupBox.ResumeLayout(false);
            this.CategoryNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.GroupBox CategoryDescriptionGroupBox;
        private System.Windows.Forms.TextBox CategoryDescriptionTxtInput;
        private System.Windows.Forms.GroupBox CategoryNameGroupBox;
        private System.Windows.Forms.TextBox CategoryNameTxtInput;
    }
}
