namespace QuickSell_POS.Cashier
{
    partial class ViewTodaySaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesGridView
            // 
            this.SalesGridView.AllowUserToDeleteRows = false;
            this.SalesGridView.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.SalesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SalesGridView.ColumnHeadersHeight = 60;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SalesGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.SalesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesGridView.GridColor = System.Drawing.Color.BlueViolet;
            this.SalesGridView.Location = new System.Drawing.Point(0, 0);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.ReadOnly = true;
            this.SalesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SalesGridView.RowHeadersVisible = false;
            this.SalesGridView.RowHeadersWidth = 10;
            this.SalesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SalesGridView.RowTemplate.DividerHeight = 2;
            this.SalesGridView.RowTemplate.Height = 50;
            this.SalesGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesGridView.Size = new System.Drawing.Size(1200, 1000);
            this.SalesGridView.TabIndex = 1;
            // 
            // ViewTodaySaleForm
            // 
            this.AccessibleName = "Today\'s Sales";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SalesGridView);
            this.Name = "ViewTodaySaleForm";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.ViewTodaySaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesGridView;
    }
}
