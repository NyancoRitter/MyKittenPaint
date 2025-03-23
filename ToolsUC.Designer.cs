
namespace MyKittenPaint
{
	partial class ToolsUC
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsUC));
			this.Main_tabControl = new System.Windows.Forms.TabControl();
			this.Pen_tabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Line_tabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.LineWeight_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.RoundEnd_checkBox = new System.Windows.Forms.CheckBox();
			this.ResetLineWeight_button = new System.Windows.Forms.Button();
			this.Select_tabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.RectSelMode_radioButton = new System.Windows.Forms.RadioButton();
			this.FreeFormSelMode_radioButton = new System.Windows.Forms.RadioButton();
			this.TransBackColor_checkBox = new System.Windows.Forms.CheckBox();
			this.TransBackColor_pictureBox = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.FreeFormSelMode_pictureBox = new System.Windows.Forms.PictureBox();
			this.RectSelMode_pictureBox = new System.Windows.Forms.PictureBox();
			this.Eraser_tabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.Eraser3x3_radioButton = new System.Windows.Forms.RadioButton();
			this.Eraser5x5_radioButton = new System.Windows.Forms.RadioButton();
			this.Eraser7x7_radioButton = new System.Windows.Forms.RadioButton();
			this.Eraser9x9_radioButton = new System.Windows.Forms.RadioButton();
			this.Eraser11x11_radioButton = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.Fill_tabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.label9 = new System.Windows.Forms.Label();
			this.Icon_imageList = new System.Windows.Forms.ImageList(this.components);
			this.Pen1Pix_radioButton = new System.Windows.Forms.RadioButton();
			this.Pen2x2_radioButton = new System.Windows.Forms.RadioButton();
			this.Main_tabControl.SuspendLayout();
			this.Pen_tabPage.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.Line_tabPage.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LineWeight_numericUpDown)).BeginInit();
			this.Select_tabPage.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TransBackColor_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FreeFormSelMode_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RectSelMode_pictureBox)).BeginInit();
			this.Eraser_tabPage.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.Fill_tabPage.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// Main_tabControl
			// 
			this.Main_tabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
			this.Main_tabControl.Controls.Add(this.Pen_tabPage);
			this.Main_tabControl.Controls.Add(this.Line_tabPage);
			this.Main_tabControl.Controls.Add(this.Select_tabPage);
			this.Main_tabControl.Controls.Add(this.Eraser_tabPage);
			this.Main_tabControl.Controls.Add(this.Fill_tabPage);
			this.Main_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main_tabControl.Font = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Main_tabControl.ImageList = this.Icon_imageList;
			this.Main_tabControl.ItemSize = new System.Drawing.Size(25, 25);
			this.Main_tabControl.Location = new System.Drawing.Point(0, 0);
			this.Main_tabControl.Margin = new System.Windows.Forms.Padding(0);
			this.Main_tabControl.Multiline = true;
			this.Main_tabControl.Name = "Main_tabControl";
			this.Main_tabControl.SelectedIndex = 0;
			this.Main_tabControl.Size = new System.Drawing.Size(396, 519);
			this.Main_tabControl.TabIndex = 1;
			this.Main_tabControl.SelectedIndexChanged += new System.EventHandler(this.Main_tabControl_SelectedIndexChanged);
			// 
			// Pen_tabPage
			// 
			this.Pen_tabPage.Controls.Add(this.tableLayoutPanel1);
			this.Pen_tabPage.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Pen_tabPage.ImageIndex = 0;
			this.Pen_tabPage.Location = new System.Drawing.Point(4, 4);
			this.Pen_tabPage.Name = "Pen_tabPage";
			this.Pen_tabPage.Padding = new System.Windows.Forms.Padding(3);
			this.Pen_tabPage.Size = new System.Drawing.Size(363, 511);
			this.Pen_tabPage.TabIndex = 0;
			this.Pen_tabPage.Text = "Pen";
			this.Pen_tabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.Pen1Pix_radioButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Pen2x2_radioButton, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 505);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(0, 58);
			this.label3.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(357, 32);
			this.label3.TabIndex = 1;
			this.label3.Text = "Start with SHIFT key down, the direction is constrained to horizontal or vertical" +
    ".";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(0, 90);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(357, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "CTRL + Click acts as color picker.";
			// 
			// Line_tabPage
			// 
			this.Line_tabPage.Controls.Add(this.tableLayoutPanel2);
			this.Line_tabPage.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Line_tabPage.ImageIndex = 1;
			this.Line_tabPage.Location = new System.Drawing.Point(4, 4);
			this.Line_tabPage.Name = "Line_tabPage";
			this.Line_tabPage.Size = new System.Drawing.Size(363, 511);
			this.Line_tabPage.TabIndex = 1;
			this.Line_tabPage.Text = "Line";
			this.Line_tabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.LineWeight_numericUpDown, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.RoundEnd_checkBox, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ResetLineWeight_button, 1, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 7;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 511);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel2.SetColumnSpan(this.label7, 2);
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(0, 113);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(363, 17);
			this.label7.TabIndex = 3;
			this.label7.Text = "CTRL + Click acts as color picker.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel2.SetColumnSpan(this.label5, 2);
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(0, 81);
			this.label5.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(363, 32);
			this.label5.TabIndex = 0;
			this.label5.Text = "Pressing SHIFT key constrains the direction to multiples of 45 degrees.";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.label6, 2);
			this.label6.Location = new System.Drawing.Point(3, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "Line Weight :";
			// 
			// LineWeight_numericUpDown
			// 
			this.LineWeight_numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LineWeight_numericUpDown.AutoSize = true;
			this.LineWeight_numericUpDown.Location = new System.Drawing.Point(3, 49);
			this.LineWeight_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.LineWeight_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LineWeight_numericUpDown.Name = "LineWeight_numericUpDown";
			this.LineWeight_numericUpDown.Size = new System.Drawing.Size(51, 22);
			this.LineWeight_numericUpDown.TabIndex = 1;
			this.LineWeight_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.LineWeight_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// RoundEnd_checkBox
			// 
			this.RoundEnd_checkBox.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.RoundEnd_checkBox, 2);
			this.RoundEnd_checkBox.Location = new System.Drawing.Point(3, 8);
			this.RoundEnd_checkBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 6);
			this.RoundEnd_checkBox.Name = "RoundEnd_checkBox";
			this.RoundEnd_checkBox.Size = new System.Drawing.Size(130, 19);
			this.RoundEnd_checkBox.TabIndex = 1;
			this.RoundEnd_checkBox.Text = "Round the ends";
			this.RoundEnd_checkBox.UseVisualStyleBackColor = true;
			// 
			// ResetLineWeight_button
			// 
			this.ResetLineWeight_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ResetLineWeight_button.AutoSize = true;
			this.ResetLineWeight_button.Location = new System.Drawing.Point(64, 48);
			this.ResetLineWeight_button.Margin = new System.Windows.Forms.Padding(0);
			this.ResetLineWeight_button.Name = "ResetLineWeight_button";
			this.ResetLineWeight_button.Size = new System.Drawing.Size(95, 25);
			this.ResetLineWeight_button.TabIndex = 2;
			this.ResetLineWeight_button.Text = "Reset to 1";
			this.ResetLineWeight_button.UseVisualStyleBackColor = true;
			this.ResetLineWeight_button.Click += new System.EventHandler(this.ResetLineWeight_button_Click);
			// 
			// Select_tabPage
			// 
			this.Select_tabPage.Controls.Add(this.tableLayoutPanel3);
			this.Select_tabPage.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Select_tabPage.ImageIndex = 2;
			this.Select_tabPage.Location = new System.Drawing.Point(4, 4);
			this.Select_tabPage.Name = "Select_tabPage";
			this.Select_tabPage.Size = new System.Drawing.Size(363, 511);
			this.Select_tabPage.TabIndex = 2;
			this.Select_tabPage.Text = "Select";
			this.Select_tabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.RectSelMode_radioButton, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.FreeFormSelMode_radioButton, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.TransBackColor_checkBox, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.TransBackColor_pictureBox, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.FreeFormSelMode_pictureBox, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.RectSelMode_pictureBox, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 6;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(363, 511);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel3.SetColumnSpan(this.label1, 2);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(0, 124);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(363, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Start dragging the selected area with CTRL makes copy.";
			// 
			// RectSelMode_radioButton
			// 
			this.RectSelMode_radioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.RectSelMode_radioButton.AutoSize = true;
			this.RectSelMode_radioButton.Location = new System.Drawing.Point(35, 6);
			this.RectSelMode_radioButton.Name = "RectSelMode_radioButton";
			this.RectSelMode_radioButton.Size = new System.Drawing.Size(91, 19);
			this.RectSelMode_radioButton.TabIndex = 0;
			this.RectSelMode_radioButton.TabStop = true;
			this.RectSelMode_radioButton.Text = "Rectangle";
			this.RectSelMode_radioButton.UseVisualStyleBackColor = true;
			this.RectSelMode_radioButton.CheckedChanged += new System.EventHandler(this.RectSelMode_radioButton_CheckedChanged);
			// 
			// FreeFormSelMode_radioButton
			// 
			this.FreeFormSelMode_radioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.FreeFormSelMode_radioButton.AutoSize = true;
			this.FreeFormSelMode_radioButton.Location = new System.Drawing.Point(35, 38);
			this.FreeFormSelMode_radioButton.Name = "FreeFormSelMode_radioButton";
			this.FreeFormSelMode_radioButton.Size = new System.Drawing.Size(97, 19);
			this.FreeFormSelMode_radioButton.TabIndex = 1;
			this.FreeFormSelMode_radioButton.TabStop = true;
			this.FreeFormSelMode_radioButton.Text = "Free-Form";
			this.FreeFormSelMode_radioButton.UseVisualStyleBackColor = true;
			this.FreeFormSelMode_radioButton.CheckedChanged += new System.EventHandler(this.FreeFormSelMode_radioButton_CheckedChanged);
			// 
			// TransBackColor_checkBox
			// 
			this.TransBackColor_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TransBackColor_checkBox.AutoSize = true;
			this.TransBackColor_checkBox.Location = new System.Drawing.Point(35, 90);
			this.TransBackColor_checkBox.Name = "TransBackColor_checkBox";
			this.TransBackColor_checkBox.Size = new System.Drawing.Size(184, 19);
			this.TransBackColor_checkBox.TabIndex = 2;
			this.TransBackColor_checkBox.Text = "Transparent Right-Color";
			this.TransBackColor_checkBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.TransBackColor_checkBox.UseVisualStyleBackColor = true;
			this.TransBackColor_checkBox.CheckedChanged += new System.EventHandler(this.TransBackColor_checkBox_CheckedChanged);
			// 
			// TransBackColor_pictureBox
			// 
			this.TransBackColor_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TransBackColor_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TransBackColor_pictureBox.Image = global::MyKittenPaint.Properties.Resources.TransBack;
			this.TransBackColor_pictureBox.Location = new System.Drawing.Point(3, 87);
			this.TransBackColor_pictureBox.Name = "TransBackColor_pictureBox";
			this.TransBackColor_pictureBox.Size = new System.Drawing.Size(26, 26);
			this.TransBackColor_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.TransBackColor_pictureBox.TabIndex = 3;
			this.TransBackColor_pictureBox.TabStop = false;
			this.TransBackColor_pictureBox.Click += new System.EventHandler(this.TransBackColor_pictureBox_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel3.SetColumnSpan(this.pictureBox2, 2);
			this.pictureBox2.Location = new System.Drawing.Point(8, 72);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(347, 4);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// FreeFormSelMode_pictureBox
			// 
			this.FreeFormSelMode_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.FreeFormSelMode_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FreeFormSelMode_pictureBox.Image = global::MyKittenPaint.Properties.Resources.FreeSel;
			this.FreeFormSelMode_pictureBox.Location = new System.Drawing.Point(3, 35);
			this.FreeFormSelMode_pictureBox.Name = "FreeFormSelMode_pictureBox";
			this.FreeFormSelMode_pictureBox.Size = new System.Drawing.Size(26, 26);
			this.FreeFormSelMode_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FreeFormSelMode_pictureBox.TabIndex = 3;
			this.FreeFormSelMode_pictureBox.TabStop = false;
			this.FreeFormSelMode_pictureBox.Click += new System.EventHandler(this.FreeFormSelMode_pictureBox_Click);
			// 
			// RectSelMode_pictureBox
			// 
			this.RectSelMode_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.RectSelMode_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.RectSelMode_pictureBox.Image = global::MyKittenPaint.Properties.Resources.RectSel;
			this.RectSelMode_pictureBox.Location = new System.Drawing.Point(3, 3);
			this.RectSelMode_pictureBox.Name = "RectSelMode_pictureBox";
			this.RectSelMode_pictureBox.Size = new System.Drawing.Size(26, 26);
			this.RectSelMode_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.RectSelMode_pictureBox.TabIndex = 3;
			this.RectSelMode_pictureBox.TabStop = false;
			this.RectSelMode_pictureBox.Click += new System.EventHandler(this.RectSelMode_pictureBox_Click);
			// 
			// Eraser_tabPage
			// 
			this.Eraser_tabPage.Controls.Add(this.tableLayoutPanel4);
			this.Eraser_tabPage.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Eraser_tabPage.ImageIndex = 3;
			this.Eraser_tabPage.Location = new System.Drawing.Point(4, 4);
			this.Eraser_tabPage.Name = "Eraser_tabPage";
			this.Eraser_tabPage.Size = new System.Drawing.Size(363, 511);
			this.Eraser_tabPage.TabIndex = 3;
			this.Eraser_tabPage.Text = "Eraser";
			this.Eraser_tabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.label2, 0, 5);
			this.tableLayoutPanel4.Controls.Add(this.Eraser3x3_radioButton, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.Eraser5x5_radioButton, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.Eraser7x7_radioButton, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.Eraser9x9_radioButton, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.Eraser11x11_radioButton, 0, 4);
			this.tableLayoutPanel4.Controls.Add(this.label8, 0, 6);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 8;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(363, 511);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel4.SetColumnSpan(this.label2, 2);
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(0, 133);
			this.label2.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(363, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Right button targets only the left color area.";
			// 
			// Eraser3x3_radioButton
			// 
			this.Eraser3x3_radioButton.AutoSize = true;
			this.Eraser3x3_radioButton.Location = new System.Drawing.Point(3, 3);
			this.Eraser3x3_radioButton.Name = "Eraser3x3_radioButton";
			this.Eraser3x3_radioButton.Size = new System.Drawing.Size(51, 19);
			this.Eraser3x3_radioButton.TabIndex = 0;
			this.Eraser3x3_radioButton.TabStop = true;
			this.Eraser3x3_radioButton.Text = "3x3";
			this.Eraser3x3_radioButton.UseVisualStyleBackColor = true;
			this.Eraser3x3_radioButton.CheckedChanged += new System.EventHandler(this.EraserSize_radioButton_CheckedChanged);
			// 
			// Eraser5x5_radioButton
			// 
			this.Eraser5x5_radioButton.AutoSize = true;
			this.Eraser5x5_radioButton.Location = new System.Drawing.Point(3, 28);
			this.Eraser5x5_radioButton.Name = "Eraser5x5_radioButton";
			this.Eraser5x5_radioButton.Size = new System.Drawing.Size(51, 19);
			this.Eraser5x5_radioButton.TabIndex = 0;
			this.Eraser5x5_radioButton.TabStop = true;
			this.Eraser5x5_radioButton.Text = "5x5";
			this.Eraser5x5_radioButton.UseVisualStyleBackColor = true;
			this.Eraser5x5_radioButton.CheckedChanged += new System.EventHandler(this.EraserSize_radioButton_CheckedChanged);
			// 
			// Eraser7x7_radioButton
			// 
			this.Eraser7x7_radioButton.AutoSize = true;
			this.Eraser7x7_radioButton.Location = new System.Drawing.Point(3, 53);
			this.Eraser7x7_radioButton.Name = "Eraser7x7_radioButton";
			this.Eraser7x7_radioButton.Size = new System.Drawing.Size(51, 19);
			this.Eraser7x7_radioButton.TabIndex = 0;
			this.Eraser7x7_radioButton.TabStop = true;
			this.Eraser7x7_radioButton.Text = "7x7";
			this.Eraser7x7_radioButton.UseVisualStyleBackColor = true;
			this.Eraser7x7_radioButton.CheckedChanged += new System.EventHandler(this.EraserSize_radioButton_CheckedChanged);
			// 
			// Eraser9x9_radioButton
			// 
			this.Eraser9x9_radioButton.AutoSize = true;
			this.Eraser9x9_radioButton.Location = new System.Drawing.Point(3, 78);
			this.Eraser9x9_radioButton.Name = "Eraser9x9_radioButton";
			this.Eraser9x9_radioButton.Size = new System.Drawing.Size(51, 19);
			this.Eraser9x9_radioButton.TabIndex = 0;
			this.Eraser9x9_radioButton.TabStop = true;
			this.Eraser9x9_radioButton.Text = "9x9";
			this.Eraser9x9_radioButton.UseVisualStyleBackColor = true;
			this.Eraser9x9_radioButton.CheckedChanged += new System.EventHandler(this.EraserSize_radioButton_CheckedChanged);
			// 
			// Eraser11x11_radioButton
			// 
			this.Eraser11x11_radioButton.AutoSize = true;
			this.Eraser11x11_radioButton.Location = new System.Drawing.Point(3, 103);
			this.Eraser11x11_radioButton.Name = "Eraser11x11_radioButton";
			this.Eraser11x11_radioButton.Size = new System.Drawing.Size(67, 19);
			this.Eraser11x11_radioButton.TabIndex = 0;
			this.Eraser11x11_radioButton.TabStop = true;
			this.Eraser11x11_radioButton.Text = "11x11";
			this.Eraser11x11_radioButton.UseVisualStyleBackColor = true;
			this.Eraser11x11_radioButton.CheckedChanged += new System.EventHandler(this.EraserSize_radioButton_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel4.SetColumnSpan(this.label8, 2);
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(0, 150);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(363, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "CTRL + Click acts as color picker.";
			// 
			// Fill_tabPage
			// 
			this.Fill_tabPage.Controls.Add(this.tableLayoutPanel5);
			this.Fill_tabPage.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Fill_tabPage.ImageIndex = 4;
			this.Fill_tabPage.Location = new System.Drawing.Point(4, 4);
			this.Fill_tabPage.Name = "Fill_tabPage";
			this.Fill_tabPage.Size = new System.Drawing.Size(363, 511);
			this.Fill_tabPage.TabIndex = 4;
			this.Fill_tabPage.Text = "Fill";
			this.Fill_tabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(363, 511);
			this.tableLayoutPanel5.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel5.SetColumnSpan(this.label9, 2);
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(363, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "CTRL + Click acts as color picker.";
			// 
			// Icon_imageList
			// 
			this.Icon_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icon_imageList.ImageStream")));
			this.Icon_imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.Icon_imageList.Images.SetKeyName(0, "Pen.PNG");
			this.Icon_imageList.Images.SetKeyName(1, "Line.PNG");
			this.Icon_imageList.Images.SetKeyName(2, "Select.PNG");
			this.Icon_imageList.Images.SetKeyName(3, "Eraser.png");
			this.Icon_imageList.Images.SetKeyName(4, "Fill.png");
			// 
			// Pen1Pix_radioButton
			// 
			this.Pen1Pix_radioButton.AutoSize = true;
			this.Pen1Pix_radioButton.Location = new System.Drawing.Point(3, 3);
			this.Pen1Pix_radioButton.Name = "Pen1Pix_radioButton";
			this.Pen1Pix_radioButton.Size = new System.Drawing.Size(76, 19);
			this.Pen1Pix_radioButton.TabIndex = 2;
			this.Pen1Pix_radioButton.TabStop = true;
			this.Pen1Pix_radioButton.Text = "1[Pixel]";
			this.Pen1Pix_radioButton.UseVisualStyleBackColor = true;
			this.Pen1Pix_radioButton.CheckedChanged += new System.EventHandler(this.Pen1Pix_radioButton_CheckedChanged);
			// 
			// Pen2x2_radioButton
			// 
			this.Pen2x2_radioButton.AutoSize = true;
			this.Pen2x2_radioButton.Location = new System.Drawing.Point(3, 28);
			this.Pen2x2_radioButton.Name = "Pen2x2_radioButton";
			this.Pen2x2_radioButton.Size = new System.Drawing.Size(51, 19);
			this.Pen2x2_radioButton.TabIndex = 2;
			this.Pen2x2_radioButton.TabStop = true;
			this.Pen2x2_radioButton.Text = "2x2";
			this.Pen2x2_radioButton.UseVisualStyleBackColor = true;
			// 
			// ToolsUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Main_tabControl);
			this.Name = "ToolsUC";
			this.Size = new System.Drawing.Size(396, 519);
			this.Load += new System.EventHandler(this.ToolsUC_Load);
			this.Main_tabControl.ResumeLayout(false);
			this.Pen_tabPage.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.Line_tabPage.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LineWeight_numericUpDown)).EndInit();
			this.Select_tabPage.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TransBackColor_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FreeFormSelMode_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RectSelMode_pictureBox)).EndInit();
			this.Eraser_tabPage.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.Fill_tabPage.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Main_tabControl;
		private System.Windows.Forms.TabPage Pen_tabPage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ImageList Icon_imageList;
		private System.Windows.Forms.TabPage Line_tabPage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox RoundEnd_checkBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown LineWeight_numericUpDown;
		private System.Windows.Forms.Button ResetLineWeight_button;
		private System.Windows.Forms.TabPage Select_tabPage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.RadioButton RectSelMode_radioButton;
		private System.Windows.Forms.RadioButton FreeFormSelMode_radioButton;
		private System.Windows.Forms.CheckBox TransBackColor_checkBox;
		private System.Windows.Forms.PictureBox TransBackColor_pictureBox;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox FreeFormSelMode_pictureBox;
		private System.Windows.Forms.PictureBox RectSelMode_pictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage Eraser_tabPage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.RadioButton Eraser3x3_radioButton;
		private System.Windows.Forms.RadioButton Eraser5x5_radioButton;
		private System.Windows.Forms.RadioButton Eraser7x7_radioButton;
		private System.Windows.Forms.RadioButton Eraser9x9_radioButton;
		private System.Windows.Forms.RadioButton Eraser11x11_radioButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage Fill_tabPage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton Pen1Pix_radioButton;
		private System.Windows.Forms.RadioButton Pen2x2_radioButton;
	}
}
