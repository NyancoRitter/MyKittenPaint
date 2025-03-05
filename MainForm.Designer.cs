
namespace MyKittenPaint
{
	partial class MainForm
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

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Main_toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.Main_statusStrip = new System.Windows.Forms.StatusStrip();
			this.InfoSpace_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.Zoom_toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.Pos_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.Size_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.Main_panel = new System.Windows.Forms.Panel();
			this.UD_splitContainer = new System.Windows.Forms.SplitContainer();
			this.LR_splitContainer = new System.Windows.Forms.SplitContainer();
			this.The_toolsUC = new MyKittenPaint.ToolsUC();
			this.ScrollSizeDeside_panel = new System.Windows.Forms.Panel();
			this.Main_pictureBox = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.The_colorsUC = new MyKittenPaint.ColorsUC();
			this.SwapColor_button = new System.Windows.Forms.Button();
			this.RColor_pictureBox = new System.Windows.Forms.PictureBox();
			this.LColor_pictureBox = new System.Windows.Forms.PictureBox();
			this.Main_menuStrip = new System.Windows.Forms.MenuStrip();
			this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.New_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Undo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Redo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.Copy_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Cut_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Paste_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.SelectAll_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ClearSelection_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Image_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FlipRotate_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.Size_SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.View_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowThumbnail_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.ShowGrid_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GridSize_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Settings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ConfirmAtSave_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowFullPathOnCaption_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Version_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Main_toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.Main_toolStripContainer.ContentPanel.SuspendLayout();
			this.Main_toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.Main_toolStripContainer.SuspendLayout();
			this.Main_statusStrip.SuspendLayout();
			this.Main_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UD_splitContainer)).BeginInit();
			this.UD_splitContainer.Panel1.SuspendLayout();
			this.UD_splitContainer.Panel2.SuspendLayout();
			this.UD_splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LR_splitContainer)).BeginInit();
			this.LR_splitContainer.Panel1.SuspendLayout();
			this.LR_splitContainer.Panel2.SuspendLayout();
			this.LR_splitContainer.SuspendLayout();
			this.ScrollSizeDeside_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Main_pictureBox)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RColor_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LColor_pictureBox)).BeginInit();
			this.Main_menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Main_toolStripContainer
			// 
			// 
			// Main_toolStripContainer.BottomToolStripPanel
			// 
			this.Main_toolStripContainer.BottomToolStripPanel.Controls.Add(this.Main_statusStrip);
			// 
			// Main_toolStripContainer.ContentPanel
			// 
			this.Main_toolStripContainer.ContentPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Main_toolStripContainer.ContentPanel.Controls.Add(this.Main_panel);
			this.Main_toolStripContainer.ContentPanel.Size = new System.Drawing.Size(850, 433);
			this.Main_toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main_toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.Main_toolStripContainer.Name = "Main_toolStripContainer";
			this.Main_toolStripContainer.Size = new System.Drawing.Size(850, 491);
			this.Main_toolStripContainer.TabIndex = 0;
			this.Main_toolStripContainer.Text = "toolStripContainer1";
			// 
			// Main_toolStripContainer.TopToolStripPanel
			// 
			this.Main_toolStripContainer.TopToolStripPanel.Controls.Add(this.Main_menuStrip);
			// 
			// Main_statusStrip
			// 
			this.Main_statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.Main_statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.Main_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoSpace_toolStripStatusLabel,
            this.Zoom_toolStripDropDownButton,
            this.Pos_toolStripStatusLabel,
            this.Size_toolStripStatusLabel});
			this.Main_statusStrip.Location = new System.Drawing.Point(0, 0);
			this.Main_statusStrip.Name = "Main_statusStrip";
			this.Main_statusStrip.Size = new System.Drawing.Size(850, 30);
			this.Main_statusStrip.TabIndex = 0;
			// 
			// InfoSpace_toolStripStatusLabel
			// 
			this.InfoSpace_toolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.InfoSpace_toolStripStatusLabel.Name = "InfoSpace_toolStripStatusLabel";
			this.InfoSpace_toolStripStatusLabel.Size = new System.Drawing.Size(620, 24);
			this.InfoSpace_toolStripStatusLabel.Spring = true;
			this.InfoSpace_toolStripStatusLabel.Text = "(Info Space)";
			this.InfoSpace_toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Zoom_toolStripDropDownButton
			// 
			this.Zoom_toolStripDropDownButton.Image = global::MyKittenPaint.Properties.Resources.Loupe;
			this.Zoom_toolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Zoom_toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Zoom_toolStripDropDownButton.Name = "Zoom_toolStripDropDownButton";
			this.Zoom_toolStripDropDownButton.Size = new System.Drawing.Size(119, 28);
			this.Zoom_toolStripDropDownButton.Text = "(ZoomRate)";
			this.Zoom_toolStripDropDownButton.ToolTipText = "Zoom Rate";
			this.Zoom_toolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Zoom_toolStripDropDownButton_DropDownItemClicked);
			// 
			// Pos_toolStripStatusLabel
			// 
			this.Pos_toolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.Pos_toolStripStatusLabel.Name = "Pos_toolStripStatusLabel";
			this.Pos_toolStripStatusLabel.Size = new System.Drawing.Size(46, 24);
			this.Pos_toolStripStatusLabel.Text = "(Pos)";
			// 
			// Size_toolStripStatusLabel
			// 
			this.Size_toolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.Size_toolStripStatusLabel.Name = "Size_toolStripStatusLabel";
			this.Size_toolStripStatusLabel.Size = new System.Drawing.Size(50, 24);
			this.Size_toolStripStatusLabel.Text = "(Size)";
			// 
			// Main_panel
			// 
			this.Main_panel.BackColor = System.Drawing.SystemColors.Control;
			this.Main_panel.Controls.Add(this.UD_splitContainer);
			this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main_panel.Location = new System.Drawing.Point(0, 0);
			this.Main_panel.Margin = new System.Windows.Forms.Padding(0);
			this.Main_panel.Name = "Main_panel";
			this.Main_panel.Size = new System.Drawing.Size(850, 433);
			this.Main_panel.TabIndex = 1;
			// 
			// UD_splitContainer
			// 
			this.UD_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UD_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.UD_splitContainer.Location = new System.Drawing.Point(0, 0);
			this.UD_splitContainer.Name = "UD_splitContainer";
			this.UD_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// UD_splitContainer.Panel1
			// 
			this.UD_splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.UD_splitContainer.Panel1.Controls.Add(this.LR_splitContainer);
			this.UD_splitContainer.Panel1MinSize = 32;
			// 
			// UD_splitContainer.Panel2
			// 
			this.UD_splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.UD_splitContainer.Panel2MinSize = 32;
			this.UD_splitContainer.Size = new System.Drawing.Size(850, 433);
			this.UD_splitContainer.SplitterDistance = 395;
			this.UD_splitContainer.TabIndex = 1;
			// 
			// LR_splitContainer
			// 
			this.LR_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LR_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.LR_splitContainer.Location = new System.Drawing.Point(0, 0);
			this.LR_splitContainer.Name = "LR_splitContainer";
			// 
			// LR_splitContainer.Panel1
			// 
			this.LR_splitContainer.Panel1.Controls.Add(this.The_toolsUC);
			// 
			// LR_splitContainer.Panel2
			// 
			this.LR_splitContainer.Panel2.AutoScroll = true;
			this.LR_splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LR_splitContainer.Panel2.Controls.Add(this.ScrollSizeDeside_panel);
			this.LR_splitContainer.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LR_splitContainer_Panel2_MouseClick);
			this.LR_splitContainer.Size = new System.Drawing.Size(850, 395);
			this.LR_splitContainer.SplitterDistance = 136;
			this.LR_splitContainer.TabIndex = 1;
			// 
			// The_toolsUC
			// 
			this.The_toolsUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.The_toolsUC.Location = new System.Drawing.Point(0, 0);
			this.The_toolsUC.Margin = new System.Windows.Forms.Padding(0);
			this.The_toolsUC.Name = "The_toolsUC";
			this.The_toolsUC.Observer = null;
			this.The_toolsUC.Size = new System.Drawing.Size(136, 395);
			this.The_toolsUC.TabIndex = 0;
			// 
			// ScrollSizeDeside_panel
			// 
			this.ScrollSizeDeside_panel.AutoSize = true;
			this.ScrollSizeDeside_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ScrollSizeDeside_panel.Controls.Add(this.Main_pictureBox);
			this.ScrollSizeDeside_panel.Location = new System.Drawing.Point(0, 0);
			this.ScrollSizeDeside_panel.Margin = new System.Windows.Forms.Padding(0);
			this.ScrollSizeDeside_panel.Name = "ScrollSizeDeside_panel";
			this.ScrollSizeDeside_panel.Padding = new System.Windows.Forms.Padding(8);
			this.ScrollSizeDeside_panel.Size = new System.Drawing.Size(116, 116);
			this.ScrollSizeDeside_panel.TabIndex = 1;
			this.ScrollSizeDeside_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScrollSizeDeside_panel_MouseClick);
			// 
			// Main_pictureBox
			// 
			this.Main_pictureBox.BackColor = System.Drawing.SystemColors.Control;
			this.Main_pictureBox.Location = new System.Drawing.Point(8, 8);
			this.Main_pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.Main_pictureBox.Name = "Main_pictureBox";
			this.Main_pictureBox.Size = new System.Drawing.Size(100, 100);
			this.Main_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Main_pictureBox.TabIndex = 0;
			this.Main_pictureBox.TabStop = false;
			this.Main_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_pictureBox_Paint);
			this.Main_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_pictureBox_MouseDown);
			this.Main_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_pictureBox_MouseMove);
			this.Main_pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_pictureBox_MouseUp);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.The_colorsUC, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.SwapColor_button, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.RColor_pictureBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LColor_pictureBox, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 34);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// The_colorsUC
			// 
			this.The_colorsUC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.The_colorsUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.The_colorsUC.Location = new System.Drawing.Point(118, 0);
			this.The_colorsUC.Margin = new System.Windows.Forms.Padding(0);
			this.The_colorsUC.Name = "The_colorsUC";
			this.The_colorsUC.Observer = null;
			this.The_colorsUC.Size = new System.Drawing.Size(732, 34);
			this.The_colorsUC.TabIndex = 0;
			// 
			// SwapColor_button
			// 
			this.SwapColor_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SwapColor_button.AutoSize = true;
			this.SwapColor_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SwapColor_button.Location = new System.Drawing.Point(65, 3);
			this.SwapColor_button.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.SwapColor_button.Name = "SwapColor_button";
			this.SwapColor_button.Size = new System.Drawing.Size(50, 25);
			this.SwapColor_button.TabIndex = 2;
			this.SwapColor_button.Text = "Swap";
			this.SwapColor_button.UseVisualStyleBackColor = true;
			this.SwapColor_button.Click += new System.EventHandler(this.SwapColor_button_Click);
			// 
			// RColor_pictureBox
			// 
			this.RColor_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.RColor_pictureBox.Location = new System.Drawing.Point(34, 3);
			this.RColor_pictureBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.RColor_pictureBox.Name = "RColor_pictureBox";
			this.RColor_pictureBox.Size = new System.Drawing.Size(28, 28);
			this.RColor_pictureBox.TabIndex = 1;
			this.RColor_pictureBox.TabStop = false;
			// 
			// LColor_pictureBox
			// 
			this.LColor_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LColor_pictureBox.Location = new System.Drawing.Point(3, 3);
			this.LColor_pictureBox.Name = "LColor_pictureBox";
			this.LColor_pictureBox.Size = new System.Drawing.Size(28, 28);
			this.LColor_pictureBox.TabIndex = 1;
			this.LColor_pictureBox.TabStop = false;
			// 
			// Main_menuStrip
			// 
			this.Main_menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.Main_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.Main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem,
            this.Image_ToolStripMenuItem,
            this.View_ToolStripMenuItem,
            this.Settings_ToolStripMenuItem,
            this.Help_ToolStripMenuItem});
			this.Main_menuStrip.Location = new System.Drawing.Point(0, 0);
			this.Main_menuStrip.Name = "Main_menuStrip";
			this.Main_menuStrip.Size = new System.Drawing.Size(850, 28);
			this.Main_menuStrip.TabIndex = 0;
			this.Main_menuStrip.Text = "menuStrip1";
			// 
			// File_ToolStripMenuItem
			// 
			this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_ToolStripMenuItem,
            this.Open_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.Save_ToolStripMenuItem,
            this.SaveAs_ToolStripMenuItem});
			this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
			this.File_ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
			this.File_ToolStripMenuItem.Text = "File(&F)";
			// 
			// New_ToolStripMenuItem
			// 
			this.New_ToolStripMenuItem.Name = "New_ToolStripMenuItem";
			this.New_ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
			this.New_ToolStripMenuItem.Text = "New(&N)...";
			this.New_ToolStripMenuItem.Click += new System.EventHandler(this.New_ToolStripMenuItem_Click);
			// 
			// Open_ToolStripMenuItem
			// 
			this.Open_ToolStripMenuItem.Name = "Open_ToolStripMenuItem";
			this.Open_ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
			this.Open_ToolStripMenuItem.Text = "Open(&O)...";
			this.Open_ToolStripMenuItem.Click += new System.EventHandler(this.Open_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
			// 
			// Save_ToolStripMenuItem
			// 
			this.Save_ToolStripMenuItem.Name = "Save_ToolStripMenuItem";
			this.Save_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.Save_ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
			this.Save_ToolStripMenuItem.Text = "Save(&W)";
			this.Save_ToolStripMenuItem.Click += new System.EventHandler(this.Save_ToolStripMenuItem_Click);
			// 
			// SaveAs_ToolStripMenuItem
			// 
			this.SaveAs_ToolStripMenuItem.Name = "SaveAs_ToolStripMenuItem";
			this.SaveAs_ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
			this.SaveAs_ToolStripMenuItem.Text = "Save As(&S)...";
			this.SaveAs_ToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_ToolStripMenuItem_Click);
			// 
			// Edit_ToolStripMenuItem
			// 
			this.Edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo_ToolStripMenuItem,
            this.Redo_ToolStripMenuItem,
            this.toolStripSeparator2,
            this.Copy_ToolStripMenuItem,
            this.Cut_ToolStripMenuItem,
            this.Paste_ToolStripMenuItem,
            this.toolStripSeparator3,
            this.SelectAll_ToolStripMenuItem,
            this.ClearSelection_ToolStripMenuItem});
			this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
			this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.Edit_ToolStripMenuItem.Text = "Edit(&E)";
			// 
			// Undo_ToolStripMenuItem
			// 
			this.Undo_ToolStripMenuItem.Name = "Undo_ToolStripMenuItem";
			this.Undo_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.Undo_ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
			this.Undo_ToolStripMenuItem.Text = "Undo";
			this.Undo_ToolStripMenuItem.Click += new System.EventHandler(this.Undo_ToolStripMenuItem_Click);
			// 
			// Redo_ToolStripMenuItem
			// 
			this.Redo_ToolStripMenuItem.Name = "Redo_ToolStripMenuItem";
			this.Redo_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.Redo_ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
			this.Redo_ToolStripMenuItem.Text = "Redo";
			this.Redo_ToolStripMenuItem.Click += new System.EventHandler(this.Redo_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
			// 
			// Copy_ToolStripMenuItem
			// 
			this.Copy_ToolStripMenuItem.Name = "Copy_ToolStripMenuItem";
			this.Copy_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.Copy_ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
			this.Copy_ToolStripMenuItem.Text = "Copy";
			this.Copy_ToolStripMenuItem.Click += new System.EventHandler(this.Copy_ToolStripMenuItem_Click);
			// 
			// Cut_ToolStripMenuItem
			// 
			this.Cut_ToolStripMenuItem.Name = "Cut_ToolStripMenuItem";
			this.Cut_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.Cut_ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
			this.Cut_ToolStripMenuItem.Text = "Cut";
			this.Cut_ToolStripMenuItem.Click += new System.EventHandler(this.Cut_ToolStripMenuItem_Click);
			// 
			// Paste_ToolStripMenuItem
			// 
			this.Paste_ToolStripMenuItem.Name = "Paste_ToolStripMenuItem";
			this.Paste_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.Paste_ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
			this.Paste_ToolStripMenuItem.Text = "Paste";
			this.Paste_ToolStripMenuItem.Click += new System.EventHandler(this.Paste_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
			// 
			// SelectAll_ToolStripMenuItem
			// 
			this.SelectAll_ToolStripMenuItem.Name = "SelectAll_ToolStripMenuItem";
			this.SelectAll_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.SelectAll_ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
			this.SelectAll_ToolStripMenuItem.Text = "Select All";
			this.SelectAll_ToolStripMenuItem.Click += new System.EventHandler(this.SelectAll_ToolStripMenuItem_Click);
			// 
			// ClearSelection_ToolStripMenuItem
			// 
			this.ClearSelection_ToolStripMenuItem.Name = "ClearSelection_ToolStripMenuItem";
			this.ClearSelection_ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.ClearSelection_ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
			this.ClearSelection_ToolStripMenuItem.Text = "Clear Selection";
			this.ClearSelection_ToolStripMenuItem.Click += new System.EventHandler(this.ClearSelection_ToolStripMenuItem_Click);
			// 
			// Image_ToolStripMenuItem
			// 
			this.Image_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FlipRotate_ToolStripMenuItem,
            this.toolStripSeparator4,
            this.Size_SToolStripMenuItem});
			this.Image_ToolStripMenuItem.Name = "Image_ToolStripMenuItem";
			this.Image_ToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.Image_ToolStripMenuItem.Text = "Image(&I)";
			// 
			// FlipRotate_ToolStripMenuItem
			// 
			this.FlipRotate_ToolStripMenuItem.Name = "FlipRotate_ToolStripMenuItem";
			this.FlipRotate_ToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.FlipRotate_ToolStripMenuItem.Text = "Flip/Rotate(&F)...";
			this.FlipRotate_ToolStripMenuItem.Click += new System.EventHandler(this.FlipRotate_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
			// 
			// Size_SToolStripMenuItem
			// 
			this.Size_SToolStripMenuItem.Name = "Size_SToolStripMenuItem";
			this.Size_SToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.Size_SToolStripMenuItem.Text = "Change Size(&S)...";
			this.Size_SToolStripMenuItem.Click += new System.EventHandler(this.Size_SToolStripMenuItem_Click);
			// 
			// View_ToolStripMenuItem
			// 
			this.View_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowThumbnail_ToolStripMenuItem,
            this.toolStripSeparator5,
            this.ShowGrid_ToolStripMenuItem,
            this.GridSize_ToolStripMenuItem});
			this.View_ToolStripMenuItem.Name = "View_ToolStripMenuItem";
			this.View_ToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.View_ToolStripMenuItem.Text = "View(&V)";
			// 
			// ShowThumbnail_ToolStripMenuItem
			// 
			this.ShowThumbnail_ToolStripMenuItem.Name = "ShowThumbnail_ToolStripMenuItem";
			this.ShowThumbnail_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.ShowThumbnail_ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
			this.ShowThumbnail_ToolStripMenuItem.Text = "Show Thumbnail(&T)";
			this.ShowThumbnail_ToolStripMenuItem.Click += new System.EventHandler(this.ShowThumbnail_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(267, 6);
			// 
			// ShowGrid_ToolStripMenuItem
			// 
			this.ShowGrid_ToolStripMenuItem.Name = "ShowGrid_ToolStripMenuItem";
			this.ShowGrid_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.ShowGrid_ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
			this.ShowGrid_ToolStripMenuItem.Text = "Show Grid(&G)";
			this.ShowGrid_ToolStripMenuItem.Click += new System.EventHandler(this.ShowGrid_ToolStripMenuItem_Click);
			// 
			// GridSize_ToolStripMenuItem
			// 
			this.GridSize_ToolStripMenuItem.Name = "GridSize_ToolStripMenuItem";
			this.GridSize_ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
			this.GridSize_ToolStripMenuItem.Text = "Grid Settings(&S)...";
			this.GridSize_ToolStripMenuItem.Click += new System.EventHandler(this.GridSize_ToolStripMenuItem_Click);
			// 
			// Settings_ToolStripMenuItem
			// 
			this.Settings_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfirmAtSave_ToolStripMenuItem,
            this.ShowFullPathOnCaption_ToolStripMenuItem});
			this.Settings_ToolStripMenuItem.Name = "Settings_ToolStripMenuItem";
			this.Settings_ToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
			this.Settings_ToolStripMenuItem.Text = "Settings(&S)";
			// 
			// ConfirmAtSave_ToolStripMenuItem
			// 
			this.ConfirmAtSave_ToolStripMenuItem.Name = "ConfirmAtSave_ToolStripMenuItem";
			this.ConfirmAtSave_ToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
			this.ConfirmAtSave_ToolStripMenuItem.Text = "Confirmation at \"Save\" time";
			this.ConfirmAtSave_ToolStripMenuItem.Click += new System.EventHandler(this.ConfirmAtSave_ToolStripMenuItem_Click);
			// 
			// ShowFullPathOnCaption_ToolStripMenuItem
			// 
			this.ShowFullPathOnCaption_ToolStripMenuItem.Name = "ShowFullPathOnCaption_ToolStripMenuItem";
			this.ShowFullPathOnCaption_ToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
			this.ShowFullPathOnCaption_ToolStripMenuItem.Text = "Show Full Path on Caption";
			this.ShowFullPathOnCaption_ToolStripMenuItem.Click += new System.EventHandler(this.ShowFullPathOnCaption_ToolStripMenuItem_Click);
			// 
			// Help_ToolStripMenuItem
			// 
			this.Help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Version_ToolStripMenuItem});
			this.Help_ToolStripMenuItem.Name = "Help_ToolStripMenuItem";
			this.Help_ToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
			this.Help_ToolStripMenuItem.Text = "Help(&H)";
			// 
			// Version_ToolStripMenuItem
			// 
			this.Version_ToolStripMenuItem.Name = "Version_ToolStripMenuItem";
			this.Version_ToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
			this.Version_ToolStripMenuItem.Text = "Version(&V)...";
			this.Version_ToolStripMenuItem.Click += new System.EventHandler(this.Version_ToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 491);
			this.Controls.Add(this.Main_toolStripContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.Main_menuStrip;
			this.Name = "MainForm";
			this.Text = "Paint.CAT";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.Main_toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.Main_toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.Main_toolStripContainer.ContentPanel.ResumeLayout(false);
			this.Main_toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.Main_toolStripContainer.TopToolStripPanel.PerformLayout();
			this.Main_toolStripContainer.ResumeLayout(false);
			this.Main_toolStripContainer.PerformLayout();
			this.Main_statusStrip.ResumeLayout(false);
			this.Main_statusStrip.PerformLayout();
			this.Main_panel.ResumeLayout(false);
			this.UD_splitContainer.Panel1.ResumeLayout(false);
			this.UD_splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UD_splitContainer)).EndInit();
			this.UD_splitContainer.ResumeLayout(false);
			this.LR_splitContainer.Panel1.ResumeLayout(false);
			this.LR_splitContainer.Panel2.ResumeLayout(false);
			this.LR_splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LR_splitContainer)).EndInit();
			this.LR_splitContainer.ResumeLayout(false);
			this.ScrollSizeDeside_panel.ResumeLayout(false);
			this.ScrollSizeDeside_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Main_pictureBox)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RColor_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LColor_pictureBox)).EndInit();
			this.Main_menuStrip.ResumeLayout(false);
			this.Main_menuStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer Main_toolStripContainer;
		private System.Windows.Forms.MenuStrip Main_menuStrip;
		private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Edit_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Image_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Help_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Version_ToolStripMenuItem;
		private System.Windows.Forms.StatusStrip Main_statusStrip;
		private System.Windows.Forms.ToolStripMenuItem Open_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Save_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveAs_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Undo_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Redo_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem Copy_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Cut_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Paste_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem SelectAll_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Size_SToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel InfoSpace_toolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel Pos_toolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel Size_toolStripStatusLabel;
		private System.Windows.Forms.PictureBox Main_pictureBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton Zoom_toolStripDropDownButton;
		private System.Windows.Forms.Panel Main_panel;
		private System.Windows.Forms.ToolStripMenuItem New_ToolStripMenuItem;
		private System.Windows.Forms.SplitContainer LR_splitContainer;
		private System.Windows.Forms.SplitContainer UD_splitContainer;
		private ToolsUC The_toolsUC;
		private ColorsUC The_colorsUC;
		private System.Windows.Forms.ToolStripMenuItem ClearSelection_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FlipRotate_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem Settings_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ConfirmAtSave_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ShowFullPathOnCaption_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem View_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ShowThumbnail_ToolStripMenuItem;
		private System.Windows.Forms.PictureBox LColor_pictureBox;
		private System.Windows.Forms.PictureBox RColor_pictureBox;
		private System.Windows.Forms.Button SwapColor_button;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel ScrollSizeDeside_panel;
		private System.Windows.Forms.ToolStripMenuItem ShowGrid_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem GridSize_ToolStripMenuItem;
	}
}

