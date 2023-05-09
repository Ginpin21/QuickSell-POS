namespace QuickSell_POS
{
    partial class LoginWindow
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
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordTxtInput = new System.Windows.Forms.TextBox();
            this.UsernameGroupBox = new System.Windows.Forms.GroupBox();
            this.UsernameTxtInput = new System.Windows.Forms.TextBox();
            this.LoginScreenLogo = new System.Windows.Forms.PictureBox();
            this.LoginGroupBox.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.UsernameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginScreenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginGroupBox.Controls.Add(this.LoginBtn);
            this.LoginGroupBox.Controls.Add(this.PasswordGroupBox);
            this.LoginGroupBox.Controls.Add(this.UsernameGroupBox);
            this.LoginGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginGroupBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.ForeColor = System.Drawing.Color.DarkViolet;
            this.LoginGroupBox.Location = new System.Drawing.Point(350, 367);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginGroupBox.Size = new System.Drawing.Size(500, 500);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.LoginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(3, 417);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(494, 80);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.Controls.Add(this.PasswordTxtInput);
            this.PasswordGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordGroupBox.ForeColor = System.Drawing.Color.DarkViolet;
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
            this.PasswordTxtInput.PasswordChar = '*';
            this.PasswordTxtInput.Size = new System.Drawing.Size(444, 47);
            this.PasswordTxtInput.TabIndex = 0;
            this.PasswordTxtInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // UsernameGroupBox
            // 
            this.UsernameGroupBox.Controls.Add(this.UsernameTxtInput);
            this.UsernameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsernameGroupBox.ForeColor = System.Drawing.Color.DarkViolet;
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
            this.UsernameTxtInput.TextChanged += new System.EventHandler(this.UsernameTxtInput_TextChanged);
            // 
            // LoginScreenLogo
            // 
            this.LoginScreenLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginScreenLogo.Image = global::QuickSell_POS.Properties.Resources.quicksell_pos_system_high_resolution_logo_black_on_transparent_background;
            this.LoginScreenLogo.Location = new System.Drawing.Point(390, 12);
            this.LoginScreenLogo.Name = "LoginScreenLogo";
            this.LoginScreenLogo.Size = new System.Drawing.Size(394, 349);
            this.LoginScreenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginScreenLogo.TabIndex = 1;
            this.LoginScreenLogo.TabStop = false;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.LoginScreenLogo);
            this.Controls.Add(this.LoginGroupBox);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "LoginWindow";
            this.Text = "QuickSell Login";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LoginGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
            this.UsernameGroupBox.ResumeLayout(false);
            this.UsernameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginScreenLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.GroupBox UsernameGroupBox;
        private System.Windows.Forms.TextBox UsernameTxtInput;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.GroupBox PasswordGroupBox;
        private System.Windows.Forms.TextBox PasswordTxtInput;
        private System.Windows.Forms.PictureBox LoginScreenLogo;
    }
}