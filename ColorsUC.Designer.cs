
namespace MyKittenPaint
{
	partial class ColorsUC
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.Palette_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.LineWrap_checkBox = new System.Windows.Forms.CheckBox();
			this.Main_tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Palette_flowLayoutPanel
			// 
			this.Palette_flowLayoutPanel.AutoScroll = true;
			this.Palette_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Palette_flowLayoutPanel.Location = new System.Drawing.Point(68, 3);
			this.Palette_flowLayoutPanel.Name = "Palette_flowLayoutPanel";
			this.Palette_flowLayoutPanel.Size = new System.Drawing.Size(285, 117);
			this.Palette_flowLayoutPanel.TabIndex = 1;
			// 
			// Main_tableLayoutPanel
			// 
			this.Main_tableLayoutPanel.ColumnCount = 2;
			this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Main_tableLayoutPanel.Controls.Add(this.Palette_flowLayoutPanel, 1, 0);
			this.Main_tableLayoutPanel.Controls.Add(this.LineWrap_checkBox, 0, 0);
			this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
			this.Main_tableLayoutPanel.RowCount = 1;
			this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Main_tableLayoutPanel.Size = new System.Drawing.Size(356, 123);
			this.Main_tableLayoutPanel.TabIndex = 2;
			// 
			// LineWrap_checkBox
			// 
			this.LineWrap_checkBox.AutoSize = true;
			this.LineWrap_checkBox.Location = new System.Drawing.Point(3, 3);
			this.LineWrap_checkBox.Name = "LineWrap_checkBox";
			this.LineWrap_checkBox.Size = new System.Drawing.Size(59, 19);
			this.LineWrap_checkBox.TabIndex = 2;
			this.LineWrap_checkBox.Text = "Wrap";
			this.LineWrap_checkBox.UseVisualStyleBackColor = true;
			this.LineWrap_checkBox.CheckedChanged += new System.EventHandler(this.LineWrap_checkBox_CheckedChanged);
			// 
			// ColorsUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Main_tableLayoutPanel);
			this.Name = "ColorsUC";
			this.Size = new System.Drawing.Size(356, 123);
			this.Load += new System.EventHandler(this.ColorsUC_Load);
			this.Main_tableLayoutPanel.ResumeLayout(false);
			this.Main_tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel Palette_flowLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
		private System.Windows.Forms.CheckBox LineWrap_checkBox;
	}
}
