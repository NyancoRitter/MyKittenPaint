
namespace MyKittenPaint
{
	partial class SizeDlg
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
			this.Width_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Height_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.OK_button = new System.Windows.Forms.Button();
			this.Cancel_button = new System.Windows.Forms.Button();
			this.SizeSel_comboBox = new System.Windows.Forms.ComboBox();
			this.The_tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Width_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Height_numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// The_tableLayoutPanel
			// 
			this.The_tableLayoutPanel.ColumnCount = 2;
			this.The_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.The_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.The_tableLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.The_tableLayoutPanel.Controls.Add(this.label2, 0, 2);
			this.The_tableLayoutPanel.Controls.Add(this.label3, 1, 2);
			this.The_tableLayoutPanel.Controls.Add(this.Width_numericUpDown, 0, 3);
			this.The_tableLayoutPanel.Controls.Add(this.Height_numericUpDown, 1, 3);
			this.The_tableLayoutPanel.Controls.Add(this.OK_button, 1, 4);
			this.The_tableLayoutPanel.Controls.Add(this.Cancel_button, 0, 4);
			this.The_tableLayoutPanel.Controls.Add(this.SizeSel_comboBox, 0, 1);
			this.The_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.The_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.The_tableLayoutPanel.Name = "The_tableLayoutPanel";
			this.The_tableLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
			this.The_tableLayoutPanel.RowCount = 5;
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.The_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.The_tableLayoutPanel.Size = new System.Drawing.Size(348, 197);
			this.The_tableLayoutPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.The_tableLayoutPanel.SetColumnSpan(this.label1, 2);
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(11, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Image Size :";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Width";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(233, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Height";
			// 
			// Width_numericUpDown
			// 
			this.Width_numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Width_numericUpDown.Location = new System.Drawing.Point(31, 91);
			this.Width_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.Width_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Width_numericUpDown.Name = "Width_numericUpDown";
			this.Width_numericUpDown.Size = new System.Drawing.Size(120, 22);
			this.Width_numericUpDown.TabIndex = 3;
			this.Width_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Width_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Height_numericUpDown
			// 
			this.Height_numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Height_numericUpDown.Location = new System.Drawing.Point(197, 91);
			this.Height_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.Height_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Height_numericUpDown.Name = "Height_numericUpDown";
			this.Height_numericUpDown.Size = new System.Drawing.Size(120, 22);
			this.Height_numericUpDown.TabIndex = 3;
			this.Height_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Height_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// OK_button
			// 
			this.OK_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OK_button.Location = new System.Drawing.Point(217, 146);
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
			this.Cancel_button.Location = new System.Drawing.Point(11, 146);
			this.Cancel_button.Name = "Cancel_button";
			this.Cancel_button.Size = new System.Drawing.Size(120, 40);
			this.Cancel_button.TabIndex = 5;
			this.Cancel_button.Text = "Cancel";
			this.Cancel_button.UseVisualStyleBackColor = true;
			this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
			// 
			// SizeSel_comboBox
			// 
			this.SizeSel_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SizeSel_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SizeSel_comboBox.FormattingEnabled = true;
			this.SizeSel_comboBox.Location = new System.Drawing.Point(31, 38);
			this.SizeSel_comboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
			this.SizeSel_comboBox.Name = "SizeSel_comboBox";
			this.SizeSel_comboBox.Size = new System.Drawing.Size(120, 23);
			this.SizeSel_comboBox.TabIndex = 6;
			this.SizeSel_comboBox.SelectedIndexChanged += new System.EventHandler(this.SizeSel_comboBox_SelectedIndexChanged);
			// 
			// SizeDlg
			// 
			this.AcceptButton = this.OK_button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_button;
			this.ClientSize = new System.Drawing.Size(348, 197);
			this.Controls.Add(this.The_tableLayoutPanel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SizeDlg";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SizeDlg";
			this.Load += new System.EventHandler(this.SizeDlg_Load);
			this.The_tableLayoutPanel.ResumeLayout(false);
			this.The_tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Width_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Height_numericUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel The_tableLayoutPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown Width_numericUpDown;
		private System.Windows.Forms.NumericUpDown Height_numericUpDown;
		private System.Windows.Forms.Button OK_button;
		private System.Windows.Forms.Button Cancel_button;
		private System.Windows.Forms.ComboBox SizeSel_comboBox;
	}
}