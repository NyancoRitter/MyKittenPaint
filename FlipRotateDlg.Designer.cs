
namespace MyKittenPaint
{
	partial class FlipRotateDlg
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.FlipHorizontal_radioButton = new System.Windows.Forms.RadioButton();
			this.FlipVertical_radioButton = new System.Windows.Forms.RadioButton();
			this.Rot90_radioButton = new System.Windows.Forms.RadioButton();
			this.Rot180_radioButton = new System.Windows.Forms.RadioButton();
			this.Rot270_radioButton = new System.Windows.Forms.RadioButton();
			this.OK_button = new System.Windows.Forms.Button();
			this.Cancel_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.OK_button, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.Cancel_button, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.Rot270_radioButton, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.Rot180_radioButton, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.Rot90_radioButton, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.FlipVertical_radioButton, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.FlipHorizontal_radioButton, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 212);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// FlipHorizontal_radioButton
			// 
			this.FlipHorizontal_radioButton.AutoSize = true;
			this.FlipHorizontal_radioButton.Location = new System.Drawing.Point(16, 31);
			this.FlipHorizontal_radioButton.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
			this.FlipHorizontal_radioButton.Name = "FlipHorizontal_radioButton";
			this.FlipHorizontal_radioButton.Size = new System.Drawing.Size(116, 19);
			this.FlipHorizontal_radioButton.TabIndex = 0;
			this.FlipHorizontal_radioButton.TabStop = true;
			this.FlipHorizontal_radioButton.Text = "Flip horizontal";
			this.FlipHorizontal_radioButton.UseVisualStyleBackColor = true;
			// 
			// FlipVertical_radioButton
			// 
			this.FlipVertical_radioButton.AutoSize = true;
			this.FlipVertical_radioButton.Location = new System.Drawing.Point(16, 61);
			this.FlipVertical_radioButton.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
			this.FlipVertical_radioButton.Name = "FlipVertical_radioButton";
			this.FlipVertical_radioButton.Size = new System.Drawing.Size(102, 19);
			this.FlipVertical_radioButton.TabIndex = 0;
			this.FlipVertical_radioButton.TabStop = true;
			this.FlipVertical_radioButton.Text = "Flip Vertical";
			this.FlipVertical_radioButton.UseVisualStyleBackColor = true;
			// 
			// Rot90_radioButton
			// 
			this.Rot90_radioButton.AutoSize = true;
			this.Rot90_radioButton.Location = new System.Drawing.Point(143, 31);
			this.Rot90_radioButton.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
			this.Rot90_radioButton.Name = "Rot90_radioButton";
			this.Rot90_radioButton.Size = new System.Drawing.Size(118, 19);
			this.Rot90_radioButton.TabIndex = 0;
			this.Rot90_radioButton.TabStop = true;
			this.Rot90_radioButton.Text = "Rotate 90 deg";
			this.Rot90_radioButton.UseVisualStyleBackColor = true;
			// 
			// Rot180_radioButton
			// 
			this.Rot180_radioButton.AutoSize = true;
			this.Rot180_radioButton.Location = new System.Drawing.Point(143, 61);
			this.Rot180_radioButton.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
			this.Rot180_radioButton.Name = "Rot180_radioButton";
			this.Rot180_radioButton.Size = new System.Drawing.Size(126, 19);
			this.Rot180_radioButton.TabIndex = 0;
			this.Rot180_radioButton.TabStop = true;
			this.Rot180_radioButton.Text = "Rotate 180 deg";
			this.Rot180_radioButton.UseVisualStyleBackColor = true;
			// 
			// Rot270_radioButton
			// 
			this.Rot270_radioButton.AutoSize = true;
			this.Rot270_radioButton.Location = new System.Drawing.Point(143, 91);
			this.Rot270_radioButton.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
			this.Rot270_radioButton.Name = "Rot270_radioButton";
			this.Rot270_radioButton.Size = new System.Drawing.Size(126, 19);
			this.Rot270_radioButton.TabIndex = 0;
			this.Rot270_radioButton.TabStop = true;
			this.Rot270_radioButton.Text = "Rotate 270 deg";
			this.Rot270_radioButton.UseVisualStyleBackColor = true;
			// 
			// OK_button
			// 
			this.OK_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.OK_button.Location = new System.Drawing.Point(252, 161);
			this.OK_button.Name = "OK_button";
			this.OK_button.Size = new System.Drawing.Size(120, 40);
			this.OK_button.TabIndex = 1;
			this.OK_button.Text = "OK";
			this.OK_button.UseVisualStyleBackColor = true;
			this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
			// 
			// Cancel_button
			// 
			this.Cancel_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_button.Location = new System.Drawing.Point(11, 161);
			this.Cancel_button.Name = "Cancel_button";
			this.Cancel_button.Size = new System.Drawing.Size(120, 40);
			this.Cancel_button.TabIndex = 2;
			this.Cancel_button.Text = "Cancel";
			this.Cancel_button.UseVisualStyleBackColor = true;
			this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Flip :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(135, 8);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Rotate :";
			// 
			// FlipRotateDlg
			// 
			this.AcceptButton = this.OK_button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_button;
			this.ClientSize = new System.Drawing.Size(383, 212);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FlipRotateDlg";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Flip or Rotate";
			this.Load += new System.EventHandler(this.FlipRotateDlg_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RadioButton FlipHorizontal_radioButton;
		private System.Windows.Forms.RadioButton FlipVertical_radioButton;
		private System.Windows.Forms.RadioButton Rot90_radioButton;
		private System.Windows.Forms.RadioButton Rot180_radioButton;
		private System.Windows.Forms.RadioButton Rot270_radioButton;
		private System.Windows.Forms.Button OK_button;
		private System.Windows.Forms.Button Cancel_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}