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
	/// 画像のサイズを入力するダイアログ．
	/// モーダル想定．
	/// </summary>
	public partial class SizeDlg : Form
	{
		public SizeDlg(){	InitializeComponent();	}

		/// <summary>設定可能な最大幅</summary>
		public int MaxWidth
		{
			get{	return (int)Width_numericUpDown.Maximum;	}
			set
			{
				if( value < 1 )throw new ArgumentOutOfRangeException( "Invalid MaxWidth" );	
				Width_numericUpDown.Maximum = value;
			}
		}
		
		/// <summary>設定可能な最大高さ</summary>
		public int MaxHeight
		{
			get{	return (int)Height_numericUpDown.Maximum;	}
			set
			{
				if( value < 1 )throw new ArgumentOutOfRangeException( "Invalid MaxHeight" );	
				Height_numericUpDown.Maximum = value;
			}
		}

		/// <summary>
		/// 画像幅．
		/// 用途：
		/// * 表示前に現在値を set
		/// * OK で閉じた後に，入力された値を get
		/// </summary>
		public int ImgWidth
		{
			get{	return (int)Width_numericUpDown.Value;	}
			set{	Width_numericUpDown.Value = value;	}
		}

		/// <summary>
		/// 画像高さ：
		/// 用途：
		/// * 表示前に現在値を set
		/// * OK で閉じた後に，入力された値を get
		/// </summary>
		public int ImgHeight
		{
			get{	return (int)Height_numericUpDown.Value;	}
			set{	Height_numericUpDown.Value = value;	}
		}

		//-----------------------------------
		#region イベントハンドラ

		private void OK_button_Click(object sender, EventArgs e)
		{	DialogResult = DialogResult.OK;	}

		private void Cancel_button_Click(object sender, EventArgs e)
		{	DialogResult = DialogResult.Cancel;	}

		#endregion
	}
}
