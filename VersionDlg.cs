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
	/// バージョン情報ダイアログ
	/// </summary>
	public partial class VersionDlg : Form
	{
		public VersionDlg(){	InitializeComponent();	}

		private void OK_button_Click(object sender, EventArgs e)
		{	DialogResult = DialogResult.OK;	}

		private void VersionDlg_Load(object sender, EventArgs e)
		{
			if( DesignMode )return;
			Version_label.Text = Properties.Resources.SoftVerStr;
		}
	}
}
