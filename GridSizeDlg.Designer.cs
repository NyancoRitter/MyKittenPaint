
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
			this.X_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Cancel_button = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.GridColor_pictureBox = new System.Windows.Forms.PictureBox();
			this.Y_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.OK_button = new System.Windows.Forms.Button();
			this.The_tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.X_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridColor_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Y_numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// The_tableLayoutPanel
			// 
			this.The_tableLayoutPanel.ColumnCount = 3;
			this.The_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.The_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.The_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.The_tableLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.The_tableLayoutPanel.Controls.Add(this.label2, 0, 1);
			this.The_tableLayoutPanel.Controls.Add(this.X_numericUpDown, 0, 2);
			this.The_tableLayoutPanel.Controls.Add(this.Cancel_button, 0, 5);
			this.The_tableLayoutPanel.Controls.Add(this.label4, 0, 3);
			this.The_tableLayoutPanel.Controls.Add(this.GridColor_pictureBox, 0, 4);
			this.The_tableLayoutPanel.Controls.Add(this.Y_numericUpDown, 1, 2);
			this.The_tableLayoutPanel.Controls.Add(this.label3, 1, 1);
			this.The_tableLayoutPanel.Controls.Add(this.OK_button, 1, 5);
			this.The_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.The_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.The_tableLayoutPanel.Name = "The_tableLayoutPanel";
			this.The_tableLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
			this.The_tableLayoutPanel.RowCount = 6;
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.Size = new System.Drawing.Size(318, 226);
			this.The_tableLayoutPanel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.The_tableLayoutPanel.SetColumnSpan(this.label1, 3);
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(11, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Grid Interval :";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "X";
			// 
			// X_numericUpDown
			// 
			this.X_numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.X_numericUpDown.AutoSize = true;
			this.X_numericUpDown.Location = new System.Drawing.Point(37, 53);
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
			this.X_numericUpDown.Size = new System.Drawing.Size(67, 22);
			this.X_numericUpDown.TabIndex = 3;
			this.X_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.X_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Cancel_button
			// 
			this.Cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_button.Location = new System.Drawing.Point(11, 175);
			this.Cancel_button.Name = "Cancel_button";
			this.Cancel_button.Size = new System.Drawing.Size(120, 40);
			this.Cancel_button.TabIndex = 5;
			this.Cancel_button.Text = "Cancel";
			this.Cancel_button.UseVisualStyleBackColor = true;
			this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.The_tableLayoutPanel.SetColumnSpan(this.label4, 3);
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(11, 90);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(285, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Grid Color : (Double-Click to Change)";
			// 
			// GridColor_pictureBox
			// 
			this.GridColor_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.GridColor_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GridColor_pictureBox.Location = new System.Drawing.Point(99, 108);
			this.GridColor_pictureBox.Name = "GridColor_pictureBox";
			this.GridColor_pictureBox.Size = new System.Drawing.Size(32, 32);
			this.GridColor_pictureBox.TabIndex = 6;
			this.GridColor_pictureBox.TabStop = false;
			this.GridColor_pictureBox.DoubleClick += new System.EventHandler(this.GridColor_pictureBox_DoubleClick);
			// 
			// Y_numericUpDown
			// 
			this.Y_numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Y_numericUpDown.AutoSize = true;
			this.Y_numericUpDown.Location = new System.Drawing.Point(137, 53);
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
			this.Y_numericUpDown.Size = new System.Drawing.Size(67, 22);
			this.Y_numericUpDown.TabIndex = 3;
			this.Y_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Y_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(162, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Y";
			// 
			// OK_button
			// 
			this.OK_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.The_tableLayoutPanel.SetColumnSpan(this.OK_button, 2);
			this.OK_button.Location = new System.Drawing.Point(187, 175);
			this.OK_button.Name = "OK_button";
			this.OK_button.Size = new System.Drawing.Size(120, 40);
			this.OK_button.TabIndex = 4;
			this.OK_button.Text = "OK";
			this.OK_button.UseVisualStyleBackColor = true;
			this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
			// 
			// GridSizeDlg
			// 
			this.AcceptButton = this.OK_button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_button;
			this.ClientSize = new System.Drawing.Size(318, 226);
			this.Controls.Add(this.The_tableLayoutPanel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GridSizeDlg";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Grid Settings";
			this.The_tableLayoutPanel.ResumeLayout(false);
			this.The_tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.X_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridColor_pictureBox)).EndInit();
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox GridColor_pictureBox;
	}
}