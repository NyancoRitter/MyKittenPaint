using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace MyKittenPaint
{
	public static class Util
	{
		/// <summary>
		/// マウスボタンに対応する描画色index (0 or 1) を返す．
		/// </summary>
		/// <param name="button">マウスボタン</param>
		/// <returns>
		/// 描画色index (0 or 1)．
		/// ただし，どちらでもない状況では負の値を返す
		/// </returns>
		public static int DrawColorIndexFor( System.Windows.Forms.MouseButtons button )
		{
			if( button.HasFlag(System.Windows.Forms.MouseButtons.Left) ){	return 0;	}
			if( button.HasFlag(System.Windows.Forms.MouseButtons.Right ) ){	return 1;	}
			else return -1;
		}

		/// <summary>
		/// bmpをDispose()して且つnullにする
		/// </summary>
		/// <param name="bmp"></param>
		public static void DisposeBMP( ref Bitmap bmp )
		{
			if( bmp != null )
			{
				bmp.Dispose();
				bmp = null;
			}
		}

		/// <summary>
		/// ２つの画像を比較．
		/// （ハッシュ計算で実施しているので，完全に正当な結果を返すか否かは不明だが）
		/// </summary>
		/// <param name="BMP1"></param>
		/// <param name="BMP2"></param>
		/// <returns>内容が同一と思われるならtrue</returns>
		public static bool IsSame( Bitmap BMP1, Bitmap BMP2 )
		{
			if( !BMP1.Size.Equals( BMP2.Size ) )return false;

			var Cvter = new System.Drawing.ImageConverter();
			byte[] Bytes1 = new byte[1];
			Bytes1 = (byte[])Cvter.ConvertTo( BMP1, Bytes1.GetType() );
			byte[] Bytes2 = new byte[1];
			Bytes2 = (byte[])Cvter.ConvertTo( BMP2, Bytes2.GetType() );

			SHA256Managed SHA = new SHA256Managed();
			byte[] Hash1 = SHA.ComputeHash( Bytes1 );
			byte[] Hash2 = SHA.ComputeHash( Bytes2 );

			for( int i=0; i<Hash1.Length; ++i )
			{
				if( Hash1[i] != Hash2[i] )return false;
			}
			return true;
		}

		/// <summary>
		/// 画像を指定の拡大率で描画する
		/// </summary>
		/// <param name="g">描画先</param>
		/// <param name="Img">画像</param>
		/// <param name="MagRate">拡大率</param>
		/// <param name="left_x1">描画先座標．ただし，MagRateが乗じられた値が用いられる</param>
		/// <param name="top_x1">描画先座標．ただし，MagRateが乗じられた値が用いられる</param>
		public static void DrawMagnifiedImg( Graphics g, Bitmap Img, int MagRate, int left_x1=0, int top_x1=0 )
		{
			var PreIPMode = g.InterpolationMode;
			var PreOffsetMode = g.PixelOffsetMode;
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
			g.DrawImage( Img, new Rectangle( left_x1*MagRate, top_x1*MagRate, Img.Width*MagRate, Img.Height*MagRate ) );
			g.PixelOffsetMode = PreOffsetMode;
			g.InterpolationMode = PreIPMode;
		}

		/// <summary>
		/// 矩形範囲選択状態の描画
		/// </summary>
		/// <param name="g">描画対象</param>
		/// <param name="Rect">選択範囲</param>
		/// <param name="MagRate">表示拡大率</param>
		/// <param name="DrawWhiteSolidRectInAdvance">破線を描く前に同箇所に白い枠を描く</param>
		public static void DrawRectSelectionState( Graphics g, Rectangle Rect, int MagRate, bool DrawWhiteSolidRectInAdvance=false )
		{
			if( Rect.IsEmpty )return;
			//※実装MEMO:
			//（Graphics の PixelOffsetMode 次第でズレ方が変わるようだが）どう設定しても
			//ごく普通に想定するような描画サイズにならない．
			//サイズを -1 しているのはそのための暫定的な対処．
			var DrawRect = new Rectangle( Rect.X*MagRate, Rect.Y*MagRate, Math.Max(1, Rect.Width*MagRate-1), Math.Max(1, Rect.Height*MagRate-1) );

			if( DrawWhiteSolidRectInAdvance )
			{ g.DrawRectangle( Pens.White, DrawRect ); }

			using( var P = new Pen( Color.Gray ) )
			{
				P.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
				g.DrawRectangle( P, DrawRect );
			}
		}
	}
}
