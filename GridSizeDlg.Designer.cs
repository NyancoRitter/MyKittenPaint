
namespace MyKittenPaint
{
	partial class GridSizeDlg
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
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.The_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.X_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Y_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.OK_button = new System.Windows.Forms.Button();
			this.Cancel_button = new System.Windows.Forms.Button();
			this.The_tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.X_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Y_numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// The_tableLayoutPanel
			// 
			this.The_tableLayoutPanel.ColumnCount = 2;
			this.The_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.The_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.The_tableLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.The_tableLayoutPanel.Controls.Add(this.label2, 0, 1);
			this.The_tableLayoutPanel.Controls.Add(this.label3, 1, 1);
			this.The_tableLayoutPanel.Controls.Add(this.X_numericUpDown, 0, 2);
			this.The_tableLayoutPanel.Controls.Add(this.Y_numericUpDown, 1, 2);
			this.The_tableLayoutPanel.Controls.Add(this.OK_button, 1, 3);
			this.The_tableLayoutPanel.Controls.Add(this.Cancel_button, 0, 3);
			this.The_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.The_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.The_tableLayoutPanel.Name = "The_tableLayoutPanel";
			this.The_tableLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
			this.The_tableLayoutPanel.RowCount = 4;
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.Size = new System.Drawing.Size(317, 169);
			this.The_tableLayoutPanel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.The_tableLayoutPanel.SetColumnSpan(this.label1, 2);
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(11, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Image Interval :";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "X";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(225, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Y";
			// 
			// X_numericUpDown
			// 
			this.X_numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.X_numericUpDown.Location = new System.Drawing.Point(23, 53);
			this.X_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.X_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.X_numericUpDown.Name = "X_numericUpDown";
			this.X_numericUpDown.Size = new System.Drawing.Size(120, 22);
			this.X_numericUpDown.TabIndex = 3;
			this.X_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.X_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Y_numericUpDown
			// 
			this.Y_numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Y_numericUpDown.Location = new System.Drawing.Point(173, 53);
			this.Y_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.Y_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Y_numericUpDown.Name = "Y_numericUpDown";
			this.Y_numericUpDown.Size = new System.Drawing.Size(120, 22);
			this.Y_numericUpDown.TabIndex = 3;
			this.Y_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Y_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// OK_button
			// 
			this.OK_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OK_button.Location = new System.Drawing.Point(186, 118);
			this.OK_button.Name = "OK_button";
			this.OK_button.Size = new System.Drawing.Size(120, 40);
			this.OK_button.TabIndex = 4;
			this.OK_button.Text = "OK";
			this.OK_button.UseVisualStyleBackColor = true;
			this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
			// 
			// Cancel_button
			// 
			this.Cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_button.Location = new System.Drawing.Point(11, 118);
			this.Cancel_button.Name = "Cancel_button";
			this.Cancel_button.Size = new System.Drawing.Size(120, 40);
			this.Cancel_button.TabIndex = 5;
			this.Cancel_button.Text = "Cancel";
			this.Cancel_button.UseVisualStyleBackColor = true;
			this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
			// 
			// GridSizeDlg
			// 
			this.AcceptButton = this.OK_button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_button;
			this.ClientSize = new System.Drawing.Size(317, 169);
			this.Controls.Add(this.The_tableLayoutPanel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GridSizeDlg";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "GridSizeDlg";
			this.The_tableLayoutPanel.ResumeLayout(false);
			this.The_tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.X_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Y_numericUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel The_tableLayoutPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown X_numericUpDown;
		private System.Windows.Forms.NumericUpDown Y_numericUpDown;
		private System.Windows.Forms.Button OK_button;
		private System.Windows.Forms.Button Cancel_button;
	}
}