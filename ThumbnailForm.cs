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
	public partial class ThumbnailForm : Form
	{
		private readonly Presenter m_Presenter;

		private ThumbnailForm()
		{	InitializeComponent();	}

		public ThumbnailForm( Presenter presenter )
			: this()
		{	m_Presenter = presenter;	}

		public void UpdateImg()
		{
			if( m_Presenter.ImgWidth != Thumbnail_pictureBox.ClientSize.Width  ||  m_Presenter.ImgHeight != Thumbnail_pictureBox.ClientSize.Height )
			{	Thumbnail_pictureBox.ClientSize = new Size( m_Presenter.ImgWidth, m_Presenter.ImgHeight );	}

			Thumbnail_pictureBox.Invalidate();
		}

		private void ThumbnailForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if( e.CloseReason == CloseReason.UserClosing )
			{
				e.Cancel = true;
				this.Visible = false;
			}
		}

		private void Thumbnail_pictureBox_Paint(object sender, PaintEventArgs e)
		{	m_Presenter.DrawThumbnail( e.Graphics );	}
	}
}
