namespace QuickSell_POS
{
    partial class AdminWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CurrentStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.ActiveWindowLabel = new System.Windows.Forms.Label();
            this.CurrentUserLabel = new System.Windows.Forms.Label();
            this.CurrentRoleLabel = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ExitPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.NavPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddUserNavBtn = new System.Windows.Forms.Button();
            this.ViewUserNavBtn = new System.Windows.Forms.Button();
            this.EditUserNavBtn = new System.Windows.Forms.Button();
            this.DeleteUserNavBtn = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.HomeNavBtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.CurrentStatusGroupBox.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            this.NavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(400, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(782, 953);
            this.MainPanel.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.TopPanel.Controls.Add(this.CurrentStatusGroupBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(782, 52);
            this.TopPanel.TabIndex = 0;
            // 
            // CurrentStatusGroupBox
            // 
            this.CurrentStatusGroupBox.Controls.Add(this.ActiveWindowLabel);
            this.CurrentStatusGroupBox.Controls.Add(this.CurrentUserLabel);
            this.CurrentStatusGroupBox.Controls.Add(this.CurrentRoleLabel);
            this.CurrentStatusGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentStatusGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentStatusGroupBox.ForeColor = System.Drawing.Color.White;
            this.CurrentStatusGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CurrentStatusGroupBox.Name = "CurrentStatusGroupBox";
            this.CurrentStatusGroupBox.Size = new System.Drawing.Size(782, 52);
            this.CurrentStatusGroupBox.TabIndex = 1;
            this.CurrentStatusGroupBox.TabStop = false;
            this.CurrentStatusGroupBox.Text = "Current Status";
            // 
            // ActiveWindowLabel
            // 
            this.ActiveWindowLabel.AutoSize = true;
            this.ActiveWindowLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ActiveWindowLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveWindowLabel.ForeColor = System.Drawing.Color.White;
            this.ActiveWindowLabel.Location = new System.Drawing.Point(3, 18);
            this.ActiveWindowLabel.Name = "ActiveWindowLabel";
            this.ActiveWindowLabel.Size = new System.Drawing.Size(194, 32);
            this.ActiveWindowLabel.TabIndex = 2;
            this.ActiveWindowLabel.Text = "Active Window:";
            this.ActiveWindowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentUserLabel
            // 
            this.CurrentUserLabel.AutoSize = true;
            this.CurrentUserLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CurrentUserLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUserLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentUserLabel.Location = new System.Drawing.Point(621, 18);
            this.CurrentUserLabel.Name = "CurrentUserLabel";
            this.CurrentUserLabel.Size = new System.Drawing.Size(80, 32);
            this.CurrentUserLabel.TabIndex = 0;
            this.CurrentUserLabel.Text = "User: ";
            this.CurrentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentRoleLabel
            // 
            this.CurrentRoleLabel.AutoSize = true;
            this.CurrentRoleLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CurrentRoleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentRoleLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentRoleLabel.Location = new System.Drawing.Point(701, 18);
            this.CurrentRoleLabel.Name = "CurrentRoleLabel";
            this.CurrentRoleLabel.Size = new System.Drawing.Size(78, 32);
            this.CurrentRoleLabel.TabIndex = 1;
            this.CurrentRoleLabel.Text = "Role: ";
            this.CurrentRoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DarkViolet;
            this.SidePanel.Controls.Add(this.ExitPanel);
            this.SidePanel.Controls.Add(this.NavPanel);
            this.SidePanel.Controls.Add(this.LogoBox);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(400, 953);
            this.SidePanel.TabIndex = 0;
            // 
            // ExitPanel
            // 
            this.ExitPanel.Controls.Add(this.ExitBtn);
            this.ExitPanel.Controls.Add(this.LogoutBtn);
            this.ExitPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.ExitPanel.Location = new System.Drawing.Point(0, 640);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(400, 313);
            this.ExitPanel.TabIndex = 4;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(3, 260);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(397, 50);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit Application";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Thistle;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.LogoutBtn.Location = new System.Drawing.Point(3, 204);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(397, 50);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            // 
            // NavPanel
            // 
            this.NavPanel.Controls.Add(this.HomeNavBtn);
            this.NavPanel.Controls.Add(this.AddUserNavBtn);
            this.NavPanel.Controls.Add(this.ViewUserNavBtn);
            this.NavPanel.Controls.Add(this.EditUserNavBtn);
            this.NavPanel.Controls.Add(this.DeleteUserNavBtn);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPanel.Location = new System.Drawing.Point(0, 262);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(400, 371);
            this.NavPanel.TabIndex = 0;
            // 
            // AddUserNavBtn
            // 
            this.AddUserNavBtn.BackColor = System.Drawing.Color.White;
            this.AddUserNavBtn.FlatAppearance.BorderSize = 0;
            this.AddUserNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddUserNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddUserNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserNavBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserNavBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.AddUserNavBtn.Location = new System.Drawing.Point(3, 59);
            this.AddUserNavBtn.Name = "AddUserNavBtn";
            this.AddUserNavBtn.Size = new System.Drawing.Size(397, 50);
            this.AddUserNavBtn.TabIndex = 2;
            this.AddUserNavBtn.Text = "Add User";
            this.AddUserNavBtn.UseVisualStyleBackColor = false;
            this.AddUserNavBtn.Click += new System.EventHandler(this.AddUserNavBtn_Click);
            // 
            // ViewUserNavBtn
            // 
            this.ViewUserNavBtn.BackColor = System.Drawing.Color.White;
            this.ViewUserNavBtn.FlatAppearance.BorderSize = 0;
            this.ViewUserNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ViewUserNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ViewUserNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewUserNavBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUserNavBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.ViewUserNavBtn.Location = new System.Drawing.Point(3, 115);
            this.ViewUserNavBtn.Name = "ViewUserNavBtn";
            this.ViewUserNavBtn.Size = new System.Drawing.Size(397, 50);
            this.ViewUserNavBtn.TabIndex = 1;
            this.ViewUserNavBtn.Text = "View Users";
            this.ViewUserNavBtn.UseVisualStyleBackColor = false;
            this.ViewUserNavBtn.Click += new System.EventHandler(this.ViewUserNavBtn_Click);
            // 
            // EditUserNavBtn
            // 
            this.EditUserNavBtn.BackColor = System.Drawing.Color.White;
            this.EditUserNavBtn.FlatAppearance.BorderSize = 0;
            this.EditUserNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.EditUserNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.EditUserNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUserNavBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserNavBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.EditUserNavBtn.Location = new System.Drawing.Point(3, 171);
            this.EditUserNavBtn.Name = "EditUserNavBtn";
            this.EditUserNavBtn.Size = new System.Drawing.Size(397, 50);
            this.EditUserNavBtn.TabIndex = 0;
            this.EditUserNavBtn.Text = "Edit User";
            this.EditUserNavBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteUserNavBtn
            // 
            this.DeleteUserNavBtn.BackColor = System.Drawing.Color.White;
            this.DeleteUserNavBtn.FlatAppearance.BorderSize = 0;
            this.DeleteUserNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.DeleteUserNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DeleteUserNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserNavBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserNavBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.DeleteUserNavBtn.Location = new System.Drawing.Point(3, 227);
            this.DeleteUserNavBtn.Name = "DeleteUserNavBtn";
            this.DeleteUserNavBtn.Size = new System.Drawing.Size(397, 50);
            this.DeleteUserNavBtn.TabIndex = 3;
            this.DeleteUserNavBtn.Text = "Delete User";
            this.DeleteUserNavBtn.UseVisualStyleBackColor = false;
            // 
            // LogoBox
            // 
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(0, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(400, 262);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            // 
            // HomeNavBtn
            // 
            this.HomeNavBtn.BackColor = System.Drawing.Color.White;
            this.HomeNavBtn.FlatAppearance.BorderSize = 0;
            this.HomeNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.HomeNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.HomeNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeNavBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeNavBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.HomeNavBtn.Location = new System.Drawing.Point(3, 3);
            this.HomeNavBtn.Name = "HomeNavBtn";
            this.HomeNavBtn.Size = new System.Drawing.Size(397, 50);
            this.HomeNavBtn.TabIndex = 4;
            this.HomeNavBtn.Text = "Home";
            this.HomeNavBtn.UseVisualStyleBackColor = false;
            this.HomeNavBtn.Click += new System.EventHandler(this.HomeNavBtn_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidePanel);
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "AdminWindow";
            this.Text = "Admin WIndow";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.CurrentStatusGroupBox.ResumeLayout(false);
            this.CurrentStatusGroupBox.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.ExitPanel.ResumeLayout(false);
            this.NavPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.FlowLayoutPanel NavPanel;
        private System.Windows.Forms.Button EditUserNavBtn;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button AddUserNavBtn;
        private System.Windows.Forms.Button ViewUserNavBtn;
        private System.Windows.Forms.Button DeleteUserNavBtn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label CurrentUserLabel;
        private System.Windows.Forms.FlowLayoutPanel ExitPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.GroupBox CurrentStatusGroupBox;
        private System.Windows.Forms.Label CurrentRoleLabel;
        private System.Windows.Forms.Label ActiveWindowLabel;
        private System.Windows.Forms.Button HomeNavBtn;
    }
}

