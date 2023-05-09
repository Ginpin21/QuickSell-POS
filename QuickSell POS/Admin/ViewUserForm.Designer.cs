namespace QuickSell_POS
{
    partial class ViewUserForm
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
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.EditGroupBox = new System.Windows.Forms.GroupBox();
            this.UsernameGroupBox = new System.Windows.Forms.GroupBox();
            this.UsernameTxtInput = new System.Windows.Forms.TextBox();
            this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordTxtInput = new System.Windows.Forms.TextBox();
            this.RoleGroupBox = new System.Windows.Forms.GroupBox();
            this.RoleDropDown = new System.Windows.Forms.ComboBox();
            this.EditBtnGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveEditBtn = new System.Windows.Forms.Button();
            this.EditPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.EditGroupBox.SuspendLayout();
            this.UsernameGroupBox.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.RoleGroupBox.SuspendLayout();
            this.EditBtnGroupBox.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.EmployeeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeGridView.ColumnHeadersHeight = 60;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGridView.GridColor = System.Drawing.Color.BlueViolet;
            this.EmployeeGridView.Location = new System.Drawing.Point(0, 0);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.ReadOnly = true;
            this.EmployeeGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmployeeGridView.RowHeadersVisible = false;
            this.EmployeeGridView.RowHeadersWidth = 10;
            this.EmployeeGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeeGridView.RowTemplate.DividerHeight = 2;
            this.EmployeeGridView.RowTemplate.Height = 50;
            this.EmployeeGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGridView.Size = new System.Drawing.Size(1200, 600);
            this.EmployeeGridView.TabIndex = 0;
            this.EmployeeGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_CellDoubleClick);
            // 
            // EditGroupBox
            // 
            this.EditGroupBox.BackColor = System.Drawing.Color.DarkViolet;
            this.EditGroupBox.Controls.Add(this.UsernameGroupBox);
            this.EditGroupBox.Controls.Add(this.PasswordGroupBox);
            this.EditGroupBox.Controls.Add(this.RoleGroupBox);
            this.EditGroupBox.Controls.Add(this.EditBtnGroupBox);
            this.EditGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditGroupBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EditGroupBox.ForeColor = System.Drawing.Color.White;
            this.EditGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EditGroupBox.Name = "EditGroupBox";
            this.EditGroupBox.Size = new System.Drawing.Size(1200, 400);
            this.EditGroupBox.TabIndex = 1;
            this.EditGroupBox.TabStop = false;
            this.EditGroupBox.Text = "Edit/Delete Employee Account";
            // 
            // UsernameGroupBox
            // 
            this.UsernameGroupBox.Controls.Add(this.UsernameTxtInput);
            this.UsernameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsernameGroupBox.ForeColor = System.Drawing.Color.White;
            this.UsernameGroupBox.Location = new System.Drawing.Point(23, 41);
            this.UsernameGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.UsernameGroupBox.Name = "UsernameGroupBox";
            this.UsernameGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.UsernameGroupBox.Size = new System.Drawing.Size(455, 87);
            this.UsernameGroupBox.TabIndex = 1;
            this.UsernameGroupBox.TabStop = false;
            this.UsernameGroupBox.Text = "Username";
            // 
            // UsernameTxtInput
            // 
            this.UsernameTxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTxtInput.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.UsernameTxtInput.ForeColor = System.Drawing.Color.DarkViolet;
            this.UsernameTxtInput.Location = new System.Drawing.Point(5, 32);
            this.UsernameTxtInput.MaxLength = 30;
            this.UsernameTxtInput.Name = "UsernameTxtInput";
            this.UsernameTxtInput.Size = new System.Drawing.Size(445, 47);
            this.UsernameTxtInput.TabIndex = 0;
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.Controls.Add(this.PasswordTxtInput);
            this.PasswordGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordGroupBox.ForeColor = System.Drawing.Color.White;
            this.PasswordGroupBox.Location = new System.Drawing.Point(684, 42);
            this.PasswordGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.PasswordGroupBox.Name = "PasswordGroupBox";
            this.PasswordGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.PasswordGroupBox.Size = new System.Drawing.Size(450, 86);
            this.PasswordGroupBox.TabIndex = 2;
            this.PasswordGroupBox.TabStop = false;
            this.PasswordGroupBox.Text = "Password";
            // 
            // PasswordTxtInput
            // 
            this.PasswordTxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTxtInput.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.PasswordTxtInput.ForeColor = System.Drawing.Color.DarkViolet;
            this.PasswordTxtInput.Location = new System.Drawing.Point(5, 32);
            this.PasswordTxtInput.MaxLength = 30;
            this.PasswordTxtInput.Name = "PasswordTxtInput";
            this.PasswordTxtInput.Size = new System.Drawing.Size(440, 47);
            this.PasswordTxtInput.TabIndex = 1;
            // 
            // RoleGroupBox
            // 
            this.RoleGroupBox.Controls.Add(this.RoleDropDown);
            this.RoleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoleGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RoleGroupBox.ForeColor = System.Drawing.Color.White;
            this.RoleGroupBox.Location = new System.Drawing.Point(28, 168);
            this.RoleGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.RoleGroupBox.Name = "RoleGroupBox";
            this.RoleGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.RoleGroupBox.Size = new System.Drawing.Size(1106, 86);
            this.RoleGroupBox.TabIndex = 3;
            this.RoleGroupBox.TabStop = false;
            this.RoleGroupBox.Text = "Role";
            // 
            // RoleDropDown
            // 
            this.RoleDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleDropDown.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.RoleDropDown.ForeColor = System.Drawing.Color.DarkViolet;
            this.RoleDropDown.FormattingEnabled = true;
            this.RoleDropDown.Location = new System.Drawing.Point(5, 32);
            this.RoleDropDown.Name = "RoleDropDown";
            this.RoleDropDown.Size = new System.Drawing.Size(1096, 49);
            this.RoleDropDown.TabIndex = 0;
            // 
            // EditBtnGroupBox
            // 
            this.EditBtnGroupBox.Controls.Add(this.SaveEditBtn);
            this.EditBtnGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditBtnGroupBox.ForeColor = System.Drawing.Color.White;
            this.EditBtnGroupBox.Location = new System.Drawing.Point(3, 297);
            this.EditBtnGroupBox.Name = "EditBtnGroupBox";
            this.EditBtnGroupBox.Size = new System.Drawing.Size(1194, 100);
            this.EditBtnGroupBox.TabIndex = 6;
            this.EditBtnGroupBox.TabStop = false;
            // 
            // SaveEditBtn
            // 
            this.SaveEditBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.SaveEditBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveEditBtn.FlatAppearance.BorderSize = 0;
            this.SaveEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEditBtn.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SaveEditBtn.ForeColor = System.Drawing.Color.White;
            this.SaveEditBtn.Location = new System.Drawing.Point(3, 21);
            this.SaveEditBtn.Name = "SaveEditBtn";
            this.SaveEditBtn.Size = new System.Drawing.Size(1188, 76);
            this.SaveEditBtn.TabIndex = 5;
            this.SaveEditBtn.Text = "Save Edit";
            this.SaveEditBtn.UseVisualStyleBackColor = false;
            this.SaveEditBtn.Click += new System.EventHandler(this.SaveEditBtn_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.EditGroupBox);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditPanel.Location = new System.Drawing.Point(0, 600);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1200, 400);
            this.EditPanel.TabIndex = 7;
            this.EditPanel.Visible = false;
            // 
            // ViewUserForm
            // 
            this.AccessibleName = "View Users";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.EditPanel);
            this.Name = "ViewUserForm";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.ViewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.EditGroupBox.ResumeLayout(false);
            this.UsernameGroupBox.ResumeLayout(false);
            this.UsernameGroupBox.PerformLayout();
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
            this.RoleGroupBox.ResumeLayout(false);
            this.EditBtnGroupBox.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.GroupBox EditGroupBox;
        private System.Windows.Forms.GroupBox EditBtnGroupBox;
        private System.Windows.Forms.Button SaveEditBtn;
        private System.Windows.Forms.GroupBox RoleGroupBox;
        private System.Windows.Forms.GroupBox UsernameGroupBox;
        private System.Windows.Forms.TextBox UsernameTxtInput;
        private System.Windows.Forms.GroupBox PasswordGroupBox;
        private System.Windows.Forms.TextBox PasswordTxtInput;
        private System.Windows.Forms.ComboBox RoleDropDown;
        private System.Windows.Forms.Panel EditPanel;
    }
}
