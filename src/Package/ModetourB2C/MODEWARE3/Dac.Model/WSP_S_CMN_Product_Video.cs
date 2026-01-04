namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_상품_동영상
/// </summary>
public class WSP_S_CMN_Product_Video
{
	public const string SP_NAME = "WSP_S_CMN_상품_동영상";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// PLID_LIST
		/// </summary>
		[Description("PLID_LIST")]
		public string PLID_LIST { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 파일크기
		/// </summary>
		[Column("파일크기")]
		public double FileSize { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 파일크기
		/// </summary>
		[Column("파일크기")]
		public double FileSize { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
	}
}