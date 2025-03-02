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
	/// ツール選択UC
	/// </summary>
	public partial class ToolsUC : UserControl
	{
		public ToolsUC(){	InitializeComponent();	}

		/// <summary>操作に対する処理の実施者</summary>
		public IToolViewOpListener Observer{	get;	set;	}

		/// <summary>
		/// タブの選択状態を，指定のツール用のタブに変更する
		/// </summary>
		/// <param name="type"></param>
		public void ChangeCurrSelTab_to( ToolType type )
		{
			//※TabPage.Tag に ToolType が記録されている想定
			for( int i=0; i<Main_tabControl.TabCount; ++i )
			{
				if( type == (ToolType)Main_tabControl.TabPages[i].Tag )
				{
					Main_tabControl.SelectedIndex = i;
					break;
				}
			}
		}

		/// <summary>
		/// 現在のGUI状態からツールの設定を生成して返す
		/// </summary>
		/// <returns></returns>
		public LineTool.Settings CraeteLineToolSetting()
		{
			var Ret = new LineTool.Settings();
			Ret.Thickness = (int)LineWeight_numericUpDown.Value;
			Ret.RoundEnd = RoundEnd_checkBox.Checked;
			return Ret;
		}

		/// <summary>
		/// 現在GUI上で選択されている消しゴムツールのサイズ
		/// </summary>
		public int EraserToolSize
		{
			get
			{
				if( Eraser3x3_radioButton.Checked )return 3;
				if( Eraser7x7_radioButton.Checked )return 7;
				if( Eraser9x9_radioButton.Checked )return 9;
				if( Eraser11x11_radioButton.Checked )return 11;
				return 5;
			}
		}

		//-----------------------------------

		private void UpdateTabText()
		{
			var SelectedTab = Main_tabControl.SelectedTab;
			
			Pen_tabPage.Text = ( Pen_tabPage == SelectedTab  ?  "Pen"  :  "" );
			Line_tabPage.Text = ( Line_tabPage == SelectedTab  ?  "Line"  :  "" );
			Select_tabPage.Text = ( Select_tabPage == SelectedTab  ?  "Select"  :  "" );
			Eraser_tabPage.Text = ( Eraser_tabPage == SelectedTab  ?  "Eraser"  :  "" );
			Fill_tabPage.Text = ( Fill_tabPage == SelectedTab  ?  "Fill"  :  "" );
		}

		//-----------------------------------
		#region UC イベント

		//Load
		private void ToolsUC_Load(object sender, EventArgs e)
		{
			if( DesignMode )return;

			//TabPage.Tag に ToolType を記録しておく．
			Pen_tabPage.Tag = ToolType.Pen;
			Line_tabPage.Tag = ToolType.Line;
			Select_tabPage.Tag = ToolType.Select;
			Eraser_tabPage.Tag = ToolType.Eraser;
			Fill_tabPage.Tag = ToolType.Fill;

			//
			UpdateTabText();

			//
			RectSelMode_radioButton.Checked = true;
			Eraser5x5_radioButton.Checked = true;
			
			//※自由選択は未実装※
			FreeFormSelMode_radioButton.Enabled = false;
			FreeFormSelMode_pictureBox.Enabled = false;
		}
		
		//タブ選択変更時
		private void Main_tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			//※TabPage.Tag に ToolType が記録されている想定
			Observer?.OnSelectedToolChanged( (ToolType)Main_tabControl.SelectedTab.Tag );
			//
			UpdateTabText();
		}

		#endregion
		//-----------------------------------
		#region Line Tool

		private void ResetLineWeight_button_Click(object sender, EventArgs e)
		{	LineWeight_numericUpDown.Value = 1;	}


		#endregion
		//-----------------------------------
		#region Select Tool

		private void RectSelMode_radioButton_CheckedChanged(object sender, EventArgs e){	Observer?.OnSelectionModeChanged( SelectionModeType.Rectangle );	}
		private void RectSelMode_pictureBox_Click(object sender, EventArgs e){	RectSelMode_radioButton.Checked = true;	}

		private void FreeFormSelMode_radioButton_CheckedChanged(object sender, EventArgs e){	Observer?.OnSelectionModeChanged( SelectionModeType.FreeForm );	}
		private void FreeFormSelMode_pictureBox_Click(object sender, EventArgs e){	FreeFormSelMode_radioButton.Checked = true;	}

		private void TransBackColor_checkBox_CheckedChanged(object sender, EventArgs e){	Observer?.OnTransBackModeChanged( TransBackColor_checkBox.Checked );	}
		private void TransBackColor_pictureBox_Click(object sender, EventArgs e){	TransBackColor_checkBox.Checked = !TransBackColor_checkBox.Checked;	}

		#endregion
		//-----------------------------------

	}
}
