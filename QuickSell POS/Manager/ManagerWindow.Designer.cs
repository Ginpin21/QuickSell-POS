namespace QuickSell_POS.Manager
{
    partial class ManagerWindow
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CurrentStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.ActiveWindowLabel = new System.Windows.Forms.Label();
            this.CurrentUserLabel = new System.Windows.Forms.Label();
            this.CurrentRoleLabel = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ExitPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NavPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeNavBtn = new System.Windows.Forms.Button();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ViewProductBtn = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
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
            this.MainPanel.TabIndex = 3;
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
            this.CurrentStatusGroupBox.Font = new System.Drawing.Font("Segoe UI", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.SidePanel.TabIndex = 2;
            // 
            // ExitPanel
            // 
            this.ExitPanel.Controls.Add(this.ExitBtn);
            this.ExitPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.ExitPanel.Location = new System.Drawing.Point(0, 830);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(400, 123);
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
            this.ExitBtn.Location = new System.Drawing.Point(3, 70);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(397, 50);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit Application";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NavPanel
            // 
            this.NavPanel.Controls.Add(this.HomeNavBtn);
            this.NavPanel.Controls.Add(this.AddCategoryBtn);
            this.NavPanel.Controls.Add(this.AddProductBtn);
            this.NavPanel.Controls.Add(this.ViewProductBtn);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPanel.Location = new System.Drawing.Point(0, 420);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(400, 439);
            this.NavPanel.TabIndex = 0;
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
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.Color.White;
            this.AddCategoryBtn.FlatAppearance.BorderSize = 0;
            this.AddCategoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddCategoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.AddCategoryBtn.Location = new System.Drawing.Point(3, 59);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(397, 50);
            this.AddCategoryBtn.TabIndex = 2;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.Color.White;
            this.AddProductBtn.FlatAppearance.BorderSize = 0;
            this.AddProductBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AddProductBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.AddProductBtn.Location = new System.Drawing.Point(3, 115);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(397, 50);
            this.AddProductBtn.TabIndex = 1;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ViewProductBtn
            // 
            this.ViewProductBtn.BackColor = System.Drawing.Color.White;
            this.ViewProductBtn.FlatAppearance.BorderSize = 0;
            this.ViewProductBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ViewProductBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ViewProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProductBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProductBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.ViewProductBtn.Location = new System.Drawing.Point(3, 171);
            this.ViewProductBtn.Name = "ViewProductBtn";
            this.ViewProductBtn.Size = new System.Drawing.Size(397, 50);
            this.ViewProductBtn.TabIndex = 0;
            this.ViewProductBtn.Text = "View Products";
            this.ViewProductBtn.UseVisualStyleBackColor = false;
            this.ViewProductBtn.Click += new System.EventHandler(this.ViewProductBtn_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBox.Image = global::QuickSell_POS.Properties.Resources.quicksell_pos_system_high_resolution_logo_color_on_transparent_background;
            this.LogoBox.Location = new System.Drawing.Point(0, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(400, 420);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidePanel);
            this.Name = "ManagerWindow";
            this.Text = "Manager Form";
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
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.GroupBox CurrentStatusGroupBox;
        private System.Windows.Forms.Label ActiveWindowLabel;
        private System.Windows.Forms.Label CurrentUserLabel;
        private System.Windows.Forms.Label CurrentRoleLabel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.FlowLayoutPanel ExitPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.FlowLayoutPanel NavPanel;
        private System.Windows.Forms.Button HomeNavBtn;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button ViewProductBtn;
        private System.Windows.Forms.PictureBox LogoBox;
    }
}