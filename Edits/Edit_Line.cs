using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//線を描く，ドットを描く　系の実装

namespace MyKittenPaint
{
	/// <summary>
	/// 指定の画素群を指定の色に変える
	/// </summary>
	public class DrawPixels : IEdit, IDraw
	{
		private readonly Point[] m_Points;
		private readonly Color m_Col;
	
		public DrawPixels( IReadOnlyList<Point> Points, Color Col )
		{
			m_Points = Points.OrderBy( p=>p.X ).OrderBy( p=>p.Y ).ToArray();
			m_Col = Col;
		}

		public EditTypes Edit( Content Cont ){	Cont.Draw(this);	return EditTypes.Draw;	}	
		public void Draw( Bitmap BMP )
		{
			if( m_Points.Length < 10 )
			{//少量なら SetPixel でやる
				foreach( var Pos in m_Points ){	BMP.SetPixel( Pos.X, Pos.Y, m_Col );	}
				return;
			}

			//
			int BPP = 0;	//Bytes per Pixel
			if( BMP.PixelFormat == System.Drawing.Imaging.PixelFormat.Format24bppRgb ){	BPP=3;	}
			else if( BMP.PixelFormat == System.Drawing.Imaging.PixelFormat.Format32bppArgb ){	BPP=4;	}
			else {	return;	}

			System.Drawing.Imaging.BitmapData bmpData = BMP.LockBits( new Rectangle( 0,0, BMP.Width,BMP.Height ), System.Drawing.Imaging.ImageLockMode.WriteOnly, BMP.PixelFormat );
			
			byte R = m_Col.R;
			byte G = m_Col.G;
			byte B = m_Col.B;
			unsafe
			{
				IntPtr ptr = bmpData.Scan0;
				foreach( var P in m_Points )
				{
					Byte* p = (Byte*)ptr.ToPointer() + bmpData.Stride*P.Y + P.X*BPP;
					p[0] = B;
					p[1] = G;
					p[2] = R;
				}
			}
			BMP.UnlockBits(bmpData);
		}
	}

	/// <summary>
	/// 指定の色で折れ線描画
	/// </summary>
	public class DrawLines : IEdit, IDraw
	{
		private readonly Point[] m_Points;
		private readonly Color m_Col;
		private int m_Thickness = 1;
	
		public DrawLines( IReadOnlyList<Point> Points, Color Col )
		{
			if( Points.Count<2 )throw new ArgumentException( "Invalid Points" );
			m_Points = Points.ToArray();
			m_Col = Col;
		}

		/// <summary>線の太さ（1以上）</summary>
		public int Thickness
		{
			get{	return m_Thickness;	}
			set{	m_Thickness = Math.Max(1,value);	}
		}

		/// <summary>先端を丸くするか（太さが1のときは無効）</summary>
		public bool RoundEnd{	get;	set;	} = false;

		public EditTypes Edit( Content Cont ){	Cont.Draw(this);	return EditTypes.Draw;	}	
		public void Draw( Bitmap BMP )
		{
			using( var g = Graphics.FromImage( BMP ) )
			{
				using( var Pen = new Pen( m_Col, m_Thickness ) )
				{
					if( m_Thickness>1 && RoundEnd )
					{
						Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
						Pen.EndCap= System.Drawing.Drawing2D.LineCap.Round;
					}
					g.DrawLines( Pen, m_Points );
				}
			}
		}
	}

	/// <summary>
	/// 指定の色で塗りつぶし矩形描画
	/// </summary>
	public class FillRect : IEdit, IDraw
	{
		private readonly Rectangle[] m_Rects;
		private readonly Color m_Col;

		public FillRect( Rectangle Rect, Color Col )
		{	m_Rects = new Rectangle[]{ Rect };	m_Col = Col;	}

		public FillRect( IReadOnlyList<Rectangle> Rects, Color Col )
		{	m_Rects = Rects.ToArray();	m_Col = Col;	}

		public EditTypes Edit( Content Cont ){	Cont.Draw(this);	return EditTypes.Draw;	}	
		public void Draw( Bitmap BMP )
		{
			using( var g = Graphics.FromImage( BMP ) )
			using( var Brush = new SolidBrush(m_Col) )
			{
				foreach( var Rect in m_Rects )
				{	g.FillRectangle( Brush, Rect );	}
			}
		}
	}
}
