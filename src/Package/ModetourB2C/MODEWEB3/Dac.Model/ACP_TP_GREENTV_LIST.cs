namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_GREENTV_LIST
/// </summary>
public class ACP_TP_GREENTV_LIST
{
	public const string SP_NAME = "ACP_TP_GREENTV_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Description("GT_IDX")]
		public int GT_IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Column("GT_IDX")]
		public int GT_IDX { get; set; }
		/// <summary>
		/// RESDATE
		/// </summary>
		[Column("RESDATE")]
		public string RESDATE { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// CONTENTS
		/// </summary>
		[Column("CONTENTS")]
		public string CONTENTS { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// MCOST
		/// </summary>
		[Column("MCOST")]
		public string MCOST { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE2 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Column("GT_IDX")]
		public int GT_IDX { get; set; }
		/// <summary>
		/// ITM_SORT
		/// </summary>
		[Column("ITM_SORT")]
		public int ITM_SORT { get; set; }
		/// <summary>
		/// TAB_TITLE
		/// </summary>
		[Column("TAB_TITLE")]
		public string TAB_TITLE { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// MCOST
		/// </summary>
		[Column("MCOST")]
		public string MCOST { get; set; }
		/// <summary>
		/// FTDATE
		/// </summary>
		[Column("FTDATE")]
		public string FTDATE { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// AIRNAMES
		/// </summary>
		[Column("AIRNAMES")]
		public string AIRNAMES { get; set; }
		/// <summary>
		/// TAB_CONTENTS
		/// </summary>
		[Column("TAB_CONTENTS")]
		public string TAB_CONTENTS { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Column("GT_IDX")]
		public int GT_IDX { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// MCOST
		/// </summary>
		[Column("MCOST")]
		public string MCOST { get; set; }
		/// <summary>
		/// INTEDATE
		/// </summary>
		[Column("INTEDATE")]
		public string INTEDATE { get; set; }
		/// <summary>
		/// IMGURL
		/// </summary>
		[Column("IMGURL")]
		public string IMGURL { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Column("GT_IDX")]
		public int GT_IDX { get; set; }
		/// <summary>
		/// RESDATE
		/// </summary>
		[Column("RESDATE")]
		public string RESDATE { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// MCOST
		/// </summary>
		[Column("MCOST")]
		public string MCOST { get; set; }
		/// <summary>
		/// CLOSEYN
		/// </summary>
		[Column("CLOSEYN")]
		public string CLOSEYN { get; set; }
	}
}