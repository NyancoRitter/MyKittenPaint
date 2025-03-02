using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyKittenPaint
{
	/// <summary>
	/// APPのデータ（＝画像データ）を保持
	/// </summary>
	public class Content
	{
		private Bitmap m_BMP;	//画像データ

		//-----------------------------------

		/// <summary>ctor. 初期の画像サイズを指定する</summary>
		/// <param name="w">初期の画像サイズ</param>
		/// <param name="h">初期の画像サイズ</param>
		public Content( int w, int h )
		{	ChangeImgSizeTo(w,h,InitialColor);	}

		//-----------------------------------
		#region public

		/// <summary>初期の画像の色</summary>
		public static Color InitialColor => Color.White;

		/// <summary>現在の画像サイズ</summary>
		public int Width{	get{	return m_BMP.Width;	}	}
		/// <summary>現在の画像サイズ</summary>
		public int Height{	get{	return m_BMP.Height;	}	}
		/// <summary>現在の画像サイズ</summary>
		public Size Size{	get{	return new Size(Width,Height);	}	}

		/// <summary>
		/// 画像内容を引数に差し替える
		/// </summary>
		/// <param name="SrcBMP">
		/// nullであってはならない．
		/// この参照がそのまま保持される点に注意．
		/// </param>
		public void ChangeTo( Bitmap SrcBMP )
		{
			Util.DisposeBMP( ref m_BMP );
			m_BMP = SrcBMP;
		}

		/// <summary>
		/// 画像サイズの変更．
		/// 変更結果には変更前の画像の内容が可能な限り含まれる．
		/// </summary>
		/// <param name="w">新しいサイズ</param>
		/// <param name="h">新しいサイズ</param>
		/// <param name="BaseColor">変更直後の画像全体の色</param>
		/// <returns>
		/// 変更したか否か．
		/// 引数が現在のサイズである場合には何もせずにfalseを返す．
		/// </returns>
		public bool ChangeImgSizeTo( int w, int h, Color BaseColor )
		{
			if( w<0 || h<0 )throw new ArgumentOutOfRangeException( "Invalid Image Size" );

			if( m_BMP!=null && m_BMP.Width==w && m_BMP.Height==h )
			{	return false;	}

			var NewBMP = new Bitmap( w,h, System.Drawing.Imaging.PixelFormat.Format24bppRgb );
			using( var g = Graphics.FromImage( NewBMP ) )
			{
				g.Clear( BaseColor );

				if( m_BMP != null )
				{	
					g.DrawImage( m_BMP, new Point(0,0) );
					m_BMP.Dispose();
				}
			}
			m_BMP = NewBMP;
			return true;
		}

		/// <summary>
		/// 指定pixelの色を取得
		/// </summary>
		/// <param name="pos">pixel座標</param>
		/// <returns>色</returns>
		public Color GetPixel( Point pos ){	return m_BMP.GetPixel( pos.X, pos.Y );	}

		/// <summary>
		/// 現在の画像を指定の拡大率で描画する
		/// </summary>
		/// <param name="g">描画先</param>
		/// <param name="MagRate">拡大率</param>
		public void DrawMagnifiedImgTo( Graphics g, int MagRate ){	Util.DrawMagnifiedImg( g, m_BMP, MagRate );	}

		/// <summary>
		/// 現在の画像のクローンを生成して返す
		/// </summary>
		/// <returns>クローン</returns>
		public Bitmap CreateCurrImgClone(){	return (Bitmap)m_BMP.Clone();	}

		/// <summary>
		/// 現在の画像の部分画像を生成して返す
		/// </summary>
		/// <param name="Rect">範囲</param>
		/// <returns>部分画像</returns>
		public Bitmap CreatePartialImg( Rectangle Rect ){	return m_BMP.Clone( Rect, m_BMP.PixelFormat );	}

		/// <summary>
		/// 描画処理の実施
		/// </summary>
		/// <param name="Painter">描画実施者</param>
		public void Draw( IDraw Painter ){	Painter.Draw( m_BMP );	}

		/// <summary>
		/// 指定ファイル名で画像を保存する．
		/// 失敗時には例外が送出される．
		/// </summary>
		/// <param name="SaveFilePath">保存パス</param>
		/// <param name="format">保存フォーマット</param>
		public void SaveAs( string SaveFilePath, System.Drawing.Imaging.ImageFormat format )
		{	m_BMP.Save( SaveFilePath, format );	}

		/// <summary>
		/// 現在の画像が引数画像と同一か否かを判定．
		/// （編集操作が結果として何もしていないことを判定する用）
		/// </summary>
		/// <param name="BMP"></param>
		/// <returns>判定結果．同一と思われるならtrue</returns>
		public bool IsSame( Bitmap BMP ){	return Util.IsSame( m_BMP, BMP );	}

		#endregion
		//-----------------------------------
		#region private methods



		#endregion
	}
}
