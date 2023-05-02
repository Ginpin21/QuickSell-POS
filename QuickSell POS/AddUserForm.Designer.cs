namespace QuickSell_POS
{
    partial class AddUserForm
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
            this.AddUserGroupBox = new System.Windows.Forms.GroupBox();
            this.RoleGroupBox = new System.Windows.Forms.GroupBox();
            this.RoleDropDown = new System.Windows.Forms.ComboBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.CPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.CPasswordTxtInput = new System.Windows.Forms.TextBox();
            this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordTxtInput = new System.Windows.Forms.TextBox();
            this.UsernameGroupBox = new System.Windows.Forms.GroupBox();
            this.UsernameTxtInput = new System.Windows.Forms.TextBox();
            this.AddUserGroupBox.SuspendLayout();
            this.RoleGroupBox.SuspendLayout();
            this.CPasswordGroupBox.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.UsernameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddUserGroupBox
            // 
            this.AddUserGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUserGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.AddUserGroupBox.Controls.Add(this.RoleGroupBox);
            this.AddUserGroupBox.Controls.Add(this.AddUserBtn);
            this.AddUserGroupBox.Controls.Add(this.CPasswordGroupBox);
            this.AddUserGroupBox.Controls.Add(this.PasswordGroupBox);
            this.AddUserGroupBox.Controls.Add(this.UsernameGroupBox);
            this.AddUserGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserGroupBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserGroupBox.ForeColor = System.Drawing.Color.White;
            this.AddUserGroupBox.Location = new System.Drawing.Point(284, 4);
            this.AddUserGroupBox.Name = "AddUserGroupBox";
            this.AddUserGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddUserGroupBox.Size = new System.Drawing.Size(500, 779);
            this.AddUserGroupBox.TabIndex = 1;
            this.AddUserGroupBox.TabStop = false;
            this.AddUserGroupBox.Text = "Add User";
            // 
            // RoleGroupBox
            // 
            this.RoleGroupBox.Controls.Add(this.RoleDropDown);
            this.RoleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoleGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RoleGroupBox.ForeColor = System.Drawing.Color.White;
            this.RoleGroupBox.Location = new System.Drawing.Point(23, 542);
            this.RoleGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.RoleGroupBox.Name = "RoleGroupBox";
            this.RoleGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.RoleGroupBox.Size = new System.Drawing.Size(454, 87);
            this.RoleGroupBox.TabIndex = 3;
            this.RoleGroupBox.TabStop = false;
            this.RoleGroupBox.Text = "Select a Role";
            // 
            // RoleDropDown
            // 
            this.RoleDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleDropDown.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.RoleDropDown.FormattingEnabled = true;
            this.RoleDropDown.Location = new System.Drawing.Point(5, 32);
            this.RoleDropDown.Name = "RoleDropDown";
            this.RoleDropDown.Size = new System.Drawing.Size(444, 49);
            this.RoleDropDown.TabIndex = 3;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.AddUserBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddUserBtn.FlatAppearance.BorderSize = 0;
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserBtn.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.AddUserBtn.ForeColor = System.Drawing.Color.White;
            this.AddUserBtn.Location = new System.Drawing.Point(3, 696);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(494, 80);
            this.AddUserBtn.TabIndex = 2;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // CPasswordGroupBox
            // 
            this.CPasswordGroupBox.Controls.Add(this.CPasswordTxtInput);
            this.CPasswordGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPasswordGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CPasswordGroupBox.ForeColor = System.Drawing.Color.White;
            this.CPasswordGroupBox.Location = new System.Drawing.Point(23, 415);
            this.CPasswordGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.CPasswordGroupBox.Name = "CPasswordGroupBox";
            this.CPasswordGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CPasswordGroupBox.Size = new System.Drawing.Size(454, 87);
            this.CPasswordGroupBox.TabIndex = 2;
            this.CPasswordGroupBox.TabStop = false;
            this.CPasswordGroupBox.Text = "Confirm Password";
            // 
            // CPasswordTxtInput
            // 
            this.CPasswordTxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPasswordTxtInput.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.CPasswordTxtInput.ForeColor = System.Drawing.Color.DarkViolet;
            this.CPasswordTxtInput.Location = new System.Drawing.Point(5, 32);
            this.CPasswordTxtInput.MaxLength = 30;
            this.CPasswordTxtInput.Name = "CPasswordTxtInput";
            this.CPasswordTxtInput.Size = new System.Drawing.Size(444, 47);
            this.CPasswordTxtInput.TabIndex = 0;
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.Controls.Add(this.PasswordTxtInput);
            this.PasswordGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordGroupBox.ForeColor = System.Drawing.Color.White;
            this.PasswordGroupBox.Location = new System.Drawing.Point(23, 250);
            this.PasswordGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.PasswordGroupBox.Name = "PasswordGroupBox";
            this.PasswordGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.PasswordGroupBox.Size = new System.Drawing.Size(454, 87);
            this.PasswordGroupBox.TabIndex = 1;
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
            this.PasswordTxtInput.Size = new System.Drawing.Size(444, 47);
            this.PasswordTxtInput.TabIndex = 0;
            // 
            // UsernameGroupBox
            // 
            this.UsernameGroupBox.Controls.Add(this.UsernameTxtInput);
            this.UsernameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsernameGroupBox.ForeColor = System.Drawing.Color.White;
            this.UsernameGroupBox.Location = new System.Drawing.Point(23, 90);
            this.UsernameGroupBox.Margin = new System.Windows.Forms.Padding(20);
            this.UsernameGroupBox.Name = "UsernameGroupBox";
            this.UsernameGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.UsernameGroupBox.Size = new System.Drawing.Size(454, 87);
            this.UsernameGroupBox.TabIndex = 0;
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
            this.UsernameTxtInput.Size = new System.Drawing.Size(444, 47);
            this.UsernameTxtInput.TabIndex = 0;
            // 
            // AddUserForm
            // 
            this.AccessibleName = "Add User";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.AddUserGroupBox);
            this.Name = "AddUserForm";
            this.Size = new System.Drawing.Size(1068, 821);
            this.AddUserGroupBox.ResumeLayout(false);
            this.RoleGroupBox.ResumeLayout(false);
            this.CPasswordGroupBox.ResumeLayout(false);
            this.CPasswordGroupBox.PerformLayout();
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
            this.UsernameGroupBox.ResumeLayout(false);
            this.UsernameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddUserGroupBox;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.GroupBox CPasswordGroupBox;
        private System.Windows.Forms.TextBox CPasswordTxtInput;
        private System.Windows.Forms.GroupBox PasswordGroupBox;
        private System.Windows.Forms.TextBox PasswordTxtInput;
        private System.Windows.Forms.GroupBox UsernameGroupBox;
        private System.Windows.Forms.TextBox UsernameTxtInput;
        private System.Windows.Forms.ComboBox RoleDropDown;
        private System.Windows.Forms.GroupBox RoleGroupBox;
    }
}
