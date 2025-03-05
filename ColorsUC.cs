﻿using System;
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
		public const int ColumnSize = 9;
		public const int PalleteSize = ColumnSize*4;
		public readonly PictureBox[] m_PalettePBs;
		public int[] m_CreatedCols;	//ColorDialog.CustomColorsの内容を覚えておく用

		//
		public ColorsUC()
		{
			InitializeComponent();

			var InitCols = new Color[]{
				Color.Black,
				Color.White,
				Color.FromArgb(255,0,0),
				Color.FromArgb(0,255,0),
				Color.FromArgb(0,0,255),
				Color.FromArgb(0,255,255),
				Color.FromArgb(255,0,255),
				Color.FromArgb(255,255,0),
				Color.FromArgb(255,128,64),

				Color.FromArgb(64,64,64),
				Color.FromArgb(128,128,128),
				Color.FromArgb(128,0,0),
				Color.FromArgb(0,128,0),
				Color.FromArgb(0,0,128),
				Color.FromArgb(0,128,128),
				Color.FromArgb(128,0,128),
				Color.FromArgb(128,128,0),
				Color.FromArgb(128,64,0),
				
				Color.FromArgb(192,192,192),
				Color.FromArgb(222,222,222),
				Color.FromArgb(255,164,164),
				Color.FromArgb(164,255,164),
				Color.FromArgb(164,164,255),
				Color.FromArgb(164,255,255),
				Color.FromArgb(255,164,255),
				Color.FromArgb(255,255,164),
				Color.FromArgb(255,192,128)
			};

			m_PalettePBs = new PictureBox[ PalleteSize ];
			for( int i=0; i<PalleteSize; ++i )
			{
				var PB = new PictureBox();
				PB.Size = new Size(20,20);
				PB.BorderStyle = BorderStyle.None;	//※枠があるとクリックしにくいので無しにする（→枠の絵は自前で描画）
				PB.BackColor = ( i<InitCols.Length ? InitCols[i] : Color.White );
				PB.Margin = new Padding(0);	//※隙間があるとクリックしにくいので隙間なく配置する
				PB.MouseDown += this.OnPBMouseDown;	//※色を選択
				PB.MouseDoubleClick += this.OnPBMouseDoubleClick;	//※色を編集
				PB.Paint += this.PB_Paint;	//※枠の絵を自前描画する
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

			{
				//※MEMO :
				//何故か初期状態でフローレイアウトがまともに折り返さずに水平スクロールバーを出してくることへの対処．
				//* Palette_flowLayoutPanel.PerformLayout() だと何の効果も無い模様なので，レイアウト計算が必要になる処理を実施
				//* この場で実施しても効果がありそうだが，
				//  万が一このUCの保有者側のレイアウト処理との順序とかに依存したら嫌（杞憂?）なので BeginInvoke() で投げておく．
				Action Act = () => { LineWrap_checkBox.Checked = true; LineWrap_checkBox.Checked = false; };
				BeginInvoke( Act );
			}
		}

		//パレットの改行ON/OFF
		private void LineWrap_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			for( int i=ColumnSize-1; i<m_PalettePBs.Length; i+=ColumnSize )
			{
				Palette_flowLayoutPanel.SetFlowBreak( m_PalettePBs[i], LineWrap_checkBox.Checked );
			}
		}

		//※MEMO :
		//パレット用のPictureBoxに枠があったり，PictureBox間に隙間があるとクリックし難いので，
		//枠無し且つ隙間なく配置し，枠の絵をクライアント領域内に描画している．
		private void PB_Paint(object sender, PaintEventArgs e)
		{
			var PB = sender as PictureBox;
			if( PB==null )return;

			ControlPaint.DrawBorder3D( e.Graphics, PB.ClientRectangle, Border3DStyle.Sunken );
		}

		//マウス押下：色の選択
		private void OnPBMouseDown(object sender, MouseEventArgs e)
		{
			var PB = sender as PictureBox;
			if( PB==null )return;

			int iDrawColor = Util.DrawColorIndexFor( e.Button );
			if( iDrawColor<0 )return;

			Observer.OnColorSelected( iDrawColor, PB.BackColor );
		}

		//ダブルクリック：色の編集（且つ選択）
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
