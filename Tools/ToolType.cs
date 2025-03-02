
namespace MyKittenPaint
{
	/// <summary>
	/// 描画ツール種類
	/// </summary>
	public enum ToolType
	{
		/// <summary>ペン</summary>
		Pen,
		/// <summary>直線</summary>
		Line,
		/// <summary>選択</summary>
		Select,
		/// <summary>消しゴム</summary>
		Eraser,
		/// <summary>塗りつぶし</summary>
		Fill
	}

	/// <summary>
	/// 範囲選択モード
	/// </summary>
	public enum SelectionModeType
	{
		/// <summary>矩形</summary>
		Rectangle,
		/// <summary>自由形状</summary>
		FreeForm
	}

}