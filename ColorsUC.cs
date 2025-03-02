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
	/// パレット
	/// </summary>
	public partial class ColorsUC : UserControl
	{
		public const int PalleteSize = 24;
		public readonly PictureBox[] m_PalettePBs;
		public int[] m_CreatedCols;	//ColorDialog.CustomColorsの内容を覚えておく用

		//
		public ColorsUC()
		{
			InitializeComponent();

			var InitCols = new Color[]{
				Color.Black,
				Color.FromArgb(128,128,128),
				Color.FromArgb(128,0,0),
				Color.FromArgb(0,128,0),
				Color.FromArgb(0,0,128),
				Color.FromArgb(0,128,128),
				Color.FromArgb(128,0,128),
				Color.FromArgb(128,128,0),
					
				Color.White,
				Color.FromArgb(192,192,192), 
				Color.FromArgb(255,0,0),
				Color.FromArgb(0,255,0),
				Color.FromArgb(0,0,255),
				Color.FromArgb(0,255,255),
				Color.FromArgb(255,0,255),
				Color.FromArgb(255,255,0),
			};

			m_PalettePBs = new PictureBox[ PalleteSize ];
			for( int i=0; i<PalleteSize; ++i )
			{
				var PB = new PictureBox();
				PB.Size = new Size(20,20);
				PB.BorderStyle = BorderStyle.Fixed3D;
				PB.BackColor = ( i<InitCols.Length ? InitCols[i] : Color.White );
				PB.Margin = new Padding(1);
				PB.MouseDown += this.OnPBMouseDown;
				PB.MouseDoubleClick += this.OnPBMouseDoubleClick;
				m_PalettePBs[i] = PB;
			}
		}

		/// <summary>操作に対する処理の実施者</summary>
		public IColorViewOpListener Observer{	get;	set;	}


		//-----------------------------------
		#region イベントハンドラ

		//FormLoad
		private void ColorsUC_Load(object sender, EventArgs e)
		{
			if( DesignMode )return;
		
			Palette_flowLayoutPanel.Controls.AddRange( m_PalettePBs.ToArray() );
		}

		private void LineWrap_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			for( int i=7; i<m_PalettePBs.Length; i+=8 )
			{
				Palette_flowLayoutPanel.SetFlowBreak( m_PalettePBs[i], LineWrap_checkBox.Checked );
			}
		}

		private void OnPBMouseDown(object sender, MouseEventArgs e)
		{
			var PB = sender as PictureBox;
			if( PB==null )return;

			int iDrawColor = Util.DrawColorIndexFor( e.Button );
			if( iDrawColor<0 )return;

			Observer.OnColorSelected( iDrawColor, PB.BackColor );
		}

		private void OnPBMouseDoubleClick(object sender, MouseEventArgs e)
		{
			if( e.Button != MouseButtons.Left && e.Button != MouseButtons.Right )return;
			var PB = sender as PictureBox;
			if( PB==null )return;

			var Dlg = new ColorDialog();
			Dlg.FullOpen = true;
			Dlg.Color = PB.BackColor;
			if( m_CreatedCols != null )
			{ Dlg.CustomColors = m_CreatedCols; }

			if( Dlg.ShowDialog( this ) != DialogResult.OK )return;

			m_CreatedCols = Dlg.CustomColors;
			PB.BackColor = Dlg.Color;

			Observer.OnColorSelected( (e.Button==MouseButtons.Left) ? 0 : 1, Dlg.Color );
		}


		#endregion
	}
}
