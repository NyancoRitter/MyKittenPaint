using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKittenPaint
{
	/// <summary>
	/// APPのメインウィンドウ
	/// </summary>
	public partial class MainForm : Form, IView
	{
		private readonly Presenter m_Presenter;	//APPロジック
		private ThumbnailForm m_ThumbnailForm;	//サムネイル表示
		private bool m_IsInMenuActiveCondition = false;	//メニュー操作状態にあるか否か
		private ColorEditor m_ColorEditor = new ColorEditor();

		//-----------------------------------

		/// <summary>default ctor</summary>
		public MainForm(){	InitializeComponent();	}

		/// <summary>実用ctor</summary>
		/// <param name="Settings">設定</param>
		public MainForm( UserSettings Settings )
			: this()
		{
			m_Presenter = new Presenter( Settings.ImgWidth, Settings.ImgHeight, this );

			ConfirmAtSave_ToolStripMenuItem.Checked = Settings.ConfirmAtSave;
			ShowFullPathOnCaption_ToolStripMenuItem.Checked = Settings.ShowFullPath;
		}

		/// <summary>
		/// 引数オブジェクトの内容をを現在の設定状態にする
		/// </summary>
		/// <param name="Settings">現在の設定状態受取</param>
		public void ModifySettings( UserSettings Settings )
		{
			Settings.ImgWidth = m_Presenter.ImgWidth;
			Settings.ImgHeight = m_Presenter.ImgHeight;
			Settings.ConfirmAtSave = ConfirmAtSave_ToolStripMenuItem.Checked;
			Settings.ShowFullPath = ShowFullPathOnCaption_ToolStripMenuItem.Checked;
		}

		//-----------------------------------
		#region override

		//まず Presenter にキー処理の機会を与える
		protected override bool ProcessCmdKey( ref System.Windows.Forms.Message Msg, System.Windows.Forms.Keys keys )
		{
			if( !m_IsInMenuActiveCondition )	//メニューが最優先
			{
				if( m_Presenter.ProcessKeyInput( keys ) )return true;
			}
			return base.ProcessCmdKey( ref Msg, keys );
		}

		#endregion
		//-----------------------------------
		#region private methods

		/// <summary>画像表示域のサイズを現在の状況に合わせて変更</summary>
		private void UpdateImgViewSize()
		{
			int Rate = m_Presenter.ViewMagnificationRate;
			Main_pictureBox.ClientSize = new Size( m_Presenter.ImgWidth*Rate, m_Presenter.ImgHeight*Rate );
			Main_pictureBox.Invalidate();
			UpdateThumbnail();
		}

		/// <summary>Undo , Redo メニューの状態更新</summary>
		private void UpdateUndoRedoMenuState()
		{
			Undo_ToolStripMenuItem.Enabled = m_Presenter.CanUndo();
			Redo_ToolStripMenuItem.Enabled = m_Presenter.CanRedo();

			DiscardUnoRedoData_ToolStripMenuItem.Enabled = ( m_Presenter.CanUndo() || m_Presenter.CanRedo() );
		}

		/// <summary>画像保存処理</summary>
		/// <param name="SaveFilePath">保存パス</param>
		private void SaveAs( string SaveFilePath )
		{
			try
			{
				if( !m_Presenter.SaveAs( SaveFilePath ) )
				{
					MessageBox.Show( this, "Not possible currently...", "Save was not executed" );
					return;
				}
			}
			catch( Exception ex )
			{
				MessageBox.Show( this, ex.Message + Environment.NewLine + "(" + SaveFilePath + ")", "Save failed" );
				return;
			}

			InfoSpace_toolStripStatusLabel.Text = "[" + DateTime.Now.ToLongTimeString() + "] Saved " + System.IO.Path.GetFileName(SaveFilePath);
			UpdateCaption();
		}

		/// <summary>画像読込処理</summary>
		/// <param name="LoadFilePath">読込ファイルパス</param>
		private void LoadFrom( string LoadFilePath )
		{
			if( !m_Presenter.IsImageJustAfterInitialized )
			{
				if(
					MessageBox.Show(
						this,
						"Current data will be discarded." + Environment.NewLine +
						"Are you sure you want to load from the following path?" + Environment.NewLine + Environment.NewLine + LoadFilePath,
						"Confirmation",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Exclamation
					)
					!= DialogResult.OK
				)
				{	return;	}
			}

			try
			{
				if( !m_Presenter.LoadFrom( LoadFilePath ) )
				{
					MessageBox.Show( this, "Not possible currently...", "Load was not executed" );
					return;
				}
			}
			catch( Exception ex )
			{
				MessageBox.Show( this, ex.Message + Environment.NewLine + "(" + LoadFilePath + ")", "Load failed" );
				return;
			}

			InfoSpace_toolStripStatusLabel.Text = "[" + DateTime.Now.ToLongTimeString() + "] Loaded " + System.IO.Path.GetFileName(LoadFilePath);
			UpdateCaption();
		}

		/// <summary>
		/// SaveやLoadを実施した際のタイトル文字列の変更．
		/// タイトルにファイル名を表示する．
		/// ただし，新規作成直後の場合にはAPP名称のみを表示．
		/// </summary>
		private void UpdateCaption()
		{
			string APPName = "Paint.CAT";
			string FilePath = m_Presenter.LastSaveLoadFilePath;
			if( FilePath.Length==0 ){	this.Text = APPName;	}
			else
			{
				if( !ShowFullPathOnCaption_ToolStripMenuItem.Checked )
				{	FilePath = System.IO.Path.GetFileName( FilePath );	}

				this.Text = FilePath + " - " + APPName;
			}
		}

		/// <summary>サムネイルウィンドウの可視性変更時</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnThumbnailFormVisibilityChanged(object sender, EventArgs e)
		{
			ShowThumbnail_ToolStripMenuItem.Checked = m_ThumbnailForm.Visible;
			if( m_ThumbnailForm.Visible )m_ThumbnailForm.UpdateImg();
		}

		/// <summary>サムネイルウィンドウの表示更新</summary>
		private void UpdateThumbnail()
		{
			if( m_ThumbnailForm!=null  &&  m_ThumbnailForm.Visible )
			{	m_ThumbnailForm.UpdateImg();	}
		}

		/// <summary>指定ボタンの色のエディット</summary>
		/// <param name="ButtonIndex">ボタン指定．0 or 1</param>
		private void EditDrawColor( int ButtonIndex )
		{
			if( !m_Presenter.CanShowModalDlg() )return;

			Color PrevCol = ( ButtonIndex==0 ? m_Presenter.CurrLColor : m_Presenter.CurrRColor );
			Color EditedCol = new Color();
			if( !m_ColorEditor.Edit( PrevCol, out EditedCol, this ) )return;
			m_Presenter.OnColorSelected( ButtonIndex, EditedCol );
		}

		#endregion
		//-----------------------------------
		#region IView Impl

		/// <inheritdoc/>
		public void UpdateDisplayOfCursorPos( Point ImgPos )
		{	Pos_toolStripStatusLabel.Text = $"({ImgPos.X}, {ImgPos.Y})";	}

		/// <inheritdoc/>
		public void OnImgSizeChanged()
		{
			UpdateImgViewSize();
			UpdateSizeInfoView( new Size(m_Presenter.ImgHeight, m_Presenter.ImgHeight) );
			UpdateUndoRedoMenuState();
		}

		/// <inheritdoc/>
		public void OnViewMagRateChanged()
		{
			//画像表示域のサイズを変更
			UpdateImgViewSize();
			//拡大率選択GUIの更新
			int Rate = m_Presenter.ViewMagnificationRate;
			Zoom_toolStripDropDownButton.Text = $"  {Rate*100}%  ";
			foreach( ToolStripMenuItem Item in Zoom_toolStripDropDownButton.DropDownItems )
			{	Item.Checked = ( (int)Item.Tag == Rate );	}
		}

		/// <inheritdoc/>
		public void OnSelectedColorChanged( int index, Color col )
		{
			if( index==0 )LColor_pictureBox.BackColor = col;
			else RColor_pictureBox.BackColor = col;
		}

		/// <inheritdoc/>
		public void OnImgPainted()
		{
			Main_pictureBox.Invalidate();
			UpdateThumbnail();
			UpdateUndoRedoMenuState();
		}

		/// <inheritdoc/>
		public void OnToolSelectionChangedTo( ToolType type ){	The_toolsUC.ChangeCtrlState_WhenCurrSelToolChanged(type);	}

		/// <inheritdoc/>
		public LineTool.Settings CraeteLineToolSetting(){	return The_toolsUC.CraeteLineToolSetting();	}

		/// <inheritdoc/>
		public int GetEraserToolSize(){	return The_toolsUC.EraserToolSize;	}

		/// <inheritdoc/>
		public bool IsRectModeSelectedForSelectionTool(){	return The_toolsUC.IsRectModeSelectedForSelectionTool();	}

		/// <inheritdoc/>
		public void OnSelectionStateChanged( bool Selected )
		{
			Main_pictureBox.Invalidate();
			Copy_ToolStripMenuItem.Enabled = Selected;
			Cut_ToolStripMenuItem.Enabled = Selected;
			ClearSelection_ToolStripMenuItem.Enabled = Selected;
			PasteTo_ToolStripMenuItem.Enabled = Selected;

			if( !Selected )
			{	UpdateSizeInfoView( new Size(m_Presenter.ImgHeight, m_Presenter.ImgHeight) );	}
		}

		/// <inheritdoc/>
		public void UpdateSizeInfoView( Size size )
		{	Size_toolStripStatusLabel.Text = $"({size.Width}x{size.Height})";	}

		/// <inheritdoc/>
		public void ChangeImgViewCursorTo( System.Windows.Forms.Cursor NewCursor )
		{	Main_pictureBox.Cursor = NewCursor;	}

		#endregion
		//-----------------------------------
		#region Form Event

		//FormLoad
		private void MainForm_Load(object sender, EventArgs e)
		{
			if( DesignMode )return;

			try
			{
				this.SuspendLayout();

				InfoSpace_toolStripStatusLabel.Text = Properties.Resources.SoftVerStr;
				UpdateCaption();

				{//拡大率ドロップダウン準備
					var Rates = new int[]{ 1,2,3,4,5,6,8,10,12,14,16,20,24 };
					var Items = new ToolStripItem[ Rates.Length ];
					for( int i=0; i<Rates.Length; ++i )
					{
						Items[i] = new ToolStripMenuItem( $"{Rates[i]*100}%" );
						Items[i].Tag = Rates[i];	//※拡大倍率を Tag に保持する
					}
					Zoom_toolStripDropDownButton.DropDownItems.AddRange( Items );
				}

				LR_splitContainer.SplitterWidth = 8;
				UD_splitContainer.SplitterWidth = 8;
				
				The_toolsUC.Observer = m_Presenter;
				The_colorsUC.Observer = m_Presenter;
				The_colorsUC.ColEditor = m_ColorEditor;

				{//起動時に開くファイルが指定されている場合
					var CmdLineArgs = Environment.GetCommandLineArgs();
					if( CmdLineArgs.Length >= 2 )
					{	LoadFrom( CmdLineArgs[1] );	}
				}

				//Viewの初期化
				m_Presenter.ViewInitialization();
			}
			catch( Exception ex )
			{	MessageBox.Show( this, ex.Message, "Exception in MainForm_Load" );	}
			finally
			{	this.ResumeLayout();	}
		}

		//FormClosing
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if( !m_Presenter.IsImageJustAfterInitialized )
			{
				if( MessageBox.Show( this, "Are you sure you want to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation ) != DialogResult.OK )
				{	e.Cancel = true;	}
			}
		}

		//拡大率ドロップダウンリストの選択変更
		private void Zoom_toolStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{	m_Presenter.ViewMagnificationRate = (int)e.ClickedItem.Tag;	}

		//画像エリアでのマウスダウン
		private void Main_pictureBox_MouseDown(object sender, MouseEventArgs e)
		{	m_Presenter.OnMouseDown( e.Location, e.Button );	}

		//画像エリアでのマウスアップ
		private void Main_pictureBox_MouseUp(object sender, MouseEventArgs e)
		{	m_Presenter.OnMouseUp( e.Location, e.Button );	}

		//画像エリアでのマウス移動
		private void Main_pictureBox_MouseMove(object sender, MouseEventArgs e)
		{	m_Presenter.OnMouseMove( e.Location );	}

		//画像表示域の描画
		private void Main_pictureBox_Paint(object sender, PaintEventArgs e)
		{	m_Presenter.DrawCurrentView( e.Graphics );	}

		//画像エリア外でのマウスクリック
		private void LR_splitContainer_Panel2_MouseClick(object sender, MouseEventArgs e){	m_Presenter.OnOutsidePosClicked( e.Button );	}
		private void ScrollSizeDeside_panel_MouseClick(object sender, MouseEventArgs e){	m_Presenter.OnOutsidePosClicked( e.Button );	}

		//色 SWAP ボタン
		private void SwapColor_button_Click(object sender, EventArgs e){	m_Presenter.SwapLRColor();	}

		//左カラーダブルクリック
		private void LColor_pictureBox_DoubleClick( object sender, EventArgs e ){	EditDrawColor(0);	}
		//右カラーダブルクリック
		private void RColor_pictureBox_DoubleClick( object sender, EventArgs e ){	EditDrawColor(1);	}

		//ドラッグ＆ドロップの受付判定
		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if( e.Data.GetDataPresent( DataFormats.FileDrop ) )
			{	e.Effect = DragDropEffects.Copy;	}
			else
			{	e.Effect = DragDropEffects.None;	}
		}

		//ドロップ時
		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			if( !e.Data.GetDataPresent( DataFormats.FileDrop ) )return;
			var FileNames = (string[])e.Data.GetData( DataFormats.FileDrop, false );
			LoadFrom( FileNames[0] );
		}

		//メニュー操作状態に入ったとき
		private void Main_menuStrip_MenuActivate(object sender, EventArgs e){	m_IsInMenuActiveCondition = true;	}
		//メニュー操作状態から抜けたとき
		private void Main_menuStrip_MenuDeactivate(object sender, EventArgs e){	m_IsInMenuActiveCondition = false;	}

		#endregion
		//-----------------------------------
		#region File Menu

		//新規
		private void New_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( !m_Presenter.CanShowModalDlg() )return;
			using( var Dlg = new SizeDlg() )
			{
				Dlg.ImgWidth = m_Presenter.ImgWidth;
				Dlg.ImgHeight = m_Presenter.ImgHeight;

				if( Dlg.ShowDialog( this ) != DialogResult.OK )return;
				m_Presenter.StartNew( Dlg.ImgWidth, Dlg.ImgHeight );
			}

			UpdateCaption();
			InfoSpace_toolStripStatusLabel.Text = "[" + DateTime.Now.ToLongTimeString() + "] Started New";
		}

		//開く
		private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( !m_Presenter.CanShowModalDlg() )return;
			using( var ofd = new OpenFileDialog() )
			{
				ofd.Filter = "BMP(*.bmp)|*.bmp|PNG(*.png)|*.png|JPG(*jpg)|*.jpg|Img Files(*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
				ofd.FilterIndex = 2;
				ofd.CheckFileExists = true;
				ofd.Multiselect = false;
				if( ofd.ShowDialog() != DialogResult.OK )return;
				LoadFrom( ofd.FileName );
			}
		}

		//上書保存
		private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( !m_Presenter.CanShowModalDlg() )return;	//※処理中だとまずいので「名前をつけて…」と同様の対処

			var OverwirtePath = m_Presenter.LastSaveLoadFilePath;
			if( OverwirtePath.Length==0 )
			{
				SaveAs_ToolStripMenuItem_Click( sender, e );
				return;
			}

			if( ConfirmAtSave_ToolStripMenuItem.Checked )
			{
				if(
					MessageBox.Show(
						this,
						"Save (overwrite) to the following path?" + Environment.NewLine + Environment.NewLine + OverwirtePath,
						"Confirmation",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Exclamation
					) != DialogResult.OK )
				{	return;	}
			}

			SaveAs( OverwirtePath );
		}

		//名前を付けて保存
		private void SaveAs_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( !m_Presenter.CanShowModalDlg() )return;
			using( var sfd = new SaveFileDialog() )
			{
				sfd.Filter = "BMP(*.bmp)|*.bmp|PNG(*.png)|*.png|JPG(*jpg)|*.jpg";
				sfd.FileName = "untitled";
				sfd.FilterIndex = 2;
				sfd.OverwritePrompt = true;
				if( sfd.ShowDialog() != DialogResult.OK )return;
				SaveAs( sfd.FileName );
			}
		}

		#endregion
		//-----------------------------------
		#region Edit Menu

		//Undo
		private void Undo_ToolStripMenuItem_Click(object sender, EventArgs e){	m_Presenter.Undo();	}
		//Redo
		private void Redo_ToolStripMenuItem_Click(object sender, EventArgs e){	m_Presenter.Redo();	}

		//Discard Undo/Redo Data
		private void DiscardUnoRedoData_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(
				MessageBox.Show(
					this,
					"Are you sure you want to discard edit_history_data?",
					"Confirmation",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Exclamation
				)
				!= DialogResult.OK
			)
			{	return;	}
			m_Presenter.DiscardEditHistoryData();
			UpdateUndoRedoMenuState();
		}

		//Copy
		private void Copy_ToolStripMenuItem_Click(object sender, EventArgs e){	m_Presenter.Copy();	}
		//Cut
		private void Cut_ToolStripMenuItem_Click(object sender, EventArgs e){	m_Presenter.Cut();	}
		//Paste
		private void Paste_ToolStripMenuItem_Click(object sender, EventArgs e){	m_Presenter.Paste();	}

		//Select All
		private void SelectAll_ToolStripMenuItem_Click(object sender, EventArgs e){	m_Presenter.SelectAll();	}
		//Clear Selection
		private void ClearSelection_ToolStripMenuItem_Click(object sender, EventArgs e){	m_Presenter.ClearSelection();	}

		//Paste To
		private void PasteTo_ToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if( !m_Presenter.CanShowModalDlg() )return;
			using( var sfd = new SaveFileDialog() )
			{
				sfd.Filter = "BMP(*.bmp)|*.bmp|PNG(*.png)|*.png|JPG(*jpg)|*.jpg";
				sfd.FileName = "untitled";
				sfd.FilterIndex = 2;
				sfd.OverwritePrompt = true;
				if( sfd.ShowDialog() != DialogResult.OK )return;

				try
				{
					if( !m_Presenter.SaveSelectedAreaAs( sfd.FileName ) )
					{
						MessageBox.Show( this, "Not possible currently...", "Save was not executed" );
						return;
					}
				}
				catch( Exception ex )
				{
					MessageBox.Show( this, ex.Message + Environment.NewLine + "(" + sfd.FileName + ")", "Save failed" );
					return;
				}

				InfoSpace_toolStripStatusLabel.Text = "[" + DateTime.Now.ToLongTimeString() + "] Pasted To " + System.IO.Path.GetFileName(sfd.FileName);
			}
		}

		#endregion
		//-----------------------------------
		#region Image Menu

		//画像サイズ変更
		private void Size_SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( !m_Presenter.CanShowModalDlg() )return;
			using( var Dlg = new SizeDlg() )
			{
				Dlg.ImgWidth = m_Presenter.ImgWidth;
				Dlg.ImgHeight = m_Presenter.ImgHeight;

				if( Dlg.ShowDialog( this ) == DialogResult.OK )
				{	m_Presenter.ChangeImgSizeTo( Dlg.ImgWidth, Dlg.ImgHeight );	}
			}
		}

		//Flip/Rotate
		private void FlipRotate_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( !m_Presenter.CanShowModalDlg() )return;

			using( var Dlg = new FlipRotateDlg() )
			{
				if( Dlg.ShowDialog( this ) != DialogResult.OK )return;
				m_Presenter.RotateFlip( Dlg.SelectedActionType );
			}
		}

		#endregion
		//-----------------------------------
		#region Help Menu

		//バージョン情報
		private void Version_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( !m_Presenter.CanShowModalDlg() )return;
			using( var Dlg = new VersionDlg() )
			{	Dlg.ShowDialog( this );	}
		}

		#endregion
		//-----------------------------------
		#region Settings Menu

		//上書保存時に確認を取る
		private void ConfirmAtSave_ToolStripMenuItem_Click(object sender, EventArgs e)
		{	ConfirmAtSave_ToolStripMenuItem.Checked = !ConfirmAtSave_ToolStripMenuItem.Checked;	}

		//タイトルにファイル名をフルパスで表示する
		private void ShowFullPathOnCaption_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowFullPathOnCaption_ToolStripMenuItem.Checked = !ShowFullPathOnCaption_ToolStripMenuItem.Checked;
			UpdateCaption();
		}

		#endregion

		//-----------------------------------
		#region View Menu

		//サムネイル表示
		private void ShowThumbnail_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( m_ThumbnailForm==null )
			{
				m_ThumbnailForm = new ThumbnailForm( m_Presenter );
				m_ThumbnailForm.VisibleChanged += OnThumbnailFormVisibilityChanged;
				m_ThumbnailForm.Show( this );
				m_ThumbnailForm.UpdateImg();
			}
			else
			{	m_ThumbnailForm.Visible = !m_ThumbnailForm.Visible;	}
		}

		//グリッド表示
		private void ShowGrid_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowGrid_ToolStripMenuItem.Checked = !ShowGrid_ToolStripMenuItem.Checked;
			m_Presenter.GridVisible = ShowGrid_ToolStripMenuItem.Checked;
		}

		//グリッド設定
		private void GridSize_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( !m_Presenter.CanShowModalDlg() )return;

			using( var Dlg = new GridSizeDlg() )
			{
				Dlg.X_Interval = m_Presenter.GridSize.Width;
				Dlg.Y_Interval = m_Presenter.GridSize.Height;
				Dlg.Grid_Color = m_Presenter.GridColor;

				if( Dlg.ShowDialog(this) != DialogResult.OK )return;

				m_Presenter.GridSize = new Size( Dlg.X_Interval, Dlg.Y_Interval );
				m_Presenter.GridColor = Dlg.Grid_Color;
			}
		}

		#endregion
		//-----------------------------------
		#region Color Menu

		//左ボタン色
		private void LeftColor_ToolStripMenuItem_Click( object sender, EventArgs e ){	EditDrawColor(0);	}
		//右ボタン色
		private void RightColor_ToolStripMenuItem_Click( object sender, EventArgs e ){	EditDrawColor(1);	}

		#endregion
	}
}
