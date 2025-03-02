
namespace MyKittenPaint
{
	partial class ThumbnailForm
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
			this.Thumbnail_pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Thumbnail_pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// Thumbnail_pictureBox
			// 
			this.Thumbnail_pictureBox.Location = new System.Drawing.Point(0, 0);
			this.Thumbnail_pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.Thumbnail_pictureBox.Name = "Thumbnail_pictureBox";
			this.Thumbnail_pictureBox.Size = new System.Drawing.Size(100, 50);
			this.Thumbnail_pictureBox.TabIndex = 0;
			this.Thumbnail_pictureBox.TabStop = false;
			this.Thumbnail_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Thumbnail_pictureBox_Paint);
			// 
			// ThumbnailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(200, 151);
			this.Controls.Add(this.Thumbnail_pictureBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ThumbnailForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thumbnail";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThumbnailForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.Thumbnail_pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Thumbnail_pictureBox;
	}
}