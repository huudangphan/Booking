namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_거래처_법인담당자조회
/// </summary>
public class WSP_S_Customer_CorporationManagerFind
{
	public const string SP_NAME = "WSP_S_거래처_법인담당자조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 담당일련번호
		/// </summary>
		[Description("담당일련번호")]
		public int ResponsibilitySerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 담당일련번호
		/// </summary>
		[Column("담당일련번호")]
		public int ResponsibilitySerialNumber { get; set; }
		/// <summary>
		/// 추천인
		/// </summary>
		[Column("추천인")]
		public string Recommender { get; set; }
		/// <summary>
		/// 법인명
		/// </summary>
		[Column("법인명")]
		public string CorporationName { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public string Manager { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 개인정보동의
		/// </summary>
		[Column("개인정보동의")]
		public string PersonalInfoAgree { get; set; }
	}
}