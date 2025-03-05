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
	/// グリッドのサイズ設定用ダイアログ
	/// </summary>
	public partial class GridSizeDlg : Form
	{
		public GridSizeDlg(){	InitializeComponent();	}
		/// <summary>
		/// X方向グリッド幅．
		/// 用途：
		/// * 表示前に現在値を set
		/// * OK で閉じた後に，入力された値を get
		/// </summary>
		public int X_Interval
		{
			get{	return (int)X_numericUpDown.Value;	}
			set{	X_numericUpDown.Value = value;	}
		}

		/// <summary>
		/// Y方向グリッド幅
		/// 用途：
		/// * 表示前に現在値を set
		/// * OK で閉じた後に，入力された値を get
		/// </summary>
		public int Y_Interval
		{
			get{	return (int)Y_numericUpDown.Value;	}
			set{	Y_numericUpDown.Value = value;	}
		}

		/// <summary>
		/// グリッド描画色
		/// 用途：
		/// * 表示前に現在値を set
		/// * OK で閉じた後に，入力された値を get
		/// </summary>
		public Color Grid_Color
		{
			get{	return GridColor_pictureBox.BackColor;	}
			set{	GridColor_pictureBox.BackColor = value;	}
		}

		private void OK_button_Click(object sender, EventArgs e)
		{	DialogResult = DialogResult.OK;	}

		private void Cancel_button_Click(object sender, EventArgs e)
		{	DialogResult = DialogResult.Cancel;	}

		private void GridColor_pictureBox_DoubleClick(object sender, EventArgs e)
		{
			var Dlg = new ColorDialog();
			Dlg.FullOpen = true;
			Dlg.Color = GridColor_pictureBox.BackColor;

			if( Dlg.ShowDialog( this ) != DialogResult.OK )return;

			GridColor_pictureBox.BackColor = Dlg.Color;
		}
	}
}
