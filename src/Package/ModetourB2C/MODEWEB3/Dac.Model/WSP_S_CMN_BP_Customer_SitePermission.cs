namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_BP거래처_사이트권한
/// </summary>
public class WSP_S_CMN_BP_Customer_SitePermission
{
	public const string SP_NAME = "WSP_S_CMN_BP거래처_사이트권한";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Column("사이트번호")]
		public int SiteNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 전체파일
		/// </summary>
		[Column("전체파일")]
		public string EntireFile { get; set; }
		/// <summary>
		/// 수정파일
		/// </summary>
		[Column("수정파일")]
		public string EditionFile { get; set; }
		/// <summary>
		/// 모니터링
		/// </summary>
		[Column("모니터링")]
		public string Monitoring { get; set; }
	}
}