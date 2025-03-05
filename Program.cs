using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MyKittenPaint
{
	
	/// <summary>
	/// 設定の 保存/復元 用
	/// </summary>
	public class UserSettings : ApplicationSettingsBase
	{
		[UserScopedSetting()]
		[DefaultSettingValue("32")]
		public int ImgWidth
		{//画像サイズ
			get{	return (int)this["ImgWidth"];	}
			set{	this["ImgWidth"] = value;	}
		}

		[UserScopedSetting()]
		[DefaultSettingValue("32")]
		public int ImgHeight
		{//画像サイズ
			get{	return (int)this["ImgHeight"];	}
			set{	this["ImgHeight"] = value;	}
		}

		[UserScopedSetting()]
		[DefaultSettingValue("true")]
		public bool ConfirmAtSave
		{//SaveAs の際に確認を取るか否か
			get{	return (bool)this["ConfirmAtSave"];	}
			set{	this["ConfirmAtSave"] = value;	}
		}

		[UserScopedSetting()]
		[DefaultSettingValue("false")]
		public bool ShowFullPath
		{//キャプションにフルパス名を表示するか否か
			get{	return (bool)this["ShowFullPath"];	}
			set{	this["ShowFullPath"] = value;	}
		}
	}

	//
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );


			////設定ファイル配置用ディレクトリが無い場合は作る
			//if( !System.IO.Directory.Exists( SettingFileDir ) )
			//{
			//	try{	System.IO.Directory.CreateDirectory( SettingFileDir );	}
			//	catch( Exception ex )
			//	{	MessageBox.Show( ex.Message, "CreateDirectory() failed" );	}
			//}

			var Settings = new UserSettings();

			//TODO : 起動時の初期画像サイズはどう決める？
			var MainGUI = new MainForm( Settings );
			Application.Run( MainGUI );
			MainGUI.ModifySettings( Settings );

			Settings.Save();
		}

		///// <summary>"C:\Users\UserName\AppData\Roaming" の下のこのAPP用フォルダパス</summary>
		//public static string SettingFileDir
		//{
		//	get
		//	{
		//		var AppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		//		return System.IO.Path.Combine(AppDataDir, @"PaintDotCat");
		//	}
		//}


	}
}
